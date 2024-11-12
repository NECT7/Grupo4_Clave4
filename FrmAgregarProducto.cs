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
    public partial class FrmAgregarProducto : Form
    {
        public FrmAgregarProducto()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            Clases.Crud crud = new Clases.Crud();
            DataTable dt = crud.ObtenerProductos();
            dtgProductos.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clases.Productos productos = new Clases.Productos();
            productos.NombreProducto1 = txtNombreProducto.Text;
            productos.CantidadProducto1 = int.Parse(txtCantidaProducto.Text);
            productos.PrecioUnitarioProducto1 = double.Parse(txtPrecioProducto.Text);
            productos.TipoProduto1 = cmbTipoProducto.SelectedItem?.ToString();
            productos.HorarioDisponible1 = dtDisponibleProdcuto.Value.ToString("HH:mm:ss");
            try
            {
                Clases.Control ctrl = new Clases.Control();
                string respuesta = ctrl.ctrRegistroProducto(productos);

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
