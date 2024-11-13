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

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEventos_Load(object sender, EventArgs e)
        {
            //txtID.Text = Clases.Session.UserID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventos evento = new eventos();
            evento.UsuarioID = Clases.Session.UserID;
            evento.Fecha1 = dtpFechaEvento.Value;
            evento.MontoMaximo1 = double.Parse(txtMontoMaximo.Text);
            evento.MontoMinimo1 = double.Parse(txtMontoMinimo.Text);
            evento.EstadoEvento1 = "Pagado";
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
