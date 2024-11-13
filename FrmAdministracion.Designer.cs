
namespace Grupo4_Clave4
{
    partial class FrmAdministracion
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
            this.btmLocales = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmLocales
            // 
            this.btmLocales.Location = new System.Drawing.Point(124, 47);
            this.btmLocales.Name = "btmLocales";
            this.btmLocales.Size = new System.Drawing.Size(111, 35);
            this.btmLocales.TabIndex = 0;
            this.btmLocales.Text = "Administrar Locales";
            this.btmLocales.UseVisualStyleBackColor = true;
            this.btmLocales.Click += new System.EventHandler(this.btmLocales_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Administrar Productos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btmLocales);
            this.Name = "FrmAdministracion";
            this.Text = "FrmAdministracion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmLocales;
        private System.Windows.Forms.Button button1;
    }
}