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
    public partial class FrmLocales : Form
    {
        public FrmLocales()
        {
            InitializeComponent();
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            Clases.Crud crud = new Clases.Crud();
            DataTable dt = crud.ObtenerLocales();
            dtgLocales.DataSource = dt;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validaciones de entradas
            if (Validaciones.EstaVacio(txtNombreLocal.Text) || Validaciones.EstaVacio(txtubicacion.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.SoloLetras(txtNombreLocal.Text))
            {
                MessageBox.Show("El nombre del local solo debe contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.SoloLetras(txtubicacion.Text))
            {
                MessageBox.Show("La ubicación del local solo debe contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todas las validaciones pasan, continúa con el registro del local
            Clases.Locales local = new Clases.Locales
            {
                NombreLocal1 = txtNombreLocal.Text,
                UbicacionLocal1 = txtubicacion.Text,
                Horario1 = timeLocal.Value.ToString("HH:mm:ss")
            };

            try
            {
                Clases.Control ctrl = new Clases.Control();
                string respuesta = ctrl.ctrlRegistroLocales(local);

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Local registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerDatos();  // Llamada al método para actualizar los datos después del registro
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
