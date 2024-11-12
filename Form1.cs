using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Grupo4_Clave4
{
    public partial class FormularioInicioSesion : Form
    {
        public FormularioInicioSesion()
        {
            InitializeComponent();
        }

        // Método para abrir el formulario de estudiante con opciones según el rol del usuario
        private void AbrirMenuPorRol(string tipoUsuario)
        {
            FormularioEstudiante formularioEstudiante = new FormularioEstudiante();

            // Asignar el rol directamente para futuras verificaciones si es necesario
            formularioEstudiante.rolUsuario = tipoUsuario;

            // Configurar visibilidad de botones basado en el rol
            formularioEstudiante.btnHacerPedido.Visible = true;
            formularioEstudiante.btnConsultarPedidos.Visible = true;
            formularioEstudiante.btnCerrarSesion.Visible = true;

            // Solo el rol 'Administrativo' puede ver el botón de administración
            formularioEstudiante.btnAdministrarUsuarios.Visible = (tipoUsuario == "Administrativo");

            formularioEstudiante.Show();
            this.Hide(); // Ocultar el formulario de inicio de sesión
        }

        // Evento para iniciar sesión y abrir el menú adecuado
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            
        }

        // Evento para abrir el formulario de registro de usuarios
        private void label4_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuarios frmRegistrar = new FrmRegistroUsuarios();
            frmRegistrar.Visible = true;
            this.Visible = false;
        }

        private void btnInicioSesion_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            try
            {
                Clases.Control ctrl = new Clases.Control();
                string respuesta = ctrl.ctrlLogin(usuario, contraseña);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta);
                }
                else
                {
                    Clases.Crud crud = new Clases.Crud();
                    Clases.Usuario datosUsuarios = crud.PorUsuario(usuario);

                    // Abrir el menú según el rol recuperado del usuario
                    AbrirMenuPorRol(datosUsuarios.TipoUsuario1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}



