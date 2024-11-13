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
            this.Proucto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEventoID = new System.Windows.Forms.TextBox();
            this.dtReserva = new System.Windows.Forms.DateTimePicker();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(168, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 78);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hacer Pedido";
            // 
            // dgvProductosDisponibles
            // 
            this.dgvProductosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosDisponibles.Location = new System.Drawing.Point(44, 150);
            this.dgvProductosDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            this.dgvProductosDisponibles.ReadOnly = true;
            this.dgvProductosDisponibles.RowHeadersWidth = 82;
            this.dgvProductosDisponibles.RowTemplate.Height = 33;
            this.dgvProductosDisponibles.Size = new System.Drawing.Size(1334, 198);
            this.dgvProductosDisponibles.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(164, 400);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(4);
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
            this.numCantidad.Size = new System.Drawing.Size(120, 31);
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
            this.dtgTuPedido.Location = new System.Drawing.Point(44, 475);
            this.dtgTuPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dtgTuPedido.Name = "dtgTuPedido";
            this.dtgTuPedido.ReadOnly = true;
            this.dtgTuPedido.RowHeadersWidth = 82;
            this.dtgTuPedido.RowTemplate.Height = 33;
            this.dtgTuPedido.Size = new System.Drawing.Size(1334, 227);
            this.dtgTuPedido.TabIndex = 7;
            // 
            // Proucto
            // 
            this.Proucto.HeaderText = "Prodcuto";
            this.Proucto.MinimumWidth = 10;
            this.Proucto.Name = "Proucto";
            this.Proucto.ReadOnly = true;
            this.Proucto.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 10;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.MinimumWidth = 10;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 200;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 10;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 200;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 717);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 44);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEventoID
            // 
            this.txtEventoID.Location = new System.Drawing.Point(820, 73);
            this.txtEventoID.Margin = new System.Windows.Forms.Padding(6);
            this.txtEventoID.Name = "txtEventoID";
            this.txtEventoID.Size = new System.Drawing.Size(196, 31);
            this.txtEventoID.TabIndex = 9;
            // 
            // dtReserva
            // 
            this.dtReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtReserva.Location = new System.Drawing.Point(1166, 402);
            this.dtReserva.Margin = new System.Windows.Forms.Padding(6);
            this.dtReserva.Name = "dtReserva";
            this.dtReserva.Size = new System.Drawing.Size(212, 31);
            this.dtReserva.TabIndex = 10;
            // 
            // cmbLocal
            // 
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(358, 398);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(231, 33);
            this.cmbLocal.TabIndex = 11;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(627, 398);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(245, 33);
            this.cmbTipoPago.TabIndex = 12;
            // 
            // cmbEvento
            // 
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(892, 399);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(245, 33);
            this.cmbEvento.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Local de venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(887, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Evento:";
            // 
            // FormularioHacerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 785);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.dtReserva);
            this.Controls.Add(this.txtEventoID);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgTuPedido);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductosDisponibles);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}