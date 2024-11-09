namespace Grupo4_Clave4
{
    partial class FormularioEstudiante
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
            this.btnHacerPedido = new System.Windows.Forms.Button();
            this.btnConsultarPedidos = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(98, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 78);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menú de Estudiante";
            // 
            // btnHacerPedido
            // 
            this.btnHacerPedido.Location = new System.Drawing.Point(246, 170);
            this.btnHacerPedido.Name = "btnHacerPedido";
            this.btnHacerPedido.Size = new System.Drawing.Size(227, 77);
            this.btnHacerPedido.TabIndex = 3;
            this.btnHacerPedido.Text = "Hacer Pedido";
            this.btnHacerPedido.UseVisualStyleBackColor = true;
            this.btnHacerPedido.Click += new System.EventHandler(this.btnHacerPedido_Click);
            // 
            // btnConsultarPedidos
            // 
            this.btnConsultarPedidos.Location = new System.Drawing.Point(246, 279);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Size = new System.Drawing.Size(227, 77);
            this.btnConsultarPedidos.TabIndex = 4;
            this.btnConsultarPedidos.Text = "Consultar Pedidos";
            this.btnConsultarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(246, 387);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(227, 77);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // FormularioEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnConsultarPedidos);
            this.Controls.Add(this.btnHacerPedido);
            this.Controls.Add(this.label2);
            this.Name = "FormularioEstudiante";
            this.Text = "Menú de Estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHacerPedido;
        private System.Windows.Forms.Button btnConsultarPedidos;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}