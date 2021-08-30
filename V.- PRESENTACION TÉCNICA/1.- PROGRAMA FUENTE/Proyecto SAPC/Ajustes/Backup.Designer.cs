
namespace Proyecto_SAPC.Ajustes
{
    partial class Backup
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new Utilidades.Herramientas.TextBox(this.components);
            this.lblNombre = new Utilidades.Herramientas.Label(this.components);
            this.txtRuta = new Utilidades.Herramientas.TextBox(this.components);
            this.lblRuta = new Utilidades.Herramientas.Label(this.components);
            this.btnRuta = new System.Windows.Forms.Button();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Location = new System.Drawing.Point(12, 91);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(270, 0);
            this.btnSeleccionar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(430, 0);
            this.btnModificar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(571, 0);
            this.btnEliminar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(697, 0);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(832, 0);
            // 
            // txtNombre
            // 
            this.txtNombre.CorreoValido = false;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(141, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 26);
            this.txtNombre.SoloAlfanumerico = true;
            this.txtNombre.SoloLetras = false;
            this.txtNombre.SoloNumeros = false;
            this.txtNombre.TabIndex = 80;
            this.txtNombre.Validar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 15);
            this.lblNombre.TabIndex = 198;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtRuta
            // 
            this.txtRuta.CorreoValido = false;
            this.txtRuta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(141, 53);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(442, 26);
            this.txtRuta.SoloAlfanumerico = false;
            this.txtRuta.SoloLetras = false;
            this.txtRuta.SoloNumeros = false;
            this.txtRuta.TabIndex = 193;
            this.txtRuta.Validar = false;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(12, 59);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(47, 15);
            this.lblRuta.TabIndex = 191;
            this.lblRuta.Text = "RUTA:";
            // 
            // btnRuta
            // 
            this.btnRuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnRuta.Location = new System.Drawing.Point(589, 51);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(33, 28);
            this.btnRuta.TabIndex = 200;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 162);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtNombre);
            this.Name = "Backup";
            this.Text = "BACKUP";
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblRuta, 0);
            this.Controls.SetChildIndex(this.txtRuta, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.btnRuta, 0);
            this.Controls.SetChildIndex(this.pnlAcciones, 0);
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Utilidades.Herramientas.TextBox txtNombre;
        private Utilidades.Herramientas.Label lblNombre;
        private Utilidades.Herramientas.TextBox txtRuta;
        private Utilidades.Herramientas.Label lblRuta;
        private System.Windows.Forms.Button btnRuta;
    }
}