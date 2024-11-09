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
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            try
            {
                Clases.Control ctrl = new Clases.Control();
                string respuesta = ctrl.ctrlLogin(usuario, contraseña);
                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta);
                }
                else
                {
                    Clases.Crud crud = new Clases.Crud();
                    Clases.Usuario datosUsuarios = crud.PorUsuario(usuario);
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

       

