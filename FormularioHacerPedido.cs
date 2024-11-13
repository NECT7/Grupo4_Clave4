﻿using System;
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
    public partial class FormularioHacerPedido : Form
    {
        public FormularioHacerPedido()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            Clases.Crud crud = new Clases.Crud();
            DataTable dt = crud.ObtenerProductosDisponibles();
            dgvProductosDisponibles.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
