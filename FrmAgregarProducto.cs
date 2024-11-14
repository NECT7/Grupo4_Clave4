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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones de entradas
            if (Validaciones.EstaVacio(txtNombreProducto.Text) ||
                Validaciones.EstaVacio(txtCantidaProducto.Text) ||
                Validaciones.EstaVacio(txtPrecioProducto.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.SoloLetras(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto solo debe contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.SoloNumeros(txtCantidaProducto.Text) || !Validaciones.SoloNumeros(txtPrecioProducto.Text))
            {
                MessageBox.Show("Los campos de cantidad y precio deben contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.EstaSeleccionado(cmbTipoProducto))
            {
                MessageBox.Show("Por favor, selecciona un tipo de producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todas las validaciones pasan, continúa con el registro del producto
            Clases.Productos productos = new Clases.Productos
            {
                NombreProducto1 = txtNombreProducto.Text,
                CantidadProducto1 = int.Parse(txtCantidaProducto.Text),
                PrecioUnitarioProducto1 = double.Parse(txtPrecioProducto.Text),
                TipoProduto1 = cmbTipoProducto.SelectedItem?.ToString(),
                HorarioDisponible1 = dtDisponibleProdcuto.Value.ToString("HH:mm:ss")
            };

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
