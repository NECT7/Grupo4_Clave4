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
    public partial class FrmEventos : Form
    {
        public FrmEventos()
        {
            InitializeComponent();
        }
        private void FrmEventos_Load(object sender, EventArgs e)
        {
            //txtID.Text = Clases.Session.UserID.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Validaciones de entradas
            if (Validaciones.EstaVacio(txtMontoMaximo.Text) ||
                Validaciones.EstaVacio(txtMontoMinimo.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.SoloNumeros(txtMontoMaximo.Text) || !Validaciones.SoloNumeros(txtMontoMinimo.Text))
            {
                MessageBox.Show("Los campos de monto máximo y monto mínimo deben contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.Parse(txtMontoMaximo.Text) <= 0 || double.Parse(txtMontoMinimo.Text) <= 0)
            {
                MessageBox.Show("Los montos deben ser mayores a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.Parse(txtMontoMaximo.Text) < double.Parse(txtMontoMinimo.Text))
            {
                MessageBox.Show("El monto máximo no puede ser menor que el monto mínimo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todas las validaciones pasan, continúa con el registro del evento
            eventos evento = new eventos
            {
                UsuarioID = Clases.Session.UserID,
                Fecha1 = dtpFechaEvento.Value,
                MontoMaximo1 = double.Parse(txtMontoMaximo.Text),
                MontoMinimo1 = double.Parse(txtMontoMinimo.Text),
                EstadoEvento1 = "Pagado"
            };

            try
            {
                Clases.Control ctrl = new Clases.Control();
                int eventoID = ctrl.ctrlRegistroEventos(evento);

                if (eventoID > 0)
                {
                    MessageBox.Show("Evento registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el formulario de pedidos y pasar el ID del evento
                    FormularioHacerPedido frmPedidos = new FormularioHacerPedido(eventoID);
                    frmPedidos.Show();
                }
                else
                {
                    MessageBox.Show("Error al registrar el evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
