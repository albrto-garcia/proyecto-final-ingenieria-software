
namespace Proyecto_SAPC.Mantenimientos
{
    partial class Imagenes
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
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.cbxOpciones = new System.Windows.Forms.ComboBox();
            this.lblDispositivos = new Utilidades.Herramientas.Label(this.components);
            this.txtRuta = new Utilidades.Herramientas.TextBox(this.components);
            this.lblRuta = new Utilidades.Herramientas.Label(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.lblOpciones = new Utilidades.Herramientas.Label(this.components);
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Location = new System.Drawing.Point(12, 209);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Visible = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(270, 0);
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(832, 0);
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(12, 75);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(258, 26);
            this.cbxDispositivos.TabIndex = 78;
            this.cbxDispositivos.SelectionChangeCommitted += new System.EventHandler(this.cbxDispositivos_SelectionChangeCommitted);
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.White;
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagen.Location = new System.Drawing.Point(430, 12);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(256, 256);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 76;
            this.picImagen.TabStop = false;
            this.picImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.picImagen_Paint);
            // 
            // cbxOpciones
            // 
            this.cbxOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOpciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cbxOpciones.FormattingEnabled = true;
            this.cbxOpciones.Items.AddRange(new object[] {
            "Importar Imagen",
            "Capturar imagen"});
            this.cbxOpciones.Location = new System.Drawing.Point(110, 12);
            this.cbxOpciones.Name = "cbxOpciones";
            this.cbxOpciones.Size = new System.Drawing.Size(258, 26);
            this.cbxOpciones.TabIndex = 80;
            this.cbxOpciones.SelectionChangeCommitted += new System.EventHandler(this.cbxOpciones_SelectionChangeCommitted);
            // 
            // lblDispositivos
            // 
            this.lblDispositivos.AutoSize = true;
            this.lblDispositivos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivos.Location = new System.Drawing.Point(9, 48);
            this.lblDispositivos.Name = "lblDispositivos";
            this.lblDispositivos.Size = new System.Drawing.Size(200, 15);
            this.lblDispositivos.TabIndex = 81;
            this.lblDispositivos.Text = "DISPOSITIVOS DISPONIBLES:";
            this.lblDispositivos.Visible = false;
            // 
            // txtRuta
            // 
            this.txtRuta.CorreoValido = false;
            this.txtRuta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(12, 75);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(356, 26);
            this.txtRuta.SoloAlfanumerico = false;
            this.txtRuta.SoloLetras = false;
            this.txtRuta.SoloNumeros = false;
            this.txtRuta.TabIndex = 82;
            this.txtRuta.Validar = false;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(9, 48);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(47, 15);
            this.lblRuta.TabIndex = 83;
            this.lblRuta.Text = "RUTA:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnBuscar.Location = new System.Drawing.Point(12, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 62);
            this.btnBuscar.TabIndex = 84;
            this.btnBuscar.Text = "BUSCAR\r\nF4";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnCapturar.Location = new System.Drawing.Point(12, 107);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(139, 62);
            this.btnCapturar.TabIndex = 85;
            this.btnCapturar.Text = "CAPTURAR\r\nF3";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(9, 18);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(82, 15);
            this.lblOpciones.TabIndex = 86;
            this.lblOpciones.Text = "OPCIONES:";
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 280);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblDispositivos);
            this.Controls.Add(this.cbxOpciones);
            this.Controls.Add(this.cbxDispositivos);
            this.Controls.Add(this.picImagen);
            this.Name = "Imagenes";
            this.Text = "IMAGENES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Imagenes_FormClosing);
            this.Controls.SetChildIndex(this.pnlAcciones, 0);
            this.Controls.SetChildIndex(this.picImagen, 0);
            this.Controls.SetChildIndex(this.cbxDispositivos, 0);
            this.Controls.SetChildIndex(this.cbxOpciones, 0);
            this.Controls.SetChildIndex(this.lblDispositivos, 0);
            this.Controls.SetChildIndex(this.txtRuta, 0);
            this.Controls.SetChildIndex(this.lblRuta, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnCapturar, 0);
            this.Controls.SetChildIndex(this.lblOpciones, 0);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.ComboBox cbxOpciones;
        private Utilidades.Herramientas.Label lblDispositivos;
        private Utilidades.Herramientas.TextBox txtRuta;
        private Utilidades.Herramientas.Label lblRuta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCapturar;
        private Utilidades.Herramientas.Label lblOpciones;
        public System.Windows.Forms.PictureBox picImagen;
    }
}