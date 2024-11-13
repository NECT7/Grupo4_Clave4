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
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dtgTuPedido.Rows)
            {
                if (row.Cells["PrecioUnitario"]?.Value != null)
                {
                    decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    total += precio * cantidad;
                }
            }
            return total;
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
            Clases.Pedido pedido = new Clases.Pedido
            {
                UsuarioID = Clases.Session.UserID,
                LocalID = (int)cmbLocal.SelectedValue,
                EventoID = cmbEvento.SelectedValue as int?,
                FechaHoraPedido = DateTime.Now,
                HoraReserva = dtReserva.Value.TimeOfDay,
                EstadoPedido = "Pendiente",
                TipoPedido = "Mesa",
                TotalPago = CalcularTotal(),
                TipoPago = cmbTipoPago.SelectedItem.ToString()
            };

            // Guardar el pedido y asignar el PedidoID
            Clases.Crud crud = new Clases.Crud();
            crud.GuardarPedido(pedido);  // Ahora esto asigna el PedidoID al objeto pedido

            // Verifica si el PedidoID fue asignado correctamente
            if (pedido.PedidoID == 0)
            {
                MessageBox.Show("Error al guardar el pedido.");
                return;
            }

            // Registrar el detalle del pedido
            foreach (DataGridViewRow row in dtgTuPedido.Rows)
            {
                if (row.Cells["ProductoID"]?.Value != null && row.Cells["Cantidad"]?.Value != null)
                {
                    int productoID = Convert.ToInt32(row.Cells["ProductoID"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    decimal subTotal = precioUnitario * cantidad;

                    Clases.DetallePedido detalle = new Clases.DetallePedido
                    {
                        PedidoID = pedido.PedidoID, // Ahora puedes usar el PedidoID correctamente
                        ProductoID = productoID,
                        CantidadProducto = cantidad,
                        PrecioUnitario = precioUnitario,
                        SubTotal = subTotal
                    };

                    int resultadoDetalle = crud.RegistrarDetallePedido(detalle);

                    if (resultadoDetalle > 0)
                    {
                        MessageBox.Show("Producto agregado al detalle del pedido con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el producto al detalle del pedido.");
                    }
                }
            }

            MessageBox.Show("Pedido guardado con éxito.");
        }

    }
}
