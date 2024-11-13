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
            Clases.Locales local = new Clases.Locales();

            local.NombreLocal1 = txtNombreLocal.Text;
            local.UbicacionLocal1 = txtubicacion.Text;
            local.Horario1 = timeLocal.Value.ToString("HH:mm:ss");
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
                    MessageBox.Show("registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
