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
    public partial class FrmAgregarProducto : Form
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

        private void btnGuardarPedido_Click(object sender, EventArgs e)
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

            Clases.Crud crud = new Clases.Crud();
            crud.GuardarPedido(pedido);

            MessageBox.Show("Pedido guardado con éxito.");
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
    }
}
