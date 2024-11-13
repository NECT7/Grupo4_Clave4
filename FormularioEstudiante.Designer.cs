using System.Windows.Forms;

namespace Grupo4_Clave4
{
    public partial class FormularioEstudiante : Form
    {
        /// <summary>
        /// Propiedad para almacenar el rol del usuario
        /// </summary>
        public string rolUsuario { get; set; }

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
            this.btnHacerPedido = new System.Windows.Forms.Button();
            this.btnConsultarPedidos = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHacerPedido
            // 
            this.btnHacerPedido.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerPedido.Location = new System.Drawing.Point(140, 51);
            this.btnHacerPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnHacerPedido.Name = "btnHacerPedido";
            this.btnHacerPedido.Size = new System.Drawing.Size(114, 40);
            this.btnHacerPedido.TabIndex = 3;
            this.btnHacerPedido.Text = "Hacer Pedido";
            this.btnHacerPedido.UseVisualStyleBackColor = true;
            this.btnHacerPedido.Click += new System.EventHandler(this.btnHacerPedido_Click);
            // 
            // btnConsultarPedidos
            // 
            this.btnConsultarPedidos.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPedidos.Location = new System.Drawing.Point(140, 123);
            this.btnConsultarPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Size = new System.Drawing.Size(114, 49);
            this.btnConsultarPedidos.TabIndex = 4;
            this.btnConsultarPedidos.Text = "Consultar Pedidos";
            this.btnConsultarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(140, 206);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(114, 40);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarUsuarios
            // 
            this.btnAdministrarUsuarios.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(140, 284);
            this.btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            this.btnAdministrarUsuarios.Size = new System.Drawing.Size(114, 47);
            this.btnAdministrarUsuarios.TabIndex = 6;
            this.btnAdministrarUsuarios.Text = "Administracion";
            this.btnAdministrarUsuarios.UseVisualStyleBackColor = true;
            this.btnAdministrarUsuarios.Click += new System.EventHandler(this.btnAdministrarUsuarios_Click);
            // 
            // FormularioEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 392);
            this.Controls.Add(this.btnAdministrarUsuarios);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnConsultarPedidos);
            this.Controls.Add(this.btnHacerPedido);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioEstudiante";
            this.Text = "Menú de Estudiantes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnHacerPedido;
        public System.Windows.Forms.Button btnConsultarPedidos;
        public System.Windows.Forms.Button btnCerrarSesion;
        public System.Windows.Forms.Button btnAdministrarUsuarios;
    }

}