namespace Grupo4_Clave4
{
    partial class FormularioInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Navy;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtUsuario.Location = new System.Drawing.Point(212, 287);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(380, 31);
            this.txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(198, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar Sesión";
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.Navy;
            this.btnInicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicioSesion.Location = new System.Drawing.Point(212, 658);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(6);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(384, 73);
            this.btnInicioSesion.TabIndex = 2;
            this.btnInicioSesion.Text = "Iniciar Sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(206, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(206, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Navy;
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtContraseña.Location = new System.Drawing.Point(212, 485);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(6);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(380, 31);
            this.txtContraseña.TabIndex = 5;
            // 
            // FormularioInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(788, 963);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormularioInicioSesion";
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}

