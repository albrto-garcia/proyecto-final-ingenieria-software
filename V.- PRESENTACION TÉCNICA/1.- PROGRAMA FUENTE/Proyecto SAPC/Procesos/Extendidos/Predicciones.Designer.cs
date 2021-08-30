
namespace Proyecto_SAPC.Procesos.Extendidos
{
    partial class Predicciones
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Predicciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new Utilidades.Herramientas.Label(this.components);
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new Utilidades.Herramientas.Label(this.components);
            this.label1 = new Utilidades.Herramientas.Label(this.components);
            this.label2 = new Utilidades.Herramientas.Label(this.components);
            this.dtpFechaPrediccion = new System.Windows.Forms.DateTimePicker();
            this.txtReparacion = new Utilidades.Herramientas.TextBox(this.components);
            this.DGV_Fallos = new Utilidades.Herramientas.DataGridView(this.components);
            this.id_fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new Utilidades.Herramientas.TextBox(this.components);
            this.label3 = new Utilidades.Herramientas.Label(this.components);
            this.label4 = new Utilidades.Herramientas.Label(this.components);
            this.label10 = new Utilidades.Herramientas.Label(this.components);
            this.rtxtNota = new System.Windows.Forms.RichTextBox();
            this.txtArticulo = new Utilidades.Herramientas.TextBox(this.components);
            this.label5 = new Utilidades.Herramientas.Label(this.components);
            this.txtDiasPrediccion = new Utilidades.Herramientas.TextBox(this.components);
            this.txtUsuario = new Utilidades.Herramientas.TextBox(this.components);
            this.label6 = new Utilidades.Herramientas.Label(this.components);
            this.txtSuplidor = new Utilidades.Herramientas.TextBox(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new Utilidades.Herramientas.Label(this.components);
            this.picCodigoBarras = new System.Windows.Forms.PictureBox();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fallos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCodigoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Location = new System.Drawing.Point(12, 463);
            this.pnlAcciones.Size = new System.Drawing.Size(943, 59);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Text = "ESTIMAR\r\nF5";
            this.btnGuardar.Visible = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(270, 0);
            this.btnSeleccionar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(430, 0);
            this.btnModificar.Size = new System.Drawing.Size(150, 59);
            this.btnModificar.Text = "PREDICCIÓN\r\nF8";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(580, 0);
            this.btnEliminar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(706, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(841, 0);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblNombre.Location = new System.Drawing.Point(12, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "REPARACIÓN:";
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.White;
            this.picImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picImagen.ErrorImage")));
            this.picImagen.Image = ((System.Drawing.Image)(resources.GetObject("picImagen.Image")));
            this.picImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImagen.InitialImage")));
            this.picImagen.Location = new System.Drawing.Point(603, 172);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(256, 256);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 0;
            this.picImagen.TabStop = false;
            this.picImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.picArticulo_Paint);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(449, 384);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(129, 15);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "FECHA ESTIMADA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 77;
            this.label1.Text = "USUARIO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 147;
            this.label2.Text = "IMAGEN:";
            // 
            // dtpFechaPrediccion
            // 
            this.dtpFechaPrediccion.Checked = false;
            this.dtpFechaPrediccion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPrediccion.Enabled = false;
            this.dtpFechaPrediccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPrediccion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPrediccion.Location = new System.Drawing.Point(452, 402);
            this.dtpFechaPrediccion.Name = "dtpFechaPrediccion";
            this.dtpFechaPrediccion.Size = new System.Drawing.Size(126, 26);
            this.dtpFechaPrediccion.TabIndex = 148;
            this.dtpFechaPrediccion.Value = new System.DateTime(2021, 3, 29, 23, 43, 51, 0);
            this.dtpFechaPrediccion.ValueChanged += new System.EventHandler(this.dtpFechaPrediccion_ValueChanged);
            // 
            // txtReparacion
            // 
            this.txtReparacion.BackColor = System.Drawing.Color.Yellow;
            this.txtReparacion.CorreoValido = false;
            this.txtReparacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReparacion.Location = new System.Drawing.Point(210, 12);
            this.txtReparacion.Name = "txtReparacion";
            this.txtReparacion.Size = new System.Drawing.Size(368, 26);
            this.txtReparacion.SoloAlfanumerico = false;
            this.txtReparacion.SoloLetras = false;
            this.txtReparacion.SoloNumeros = false;
            this.txtReparacion.TabIndex = 174;
            this.txtReparacion.Validar = false;
            // 
            // DGV_Fallos
            // 
            this.DGV_Fallos.AllowUserToAddRows = false;
            this.DGV_Fallos.AllowUserToDeleteRows = false;
            this.DGV_Fallos.AllowUserToResizeColumns = false;
            this.DGV_Fallos.AllowUserToResizeRows = false;
            this.DGV_Fallos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Fallos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Fallos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Fallos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fallo,
            this.descripcion});
            this.DGV_Fallos.Location = new System.Drawing.Point(210, 123);
            this.DGV_Fallos.MultiSelect = false;
            this.DGV_Fallos.Name = "DGV_Fallos";
            this.DGV_Fallos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Fallos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Fallos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Fallos.Size = new System.Drawing.Size(368, 161);
            this.DGV_Fallos.TabIndex = 173;
            // 
            // id_fallo
            // 
            this.id_fallo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_fallo.DataPropertyName = "id_fallo";
            this.id_fallo.HeaderText = "CÓDIGO";
            this.id_fallo.Name = "id_fallo";
            this.id_fallo.ReadOnly = true;
            this.id_fallo.Width = 76;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "FALLO";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CorreoValido = false;
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(210, 91);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ReadOnly = true;
            this.txtBuscar.Size = new System.Drawing.Size(368, 26);
            this.txtBuscar.SoloAlfanumerico = false;
            this.txtBuscar.SoloLetras = false;
            this.txtBuscar.SoloNumeros = false;
            this.txtBuscar.TabIndex = 178;
            this.txtBuscar.Validar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 176;
            this.label3.Text = "FALLOS ENCONTRADOS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 175;
            this.label4.Text = "ARTÍCULO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label10.Location = new System.Drawing.Point(600, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 180;
            this.label10.Text = "NOTA:";
            // 
            // rtxtNota
            // 
            this.rtxtNota.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtNota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNota.Location = new System.Drawing.Point(603, 42);
            this.rtxtNota.Name = "rtxtNota";
            this.rtxtNota.ReadOnly = true;
            this.rtxtNota.Size = new System.Drawing.Size(256, 90);
            this.rtxtNota.TabIndex = 179;
            this.rtxtNota.Text = "";
            // 
            // txtArticulo
            // 
            this.txtArticulo.CorreoValido = false;
            this.txtArticulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.Location = new System.Drawing.Point(210, 52);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(368, 26);
            this.txtArticulo.SoloAlfanumerico = false;
            this.txtArticulo.SoloLetras = false;
            this.txtArticulo.SoloNumeros = false;
            this.txtArticulo.TabIndex = 181;
            this.txtArticulo.Validar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 183;
            this.label5.Text = "SUPLIDOR: ";
            // 
            // txtDiasPrediccion
            // 
            this.txtDiasPrediccion.CorreoValido = false;
            this.txtDiasPrediccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasPrediccion.Location = new System.Drawing.Point(239, 402);
            this.txtDiasPrediccion.Name = "txtDiasPrediccion";
            this.txtDiasPrediccion.ReadOnly = true;
            this.txtDiasPrediccion.Size = new System.Drawing.Size(125, 26);
            this.txtDiasPrediccion.SoloAlfanumerico = false;
            this.txtDiasPrediccion.SoloLetras = false;
            this.txtDiasPrediccion.SoloNumeros = false;
            this.txtDiasPrediccion.TabIndex = 184;
            this.txtDiasPrediccion.Validar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.CorreoValido = false;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(210, 338);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(368, 26);
            this.txtUsuario.SoloAlfanumerico = false;
            this.txtUsuario.SoloLetras = false;
            this.txtUsuario.SoloNumeros = false;
            this.txtUsuario.TabIndex = 185;
            this.txtUsuario.Validar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label6.Location = new System.Drawing.Point(236, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 187;
            this.label6.Text = "DÍAS ESTIMADOS: ";
            // 
            // txtSuplidor
            // 
            this.txtSuplidor.CorreoValido = false;
            this.txtSuplidor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuplidor.Location = new System.Drawing.Point(210, 298);
            this.txtSuplidor.Name = "txtSuplidor";
            this.txtSuplidor.ReadOnly = true;
            this.txtSuplidor.Size = new System.Drawing.Size(368, 26);
            this.txtSuplidor.SoloAlfanumerico = false;
            this.txtSuplidor.SoloLetras = false;
            this.txtSuplidor.SoloNumeros = false;
            this.txtSuplidor.TabIndex = 188;
            this.txtSuplidor.Validar = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = false;
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(15, 402);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(136, 26);
            this.dtpFecha.TabIndex = 190;
            this.dtpFecha.Value = new System.DateTime(2021, 3, 29, 23, 43, 51, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 15);
            this.label7.TabIndex = 189;
            this.label7.Text = "FECHA DE EMISIÓN:";
            // 
            // picCodigoBarras
            // 
            this.picCodigoBarras.BackColor = System.Drawing.Color.White;
            this.picCodigoBarras.Location = new System.Drawing.Point(603, 442);
            this.picCodigoBarras.Name = "picCodigoBarras";
            this.picCodigoBarras.Size = new System.Drawing.Size(256, 80);
            this.picCodigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCodigoBarras.TabIndex = 191;
            this.picCodigoBarras.TabStop = false;
            this.picCodigoBarras.Paint += new System.Windows.Forms.PaintEventHandler(this.picCodigoBarras_Paint);
            // 
            // Predicciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(871, 534);
            this.Controls.Add(this.picCodigoBarras);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSuplidor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtDiasPrediccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtxtNota);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReparacion);
            this.Controls.Add(this.DGV_Fallos);
            this.Controls.Add(this.dtpFechaPrediccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picImagen);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.Name = "Predicciones";
            this.Text = "PREDICCIÓN DE FECHA DE DISPONIBILIDAD DE UN ARTÍCULO";
            this.Controls.SetChildIndex(this.picImagen, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtpFechaPrediccion, 0);
            this.Controls.SetChildIndex(this.DGV_Fallos, 0);
            this.Controls.SetChildIndex(this.txtReparacion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.rtxtNota, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtArticulo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDiasPrediccion, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtSuplidor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dtpFecha, 0);
            this.Controls.SetChildIndex(this.pnlAcciones, 0);
            this.Controls.SetChildIndex(this.picCodigoBarras, 0);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fallos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCodigoBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagen;
        private Utilidades.Herramientas.Label lblNombre;
        private Utilidades.Herramientas.Label lblMensaje;
        private Utilidades.Herramientas.Label label1;
        private Utilidades.Herramientas.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaPrediccion;
        private Utilidades.Herramientas.TextBox txtReparacion;
        private Utilidades.Herramientas.DataGridView DGV_Fallos;
        private Utilidades.Herramientas.TextBox txtBuscar;
        private Utilidades.Herramientas.Label label3;
        private Utilidades.Herramientas.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fallo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private Utilidades.Herramientas.Label label10;
        private System.Windows.Forms.RichTextBox rtxtNota;
        private Utilidades.Herramientas.TextBox txtArticulo;
        private Utilidades.Herramientas.Label label5;
        private Utilidades.Herramientas.TextBox txtDiasPrediccion;
        private Utilidades.Herramientas.TextBox txtUsuario;
        private Utilidades.Herramientas.Label label6;
        private Utilidades.Herramientas.TextBox txtSuplidor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Utilidades.Herramientas.Label label7;
        public System.Windows.Forms.PictureBox picCodigoBarras;
    }
}
