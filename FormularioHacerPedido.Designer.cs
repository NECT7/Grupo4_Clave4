namespace Grupo4_Clave4
{
    partial class FormularioHacerPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductosDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtgTuPedido = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEventoID = new System.Windows.Forms.TextBox();
            this.dtReserva = new System.Windows.Forms.DateTimePicker();
            this.Proucto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTuPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(84, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hacer Pedido";
            // 
            // dgvProductosDisponibles
            // 
            this.dgvProductosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosDisponibles.Location = new System.Drawing.Point(22, 78);
            this.dgvProductosDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            this.dgvProductosDisponibles.ReadOnly = true;
            this.dgvProductosDisponibles.RowHeadersWidth = 82;
            this.dgvProductosDisponibles.RowTemplate.Height = 33;
            this.dgvProductosDisponibles.Size = new System.Drawing.Size(667, 103);
            this.dgvProductosDisponibles.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(82, 208);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(60, 20);
            this.numCantidad.TabIndex = 6;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtgTuPedido
            // 
            this.dtgTuPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTuPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proucto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.dtgTuPedido.Location = new System.Drawing.Point(22, 247);
            this.dtgTuPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTuPedido.Name = "dtgTuPedido";
            this.dtgTuPedido.ReadOnly = true;
            this.dtgTuPedido.RowHeadersWidth = 82;
            this.dtgTuPedido.RowTemplate.Height = 33;
            this.dtgTuPedido.Size = new System.Drawing.Size(667, 118);
            this.dtgTuPedido.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 373);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEventoID
            // 
            this.txtEventoID.Location = new System.Drawing.Point(410, 38);
            this.txtEventoID.Name = "txtEventoID";
            this.txtEventoID.Size = new System.Drawing.Size(100, 20);
            this.txtEventoID.TabIndex = 9;
            // 
            // dtReserva
            // 
            this.dtReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtReserva.Location = new System.Drawing.Point(483, 204);
            this.dtReserva.Name = "dtReserva";
            this.dtReserva.Size = new System.Drawing.Size(108, 20);
            this.dtReserva.TabIndex = 10;
            // 
            // Proucto
            // 
            this.Proucto.HeaderText = "Prodcuto";
            this.Proucto.Name = "Proucto";
            this.Proucto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // FormularioHacerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 408);
            this.Controls.Add(this.dtReserva);
            this.Controls.Add(this.txtEventoID);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgTuPedido);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductosDisponibles);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioHacerPedido";
            this.Text = "Hacer Pedido";
            this.Load += new System.EventHandler(this.FormularioHacerPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTuPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductosDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.DataGridView dtgTuPedido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEventoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proucto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DateTimePicker dtReserva;
    }
}