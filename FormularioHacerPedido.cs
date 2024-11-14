using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_Clave4
{
    public partial class FormularioHacerPedido : Form
    {
        private Dictionary<string, int> productoIDMap = new Dictionary<string, int>();
        private int? eventoID;
        public FormularioHacerPedido(int eventoID)
        {
            InitializeComponent();
            this.eventoID = eventoID;
            CargarDatos();
        }

        public FormularioHacerPedido()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            Clases.Crud crud = new Clases.Crud();
            DataTable dt = crud.ObtenerProductosDisponibles();
            dgvProductosDisponibles.DataSource = dt;

            // Llenar el diccionario con Nombre_Producto y Producto_ID
            foreach (DataRow row in dt.Rows)
            {
                string nombreProducto = row["Nombre_Producto"].ToString();
                int productoID = Convert.ToInt32(row["Producto_ID"]);
                if (!productoIDMap.ContainsKey(nombreProducto))
                {
                    productoIDMap.Add(nombreProducto, productoID);
                }
            }
        }

       
        private void FormularioHacerPedido_Load(object sender, EventArgs e)
        {
            if (eventoID.HasValue)
            {
                txtEventoID.Text = eventoID.Value.ToString();
            }
            else
            {
                txtEventoID.Text = "No se ha seleccionado un evento";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación: Verificar que se seleccionó un Local
            if (cmbLocal.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un local.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación: Verificar que se seleccionó un Tipo de Pago
            if (cmbTipoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un tipo de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación: Verificar que el campo Total tiene un valor válido
            if (string.IsNullOrWhiteSpace(txtTotal.Text) || !decimal.TryParse(txtTotal.Text, out decimal totalPago))
            {
                MessageBox.Show("Por favor, ingresa un monto total válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de antojitos (2:00 p.m. a 4:00 p.m., máximo 3 platillos)
            DateTime ahora = DateTime.Now;
            bool contieneAntojitos = dtgTuPedido.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[0]?.Value.ToString() == "Antojitos");
            int cantidadAntojitos = dtgTuPedido.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[0]?.Value.ToString() == "Antojitos")
                .Sum(row => Convert.ToInt32(row.Cells[1].Value));

            if (contieneAntojitos)
            {
                // Verificar horario de antojitos
                if (!(ahora.TimeOfDay >= new TimeSpan(14, 0, 0) && ahora.TimeOfDay <= new TimeSpan(16, 0, 0)))
                {
                    MessageBox.Show("Los antojitos solo pueden pedirse entre las 2:00 p.m. y las 4:00 p.m.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar cantidad máxima de antojitos
                if (cantidadAntojitos > 3)
                {
                    MessageBox.Show("No puedes pedir más de 3 antojitos por pedido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Continuar con la creación del pedido después de pasar las validaciones
            Clases.Pedido pedido = new Clases.Pedido
            {
                UsuarioID = Clases.Session.UserID,
                LocalID = int.Parse(cmbLocal.SelectedItem.ToString()),
                EventoID = int.Parse(eventoID.Value.ToString()),
                FechaHoraPedido = DateTime.Now,
                HoraReserva = dtReserva.Value.TimeOfDay,
                EstadoPedido = "Pendiente",
                TipoPedido = "Mesa",
                TotalPago = totalPago,
                TipoPago = cmbTipoPago.SelectedItem.ToString()
            };

            // Guardar el pedido y asignar el PedidoID
            Clases.Crud crud = new Clases.Crud();
            int resultado = crud.GuardarPedido(pedido);

            // Verificación de guardado
            if (resultado <= 0 || pedido.PedidoID == 0)
            {
                MessageBox.Show("Error al guardar el pedido.");
                return;
            }

            // Registrar el detalle del pedido
            foreach (DataGridViewRow row in dtgTuPedido.Rows)
            {
                if (row.Cells[0]?.Value != null && row.Cells[1]?.Value != null)
                {
                    string nombreProducto = row.Cells[0].Value.ToString();
                    int cantidad = Convert.ToInt32(row.Cells[1].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells[2].Value);
                    decimal subTotal = precioUnitario * cantidad;

                    // Obtener Producto_ID usando el diccionario
                    if (productoIDMap.TryGetValue(nombreProducto, out int productoID))
                    {
                        Clases.DetallePedido detalle = new Clases.DetallePedido
                        {
                            PedidoID = pedido.PedidoID,
                            ProductoID = productoID,
                            CantidadProducto = cantidad,
                            PrecioUnitario = precioUnitario,
                            SubTotal = subTotal
                        };

                        int resultadoDetalle = crud.RegistrarDetallePedido(detalle);

                        if (resultadoDetalle <= 0)
                        {
                            MessageBox.Show("Error al agregar el producto al detalle del pedido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Producto_ID no encontrado para " + nombreProducto);
                    }
                }
            }

            MessageBox.Show("Pedido guardado con éxito.");
        }


        private void dgvProductosDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la celda seleccionada no sea el encabezado
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvProductosDisponibles.Rows[e.RowIndex];

                // Obtener los valores de las celdas
                string nombreProducto = selectedRow.Cells[1].Value.ToString(); // Nombre_Producto está en la columna 1
                decimal precioUnitario = Convert.ToDecimal(selectedRow.Cells[3].Value); // PrecioUnitario está en la columna 2

                // Crear una nueva fila para dtgTuPedido
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dtgTuPedido);

                // Asignar los valores a las celdas de la nueva fila
                newRow.Cells[0].Value = nombreProducto; // Nombre_Producto
                newRow.Cells[1].Value = 1; // Inicialmente 1, se actualizará con el botón
                newRow.Cells[2].Value = precioUnitario; // PrecioUnitario
                newRow.Cells[3].Value = precioUnitario; // Inicialmente igual al precio unitario (Total)

                // Agregar la nueva fila a dtgTuPedido
                dtgTuPedido.Rows.Add(newRow);
            }
        }
        private void CalcularTotalGeneral()
        {
            decimal totalGeneral = 0;

            // Recorrer todas las filas de dtgTuPedido y sumar los valores de la columna Total
            foreach (DataGridViewRow row in dtgTuPedido.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    totalGeneral += Convert.ToDecimal(row.Cells[3].Value); // Total está en la columna 3
                }
            }

            // Actualizar txtTotal con el total general
            txtTotal.Text = totalGeneral.ToString("F2"); // Formato con dos decimales
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar que hay una fila seleccionada en dtgTuPedido
            if (dtgTuPedido.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dtgTuPedido.SelectedRows[0];

                // Obtener el valor de numCantidad
                int cantidad = (int)numCantidad.Value;

                // Asignar el valor de cantidad a la celda correspondiente
                selectedRow.Cells[1].Value = cantidad;

                // Obtener el valor de PrecioUnitario
                decimal precioUnitario = Convert.ToDecimal(selectedRow.Cells[2].Value);

                // Calcular el total
                decimal total = cantidad * precioUnitario;

                // Asignar el valor del total a la celda correspondiente
                selectedRow.Cells[3].Value = total;

                // Recalcular el total general y actualizar txtTotal
                CalcularTotalGeneral();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en la tabla 'Tu Pedido'.");
            }
        }
    }
}
