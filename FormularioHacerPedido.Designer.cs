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
            this.dgvProductosDisponibles.Location = new System.Drawing.Point(22, 87);
            this.dgvProductosDisponibles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            this.dgvProductosDisponibles.ReadOnly = true;
            this.dgvProductosDisponibles.RowHeadersWidth = 82;
            this.dgvProductosDisponibles.RowTemplate.Height = 33;
            this.dgvProductosDisponibles.Size = new System.Drawing.Size(667, 94);
            this.dgvProductosDisponibles.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(84, 192);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dtgTuPedido.Location = new System.Drawing.Point(22, 224);
            this.dtgTuPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTuPedido.Name = "dtgTuPedido";
            this.dtgTuPedido.ReadOnly = true;
            this.dtgTuPedido.RowHeadersWidth = 82;
            this.dtgTuPedido.RowTemplate.Height = 33;
            this.dtgTuPedido.Size = new System.Drawing.Size(667, 118);
            this.dtgTuPedido.TabIndex = 7;
            // 
            // FormularioHacerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 408);
            this.Controls.Add(this.dtgTuPedido);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductosDisponibles);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormularioHacerPedido";
            this.Text = "Hacer Pedido";
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
    }
}