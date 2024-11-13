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
    public partial class FormularioEstudiante : Form
    {
        public FormularioEstudiante()
        {
            InitializeComponent();
        }

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para hacer un pedido sin un eventoID inicial
            FormularioHacerPedido formularioHacerPedido = new FormularioHacerPedido();
            formularioHacerPedido.ShowDialog();
        }

        private void btnConsultarPedidos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para consultar pedidos
            //FormularioConsultarPedidos formularioConsultarPedidos = new FormularioConsultarPedidos();
            //formularioConsultarPedidos.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerrar este formulario y mostrar el formulario de inicio de sesión
            this.Close();
            FormularioInicioSesion formularioInicioSesion = new FormularioInicioSesion();
            formularioInicioSesion.Show();
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            FrmAdministracion admin = new FrmAdministracion();
            admin.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEventos evento = new FrmEventos();
            evento.Visible = true;
            this.Visible = false;
        }
    }
}
