
namespace Grupo4_Clave4
{
    partial class FrmLocales
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreLocal = new System.Windows.Forms.TextBox();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLocal = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtgLocales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Local";
            // 
            // txtNombreLocal
            // 
            this.txtNombreLocal.Location = new System.Drawing.Point(207, 24);
            this.txtNombreLocal.Name = "txtNombreLocal";
            this.txtNombreLocal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLocal.TabIndex = 1;
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(207, 74);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(100, 20);
            this.txtubicacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horario";
            // 
            // timeLocal
            // 
            this.timeLocal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeLocal.Location = new System.Drawing.Point(198, 128);
            this.timeLocal.Name = "timeLocal";
            this.timeLocal.Size = new System.Drawing.Size(109, 20);
            this.timeLocal.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(108, 188);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtgLocales
            // 
            this.dtgLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLocales.Location = new System.Drawing.Point(44, 231);
            this.dtgLocales.Name = "dtgLocales";
            this.dtgLocales.Size = new System.Drawing.Size(400, 150);
            this.dtgLocales.TabIndex = 7;
            // 
            // FrmLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.dtgLocales);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.timeLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreLocal);
            this.Controls.Add(this.label1);
            this.Name = "FrmLocales";
            this.Text = "FrmLocales";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreLocal;
        private System.Windows.Forms.TextBox txtubicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeLocal;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dtgLocales;
    }
}