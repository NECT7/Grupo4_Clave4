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
    public partial class FrmRegistroUsuarios : Form
    {
        public FrmRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Clases.Usuario usuario = new Clases.Usuario();
            usuario.NombreUsuario1 = txtNombreUsuario.Text;
            usuario.EmailUsuario1 = txtCorreoUsuario.Text;
            usuario.TelefonoUsuario1 = txtNumTelefonoUsuario.Text;
            usuario.TipoUsuario1 = cmbTipoUsuario.SelectedItem?.ToString();
            usuario.ContraseñaUsuario1 = txtContraseñaUsuario.Text;

            try
            {
                Clases.Control ctrl = new Clases.Control();
                string respuesta = ctrl.crtRegistro(usuario);

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
