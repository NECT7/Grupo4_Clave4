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
        private void AbrirMenuPorRol(string tipoUsuario)
        {
            FormularioEstudiante formularioEstudiante = new FormularioEstudiante();
            if (tipoUsuario == "Estudiante")
            {
                formularioEstudiante.btnHacerPedido.Visible = true;
                formularioEstudiante.btnConsultarPedidos.Visible = true;
                formularioEstudiante.btnCerrarSesion.Visible = true;
                formularioEstudiante.btnAdministrarUsuarios.Visible = false;
            }
            else if (tipoUsuario == "Docente")
            {
                formularioEstudiante.btnHacerPedido.Visible = true;
                formularioEstudiante.btnConsultarPedidos.Visible = true;
                formularioEstudiante.btnCerrarSesion.Visible = true;
                formularioEstudiante.btnAdministrarUsuarios.Visible = false;

            }
            else if (tipoUsuario == "Administrativo")
            {
                formularioEstudiante.btnHacerPedido.Visible = true;
                formularioEstudiante.btnConsultarPedidos.Visible = true;
                formularioEstudiante.btnCerrarSesion.Visible = true;
                formularioEstudiante.btnAdministrarUsuarios.Visible = true;

            }
            formularioEstudiante.Show();
            this.Hide();
        }


        private void btnInicioSesion_Click_1(object sender, EventArgs e)
        {
            Clases.CConexion objetoConexion = new Clases.CConexion();
            MySqlConnection connection = objetoConexion.EstablecerConexion();
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                using (connection)
                {
                    string query = "SELECT Tipo_Usuario FROM usuarios WHERE Nombre_Usuario = @nombre AND Contraseña_Usuario = @contraseña";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", txtUsuario.Text);
                    command.Parameters.AddWithValue("@contraseña", txtContraseña.Text);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string tipoUsuario = result.ToString();
                        AbrirMenuPorRol(tipoUsuario);
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo establecer la conexión con la base de datos.");
            }
        }
    }
}

       

