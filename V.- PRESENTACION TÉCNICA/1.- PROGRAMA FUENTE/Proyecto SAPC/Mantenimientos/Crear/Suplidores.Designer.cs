
namespace Proyecto_SAPC.Mantenimientos.Crear
{
    partial class Suplidores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdentificacion = new Utilidades.Herramientas.TextBox(this.components);
            this.lblTipoIdentificacion = new Utilidades.Herramientas.Label(this.components);
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.lblImagen = new Utilidades.Herramientas.Label(this.components);
            this.btnImagenPorDefecto = new System.Windows.Forms.Button();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnAgregarTipoIdentificacion = new System.Windows.Forms.Button();
            this.cbxTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.rtxtDireccion = new System.Windows.Forms.RichTextBox();
            this.lblCiudad = new Utilidades.Herramientas.Label(this.components);
            this.lblDireccion = new Utilidades.Herramientas.Label(this.components);
            this.txtNombre = new Utilidades.Herramientas.TextBox(this.components);
            this.lblIdentificacion = new Utilidades.Herramientas.Label(this.components);
            this.lblNombre = new Utilidades.Herramientas.Label(this.components);
            this.label1 = new Utilidades.Herramientas.Label(this.components);
            this.txtTelefono = new Utilidades.Herramientas.TextBox(this.components);
            this.txtEmail = new Utilidades.Herramientas.TextBox(this.components);
            this.lblEmail = new Utilidades.Herramientas.Label(this.components);
            this.label7 = new Utilidades.Herramientas.Label(this.components);
            this.txtBuscarFallo = new Utilidades.Herramientas.TextBox(this.components);
            this.DGV_Fallos = new Utilidades.Herramientas.DataGridView(this.components);
            this.id_fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fallos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Location = new System.Drawing.Point(12, 481);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(832, 0);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.CorreoValido = false;
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(187, 53);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(196, 26);
            this.txtIdentificacion.SoloAlfanumerico = false;
            this.txtIdentificacion.SoloLetras = false;
            this.txtIdentificacion.SoloNumeros = true;
            this.txtIdentificacion.TabIndex = 39;
            this.txtIdentificacion.Validar = false;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(12, 23);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(155, 15);
            this.lblTipoIdentificacion.TabIndex = 40;
            this.lblTipoIdentificacion.Text = "TIPO IDENTIFICACIÓN:";
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.White;
            this.picImagen.Location = new System.Drawing.Point(526, 125);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(256, 256);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 72;
            this.picImagen.TabStop = false;
            this.picImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.picImagen_Paint);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblImagen.Location = new System.Drawing.Point(479, 95);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(64, 15);
            this.lblImagen.TabIndex = 73;
            this.lblImagen.Text = "IMAGEN:";
            // 
            // btnImagenPorDefecto
            // 
            this.btnImagenPorDefecto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnImagenPorDefecto.Location = new System.Drawing.Point(668, 391);
            this.btnImagenPorDefecto.Name = "btnImagenPorDefecto";
            this.btnImagenPorDefecto.Size = new System.Drawing.Size(156, 59);
            this.btnImagenPorDefecto.TabIndex = 76;
            this.btnImagenPorDefecto.Text = "IMAGEN POR DEFECTO\r\nF2";
            this.btnImagenPorDefecto.UseVisualStyleBackColor = true;
            this.btnImagenPorDefecto.Click += new System.EventHandler(this.btnImagenPorDefecto_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnAgregarImagen.Location = new System.Drawing.Point(482, 391);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(180, 59);
            this.btnAgregarImagen.TabIndex = 75;
            this.btnAgregarImagen.Text = "AÑADIR IMAGEN\r\nF1";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnAgregarTipoIdentificacion
            // 
            this.btnAgregarTipoIdentificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarTipoIdentificacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarTipoIdentificacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipoIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoIdentificacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoIdentificacion.Location = new System.Drawing.Point(388, 17);
            this.btnAgregarTipoIdentificacion.Name = "btnAgregarTipoIdentificacion";
            this.btnAgregarTipoIdentificacion.Size = new System.Drawing.Size(27, 26);
            this.btnAgregarTipoIdentificacion.TabIndex = 223;
            this.btnAgregarTipoIdentificacion.UseVisualStyleBackColor = true;
            this.btnAgregarTipoIdentificacion.Click += new System.EventHandler(this.btnAgregarTipoIdentificacion_Click);
            // 
            // cbxTipoIdentificacion
            // 
            this.cbxTipoIdentificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoIdentificacion.FormattingEnabled = true;
            this.cbxTipoIdentificacion.Location = new System.Drawing.Point(187, 17);
            this.cbxTipoIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipoIdentificacion.Name = "cbxTipoIdentificacion";
            this.cbxTipoIdentificacion.Size = new System.Drawing.Size(196, 26);
            this.cbxTipoIdentificacion.TabIndex = 221;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbxEstado.Location = new System.Drawing.Point(187, 444);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(196, 26);
            this.cbxEstado.TabIndex = 204;
            // 
            // rtxtDireccion
            // 
            this.rtxtDireccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDireccion.Location = new System.Drawing.Point(187, 125);
            this.rtxtDireccion.Name = "rtxtDireccion";
            this.rtxtDireccion.Size = new System.Drawing.Size(196, 124);
            this.rtxtDireccion.TabIndex = 202;
            this.rtxtDireccion.Text = "";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblCiudad.Location = new System.Drawing.Point(12, 449);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(66, 15);
            this.lblCiudad.TabIndex = 201;
            this.lblCiudad.Text = "ESTADO:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblDireccion.Location = new System.Drawing.Point(12, 131);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 15);
            this.lblDireccion.TabIndex = 200;
            this.lblDireccion.Text = "DIRECCIÓN:";
            // 
            // txtNombre
            // 
            this.txtNombre.CorreoValido = false;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(187, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 26);
            this.txtNombre.SoloAlfanumerico = false;
            this.txtNombre.SoloLetras = true;
            this.txtNombre.SoloNumeros = false;
            this.txtNombre.TabIndex = 197;
            this.txtNombre.Validar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(12, 59);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(121, 15);
            this.lblIdentificacion.TabIndex = 194;
            this.lblIdentificacion.Text = "IDENTIFICACIÓN:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 15);
            this.lblNombre.TabIndex = 195;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.Location = new System.Drawing.Point(479, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 230;
            this.label1.Text = "TELÉFONO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CorreoValido = false;
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(628, 53);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 26);
            this.txtTelefono.SoloAlfanumerico = false;
            this.txtTelefono.SoloLetras = false;
            this.txtTelefono.SoloNumeros = true;
            this.txtTelefono.TabIndex = 228;
            this.txtTelefono.Validar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CorreoValido = true;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(628, 17);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 26);
            this.txtEmail.SoloAlfanumerico = false;
            this.txtEmail.SoloLetras = false;
            this.txtEmail.SoloNumeros = false;
            this.txtEmail.TabIndex = 227;
            this.txtEmail.Validar = false;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblEmail.Location = new System.Drawing.Point(479, 23);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 15);
            this.lblEmail.TabIndex = 226;
            this.lblEmail.Text = "EMAIL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 234;
            this.label7.Text = "BUSCAR:";
            // 
            // txtBuscarFallo
            // 
            this.txtBuscarFallo.CorreoValido = false;
            this.txtBuscarFallo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFallo.Location = new System.Drawing.Point(187, 261);
            this.txtBuscarFallo.Name = "txtBuscarFallo";
            this.txtBuscarFallo.Size = new System.Drawing.Size(196, 26);
            this.txtBuscarFallo.SoloAlfanumerico = true;
            this.txtBuscarFallo.SoloLetras = false;
            this.txtBuscarFallo.SoloNumeros = false;
            this.txtBuscarFallo.TabIndex = 233;
            this.txtBuscarFallo.Validar = false;
            this.txtBuscarFallo.TextChanged += new System.EventHandler(this.txtBuscarFallo_TextChanged);
            this.txtBuscarFallo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarFallo_KeyPress);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Fallos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Fallos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Fallos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fallo,
            this.descripcion});
            this.DGV_Fallos.Location = new System.Drawing.Point(15, 293);
            this.DGV_Fallos.MultiSelect = false;
            this.DGV_Fallos.Name = "DGV_Fallos";
            this.DGV_Fallos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Fallos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Fallos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Fallos.Size = new System.Drawing.Size(368, 137);
            this.DGV_Fallos.TabIndex = 232;
            this.DGV_Fallos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Fallos_CellValueChanged);
            this.DGV_Fallos.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DGV_Fallos_CellValueNeeded);
            this.DGV_Fallos.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DGV_Fallos_CellValuePushed);
            // 
            // id_fallo
            // 
            this.id_fallo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_fallo.DataPropertyName = "id_fallo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_fallo.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_fallo.HeaderText = "CÓDIGO";
            this.id_fallo.Name = "id_fallo";
            this.id_fallo.ReadOnly = true;
            this.id_fallo.Width = 91;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "FALLO";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscarFallo);
            this.Controls.Add(this.DGV_Fallos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnAgregarTipoIdentificacion);
            this.Controls.Add(this.cbxTipoIdentificacion);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.rtxtDireccion);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnImagenPorDefecto);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblTipoIdentificacion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Suplidores";
            this.Text = "MANTENIMIENTO DE SUPLIDORES";
            this.Load += new System.EventHandler(this.Suplidores_Load);
            this.Controls.SetChildIndex(this.lblTipoIdentificacion, 0);
            this.Controls.SetChildIndex(this.txtIdentificacion, 0);
            this.Controls.SetChildIndex(this.picImagen, 0);
            this.Controls.SetChildIndex(this.lblImagen, 0);
            this.Controls.SetChildIndex(this.btnAgregarImagen, 0);
            this.Controls.SetChildIndex(this.btnImagenPorDefecto, 0);
            this.Controls.SetChildIndex(this.pnlAcciones, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblIdentificacion, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.lblCiudad, 0);
            this.Controls.SetChildIndex(this.rtxtDireccion, 0);
            this.Controls.SetChildIndex(this.cbxEstado, 0);
            this.Controls.SetChildIndex(this.cbxTipoIdentificacion, 0);
            this.Controls.SetChildIndex(this.btnAgregarTipoIdentificacion, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.DGV_Fallos, 0);
            this.Controls.SetChildIndex(this.txtBuscarFallo, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fallos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Utilidades.Herramientas.TextBox txtIdentificacion;
        private Utilidades.Herramientas.Label lblTipoIdentificacion;
        private System.Windows.Forms.PictureBox picImagen;
        private Utilidades.Herramientas.Label lblImagen;
        private System.Windows.Forms.Button btnImagenPorDefecto;
        private System.Windows.Forms.Button btnAgregarImagen;
        public System.Windows.Forms.Button btnAgregarTipoIdentificacion;
        public System.Windows.Forms.ComboBox cbxTipoIdentificacion;
        public System.Windows.Forms.ComboBox cbxEstado;
        public System.Windows.Forms.RichTextBox rtxtDireccion;
        private Utilidades.Herramientas.Label lblCiudad;
        private Utilidades.Herramientas.Label lblDireccion;
        private Utilidades.Herramientas.TextBox txtNombre;
        private Utilidades.Herramientas.Label lblIdentificacion;
        private Utilidades.Herramientas.Label lblNombre;
        private Utilidades.Herramientas.Label label1;
        public Utilidades.Herramientas.TextBox txtTelefono;
        public Utilidades.Herramientas.TextBox txtEmail;
        private Utilidades.Herramientas.Label lblEmail;
        private Utilidades.Herramientas.Label label7;
        private Utilidades.Herramientas.TextBox txtBuscarFallo;
        private Utilidades.Herramientas.DataGridView DGV_Fallos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fallo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}