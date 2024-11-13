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
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
        }

        private void btmLocales_Click(object sender, EventArgs e)
        {
            FrmLocales locales = new FrmLocales();
            locales.Visible = true;
            this.Visible = false;
        }
    }
}
