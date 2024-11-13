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
            // Validaciones de entradas
            if (Validaciones.EstaVacio(txtNombreUsuario.Text) ||
                Validaciones.EstaVacio(txtCorreoUsuario.Text) ||
                Validaciones.EstaVacio(txtNumTelefonoUsuario.Text) ||
                Validaciones.EstaVacio(txtContraseñaUsuario.Text) ||
                !Validaciones.EstaSeleccionado(cmbTipoUsuario))
            {
                MessageBox.Show("Por favor, rellena todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.SoloLetras(txtNombreUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario solo debe contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.SoloNumeros(txtNumTelefonoUsuario.Text))
            {
                MessageBox.Show("El teléfono debe contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.ValidarEmail(txtCorreoUsuario.Text))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todas las validaciones pasan, continúa con el registro del usuario
            Clases.Usuario usuario = new Clases.Usuario
            {
                NombreUsuario1 = txtNombreUsuario.Text,
                EmailUsuario1 = txtCorreoUsuario.Text,
                TelefonoUsuario1 = txtNumTelefonoUsuario.Text,
                TipoUsuario1 = cmbTipoUsuario.SelectedItem?.ToString(),
                ContraseñaUsuario1 = txtContraseñaUsuario.Text
            };

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
