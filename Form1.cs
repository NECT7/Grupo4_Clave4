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
        private string connectionString = "Server=localhost;Database=clave4_grupo4db;Uid=root;Pwd=root;";
        public FormularioInicioSesion()
        {
            InitializeComponent();
        }
        private void AbrirMenuPorRol(string tipoUsuario)
        {
            if (tipoUsuario == "Estudiante")
            {
                FormularioEstudiante menuEstudiante = new FormularioEstudiante();
                menuEstudiante.Show();
            }
            else if (tipoUsuario == "Docente")
            {
                FormularioDocente menuDocente = new FormularioDocente();
                menuDocente.Show();
            }
            else if (tipoUsuario == "Administrativo")
            {
                FormularioAdministrativo menuAdministrativo = new FormularioAdministrativo();
                menuAdministrativo.Show();
            }
            this.Hide();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
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

    }
}
