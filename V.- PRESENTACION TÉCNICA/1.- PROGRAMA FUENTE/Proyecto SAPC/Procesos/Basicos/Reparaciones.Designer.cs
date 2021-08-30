
namespace Proyecto_SAPC.Procesos.Basicos
{
    partial class Reparaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUsuario = new Utilidades.Herramientas.TextBox(this.components);
            this.lblEmpleado = new Utilidades.Herramientas.Label(this.components);
            this.txtNumeroReparacion = new Utilidades.Herramientas.TextBox(this.components);
            this.lblNumero = new Utilidades.Herramientas.Label(this.components);
            this.DGV_Fallos = new Utilidades.Herramientas.DataGridView(this.components);
            this.id_fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSuplidor = new System.Windows.Forms.Panel();
            this.txtEmail = new Utilidades.Herramientas.TextBox(this.components);
            this.txtTelefono = new Utilidades.Herramientas.TextBox(this.components);
            this.txtIdentificacion = new Utilidades.Herramientas.TextBox(this.components);
            this.label1 = new Utilidades.Herramientas.Label(this.components);
            this.label2 = new Utilidades.Herramientas.Label(this.components);
            this.btnBuscarSuplidor = new System.Windows.Forms.Button();
            this.btnAgregarSuplidor = new System.Windows.Forms.Button();
            this.label11 = new Utilidades.Herramientas.Label(this.components);
            this.rtxtDireccion = new System.Windows.Forms.RichTextBox();
            this.txtSuplidor = new Utilidades.Herramientas.TextBox(this.components);
            this.label8 = new Utilidades.Herramientas.Label(this.components);
            this.label3 = new Utilidades.Herramientas.Label(this.components);
            this.label4 = new Utilidades.Herramientas.Label(this.components);
            this.lblFecha = new Utilidades.Herramientas.Label(this.components);
            this.txtFecha = new Utilidades.Herramientas.TextBox(this.components);
            this.rtxtNota = new System.Windows.Forms.RichTextBox();
            this.label5 = new Utilidades.Herramientas.Label(this.components);
            this.txtBuscarFallo = new Utilidades.Herramientas.TextBox(this.components);
            this.label7 = new Utilidades.Herramientas.Label(this.components);
            this.pnlArticulo = new System.Windows.Forms.Panel();
            this.txtCategoria = new Utilidades.Herramientas.TextBox(this.components);
            this.label9 = new Utilidades.Herramientas.Label(this.components);
            this.picCodigoBarras = new System.Windows.Forms.PictureBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.lblImagen = new Utilidades.Herramientas.Label(this.components);
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.label12 = new Utilidades.Herramientas.Label(this.components);
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtArticulo = new Utilidades.Herramientas.TextBox(this.components);
            this.lblNombre = new Utilidades.Herramientas.Label(this.components);
            this.label15 = new Utilidades.Herramientas.Label(this.components);
            this.label10 = new Utilidades.Herramientas.Label(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fallos)).BeginInit();
            this.pnlSuplidor.SuspendLayout();
            this.pnlArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Location = new System.Drawing.Point(12, 562);
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
            // txtUsuario
            // 
            this.txtUsuario.CorreoValido = false;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(155, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(228, 26);
            this.txtUsuario.SoloAlfanumerico = false;
            this.txtUsuario.SoloLetras = false;
            this.txtUsuario.SoloNumeros = false;
            this.txtUsuario.TabIndex = 31;
            this.txtUsuario.Text = "1 | José Peguero";
            this.txtUsuario.Validar = false;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblEmpleado.Location = new System.Drawing.Point(12, 90);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(86, 15);
            this.lblEmpleado.TabIndex = 30;
            this.lblEmpleado.Text = "EMPLEADO:";
            // 
            // txtNumeroReparacion
            // 
            this.txtNumeroReparacion.BackColor = System.Drawing.Color.Yellow;
            this.txtNumeroReparacion.CorreoValido = false;
            this.txtNumeroReparacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroReparacion.Location = new System.Drawing.Point(155, 12);
            this.txtNumeroReparacion.Name = "txtNumeroReparacion";
            this.txtNumeroReparacion.ReadOnly = true;
            this.txtNumeroReparacion.Size = new System.Drawing.Size(228, 26);
            this.txtNumeroReparacion.SoloAlfanumerico = false;
            this.txtNumeroReparacion.SoloLetras = false;
            this.txtNumeroReparacion.SoloNumeros = false;
            this.txtNumeroReparacion.TabIndex = 10;
            this.txtNumeroReparacion.Validar = false;
            this.txtNumeroReparacion.TextChanged += new System.EventHandler(this.txtNumeroReparacion_TextChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblNumero.Location = new System.Drawing.Point(12, 18);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(70, 15);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "NÚMERO:";
            // 
            // DGV_Fallos
            // 
            this.DGV_Fallos.AllowUserToAddRows = false;
            this.DGV_Fallos.AllowUserToDeleteRows = false;
            this.DGV_Fallos.AllowUserToResizeColumns = false;
            this.DGV_Fallos.AllowUserToResizeRows = false;
            this.DGV_Fallos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Fallos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DGV_Fallos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Fallos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fallo,
            this.fallo});
            this.DGV_Fallos.Location = new System.Drawing.Point(15, 151);
            this.DGV_Fallos.MultiSelect = false;
            this.DGV_Fallos.Name = "DGV_Fallos";
            this.DGV_Fallos.RowHeadersVisible = false;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Fallos.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DGV_Fallos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Fallos.Size = new System.Drawing.Size(368, 235);
            this.DGV_Fallos.TabIndex = 2;
            this.DGV_Fallos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Fallos_CellValueChanged);
            this.DGV_Fallos.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DGV_Fallos_CellValueNeeded);
            this.DGV_Fallos.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DGV_Fallos_CellValuePushed);
            // 
            // id_fallo
            // 
            this.id_fallo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_fallo.DataPropertyName = "id_fallo";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.id_fallo.DefaultCellStyle = dataGridViewCellStyle22;
            this.id_fallo.HeaderText = "CÓDIGO";
            this.id_fallo.Name = "id_fallo";
            this.id_fallo.ReadOnly = true;
            this.id_fallo.Width = 91;
            // 
            // fallo
            // 
            this.fallo.DataPropertyName = "descripcion";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.fallo.DefaultCellStyle = dataGridViewCellStyle23;
            this.fallo.HeaderText = "FALLO";
            this.fallo.Name = "fallo";
            this.fallo.ReadOnly = true;
            // 
            // pnlSuplidor
            // 
            this.pnlSuplidor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlSuplidor.Controls.Add(this.txtEmail);
            this.pnlSuplidor.Controls.Add(this.txtTelefono);
            this.pnlSuplidor.Controls.Add(this.txtIdentificacion);
            this.pnlSuplidor.Controls.Add(this.label1);
            this.pnlSuplidor.Controls.Add(this.label2);
            this.pnlSuplidor.Controls.Add(this.btnBuscarSuplidor);
            this.pnlSuplidor.Controls.Add(this.btnAgregarSuplidor);
            this.pnlSuplidor.Controls.Add(this.label11);
            this.pnlSuplidor.Controls.Add(this.rtxtDireccion);
            this.pnlSuplidor.Controls.Add(this.txtSuplidor);
            this.pnlSuplidor.Controls.Add(this.label8);
            this.pnlSuplidor.Controls.Add(this.label3);
            this.pnlSuplidor.Controls.Add(this.label4);
            this.pnlSuplidor.Location = new System.Drawing.Point(400, 12);
            this.pnlSuplidor.Name = "pnlSuplidor";
            this.pnlSuplidor.Size = new System.Drawing.Size(790, 189);
            this.pnlSuplidor.TabIndex = 0;
            this.pnlSuplidor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSuplidor_Paint);
            // 
            // txtEmail
            // 
            this.txtEmail.CorreoValido = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(169, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(253, 26);
            this.txtEmail.SoloAlfanumerico = false;
            this.txtEmail.SoloLetras = false;
            this.txtEmail.SoloNumeros = false;
            this.txtEmail.TabIndex = 40;
            this.txtEmail.Validar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CorreoValido = false;
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(169, 107);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(253, 26);
            this.txtTelefono.SoloAlfanumerico = false;
            this.txtTelefono.SoloLetras = false;
            this.txtTelefono.SoloNumeros = false;
            this.txtTelefono.TabIndex = 39;
            this.txtTelefono.Validar = false;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.CorreoValido = false;
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(169, 71);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(253, 26);
            this.txtIdentificacion.SoloAlfanumerico = false;
            this.txtIdentificacion.SoloLetras = false;
            this.txtIdentificacion.SoloNumeros = false;
            this.txtIdentificacion.TabIndex = 38;
            this.txtIdentificacion.Validar = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DEL SUPLIDOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label2.Location = new System.Drawing.Point(447, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "DIRECCIÓN:";
            // 
            // btnBuscarSuplidor
            // 
            this.btnBuscarSuplidor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnBuscarSuplidor.Location = new System.Drawing.Point(645, 113);
            this.btnBuscarSuplidor.Name = "btnBuscarSuplidor";
            this.btnBuscarSuplidor.Size = new System.Drawing.Size(128, 59);
            this.btnBuscarSuplidor.TabIndex = 33;
            this.btnBuscarSuplidor.Text = "BUSCAR SUPLIDOR\r\nF7";
            this.btnBuscarSuplidor.UseVisualStyleBackColor = true;
            this.btnBuscarSuplidor.Click += new System.EventHandler(this.btnBuscarSuplidor_Click);
            // 
            // btnAgregarSuplidor
            // 
            this.btnAgregarSuplidor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnAgregarSuplidor.Location = new System.Drawing.Point(511, 113);
            this.btnAgregarSuplidor.Name = "btnAgregarSuplidor";
            this.btnAgregarSuplidor.Size = new System.Drawing.Size(128, 59);
            this.btnAgregarSuplidor.TabIndex = 32;
            this.btnAgregarSuplidor.Text = "CREAR SUPLIDOR\r\nF1";
            this.btnAgregarSuplidor.UseVisualStyleBackColor = true;
            this.btnAgregarSuplidor.Click += new System.EventHandler(this.btnNuevoSuplidor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label11.Location = new System.Drawing.Point(14, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "TELÉFONO:";
            // 
            // rtxtDireccion
            // 
            this.rtxtDireccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDireccion.Location = new System.Drawing.Point(574, 16);
            this.rtxtDireccion.Name = "rtxtDireccion";
            this.rtxtDireccion.ReadOnly = true;
            this.rtxtDireccion.Size = new System.Drawing.Size(199, 87);
            this.rtxtDireccion.TabIndex = 22;
            this.rtxtDireccion.Text = "";
            // 
            // txtSuplidor
            // 
            this.txtSuplidor.CorreoValido = false;
            this.txtSuplidor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuplidor.Location = new System.Drawing.Point(169, 35);
            this.txtSuplidor.Name = "txtSuplidor";
            this.txtSuplidor.ReadOnly = true;
            this.txtSuplidor.Size = new System.Drawing.Size(253, 26);
            this.txtSuplidor.SoloAlfanumerico = false;
            this.txtSuplidor.SoloLetras = false;
            this.txtSuplidor.SoloNumeros = false;
            this.txtSuplidor.TabIndex = 1;
            this.txtSuplidor.Validar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label8.Location = new System.Drawing.Point(14, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "SUPLIDOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label3.Location = new System.Drawing.Point(14, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "EMAIL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "IDENTIFICACIÓN:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 15);
            this.lblFecha.TabIndex = 161;
            this.lblFecha.Text = "FECHA:";
            // 
            // txtFecha
            // 
            this.txtFecha.CorreoValido = false;
            this.txtFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(155, 48);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(228, 26);
            this.txtFecha.SoloAlfanumerico = false;
            this.txtFecha.SoloLetras = false;
            this.txtFecha.SoloNumeros = false;
            this.txtFecha.TabIndex = 160;
            this.txtFecha.Validar = false;
            // 
            // rtxtNota
            // 
            this.rtxtNota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNota.Location = new System.Drawing.Point(66, 401);
            this.rtxtNota.Name = "rtxtNota";
            this.rtxtNota.Size = new System.Drawing.Size(317, 148);
            this.rtxtNota.TabIndex = 166;
            this.rtxtNota.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(641, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 167;
            this.label5.Text = "NOTA:";
            // 
            // txtBuscarFallo
            // 
            this.txtBuscarFallo.CorreoValido = false;
            this.txtBuscarFallo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFallo.Location = new System.Drawing.Point(155, 119);
            this.txtBuscarFallo.Name = "txtBuscarFallo";
            this.txtBuscarFallo.Size = new System.Drawing.Size(228, 26);
            this.txtBuscarFallo.SoloAlfanumerico = false;
            this.txtBuscarFallo.SoloLetras = false;
            this.txtBuscarFallo.SoloNumeros = false;
            this.txtBuscarFallo.TabIndex = 169;
            this.txtBuscarFallo.Validar = false;
            this.txtBuscarFallo.TextChanged += new System.EventHandler(this.txtBuscarFallo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 172;
            this.label7.Text = "BUSCAR:";
            // 
            // pnlArticulo
            // 
            this.pnlArticulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlArticulo.Controls.Add(this.txtCategoria);
            this.pnlArticulo.Controls.Add(this.label9);
            this.pnlArticulo.Controls.Add(this.picCodigoBarras);
            this.pnlArticulo.Controls.Add(this.btnBuscarArticulo);
            this.pnlArticulo.Controls.Add(this.lblImagen);
            this.pnlArticulo.Controls.Add(this.picImagen);
            this.pnlArticulo.Controls.Add(this.label12);
            this.pnlArticulo.Controls.Add(this.rtxtDescripcion);
            this.pnlArticulo.Controls.Add(this.txtArticulo);
            this.pnlArticulo.Controls.Add(this.lblNombre);
            this.pnlArticulo.Controls.Add(this.label15);
            this.pnlArticulo.Location = new System.Drawing.Point(400, 215);
            this.pnlArticulo.Name = "pnlArticulo";
            this.pnlArticulo.Size = new System.Drawing.Size(790, 334);
            this.pnlArticulo.TabIndex = 173;
            this.pnlArticulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlArticulo_Paint);
            // 
            // txtCategoria
            // 
            this.txtCategoria.CorreoValido = false;
            this.txtCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(169, 71);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(253, 26);
            this.txtCategoria.SoloAlfanumerico = false;
            this.txtCategoria.SoloLetras = false;
            this.txtCategoria.SoloNumeros = false;
            this.txtCategoria.TabIndex = 178;
            this.txtCategoria.Validar = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(422, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "DATOS DEL ARTÍCULO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCodigoBarras
            // 
            this.picCodigoBarras.BackColor = System.Drawing.Color.White;
            this.picCodigoBarras.Location = new System.Drawing.Point(520, 235);
            this.picCodigoBarras.Name = "picCodigoBarras";
            this.picCodigoBarras.Size = new System.Drawing.Size(253, 80);
            this.picCodigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCodigoBarras.TabIndex = 175;
            this.picCodigoBarras.TabStop = false;
            this.picCodigoBarras.Paint += new System.Windows.Forms.PaintEventHandler(this.picCodigoBarras_Paint);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnBuscarArticulo.Location = new System.Drawing.Point(17, 256);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(146, 59);
            this.btnBuscarArticulo.TabIndex = 33;
            this.btnBuscarArticulo.Text = "BUSCAR ARTÍCULO\r\nF9";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblImagen.Location = new System.Drawing.Point(447, 22);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(64, 15);
            this.lblImagen.TabIndex = 177;
            this.lblImagen.Text = "IMAGEN:";
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.White;
            this.picImagen.Location = new System.Drawing.Point(548, 22);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(200, 200);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 176;
            this.picImagen.TabStop = false;
            this.picImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.picImagen_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label12.Location = new System.Drawing.Point(14, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "DESCRIPCIÓN:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescripcion.Location = new System.Drawing.Point(169, 107);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.ReadOnly = true;
            this.rtxtDescripcion.Size = new System.Drawing.Size(253, 208);
            this.rtxtDescripcion.TabIndex = 22;
            this.rtxtDescripcion.Text = "";
            // 
            // txtArticulo
            // 
            this.txtArticulo.CorreoValido = false;
            this.txtArticulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.Location = new System.Drawing.Point(169, 35);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(253, 26);
            this.txtArticulo.SoloAlfanumerico = false;
            this.txtArticulo.SoloLetras = false;
            this.txtArticulo.SoloNumeros = false;
            this.txtArticulo.TabIndex = 1;
            this.txtArticulo.Validar = false;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblNombre.Location = new System.Drawing.Point(14, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 15);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label15.Location = new System.Drawing.Point(14, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "CATEGORÍA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label10.Location = new System.Drawing.Point(12, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 174;
            this.label10.Text = "NOTA:";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Reparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1200, 633);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlArticulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscarFallo);
            this.Controls.Add(this.rtxtNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtNumeroReparacion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.DGV_Fallos);
            this.Controls.Add(this.pnlSuplidor);
            this.KeyPreview = true;
            this.Name = "Reparaciones";
            this.Text = "REPARACIONES";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Reparaciones_KeyDown);
            this.Controls.SetChildIndex(this.pnlSuplidor, 0);
            this.Controls.SetChildIndex(this.DGV_Fallos, 0);
            this.Controls.SetChildIndex(this.lblNumero, 0);
            this.Controls.SetChildIndex(this.txtNumeroReparacion, 0);
            this.Controls.SetChildIndex(this.lblEmpleado, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.rtxtNota, 0);
            this.Controls.SetChildIndex(this.txtBuscarFallo, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.pnlArticulo, 0);
            this.Controls.SetChildIndex(this.pnlAcciones, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fallos)).EndInit();
            this.pnlSuplidor.ResumeLayout(false);
            this.pnlSuplidor.PerformLayout();
            this.pnlArticulo.ResumeLayout(false);
            this.pnlArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuplidor;
        private Utilidades.Herramientas.TextBox txtSuplidor;
        private Utilidades.Herramientas.Label label1;
        private Utilidades.Herramientas.DataGridView DGV_Fallos;
        private Utilidades.Herramientas.Label label8;
        private Utilidades.Herramientas.Label label3;
        private Utilidades.Herramientas.Label label4;
        private Utilidades.Herramientas.TextBox txtNumeroReparacion;
        private Utilidades.Herramientas.Label lblNumero;
        private System.Windows.Forms.Button btnBuscarSuplidor;
        private System.Windows.Forms.Button btnAgregarSuplidor;
        private Utilidades.Herramientas.Label label11;
        private System.Windows.Forms.RichTextBox rtxtDireccion;
        private Utilidades.Herramientas.TextBox txtUsuario;
        private Utilidades.Herramientas.Label lblEmpleado;
        private Utilidades.Herramientas.Label label2;
        private Utilidades.Herramientas.Label lblFecha;
        private Utilidades.Herramientas.TextBox txtFecha;
        private System.Windows.Forms.RichTextBox rtxtNota;
        private Utilidades.Herramientas.Label label5;
        private Utilidades.Herramientas.TextBox txtBuscarFallo;
        private Utilidades.Herramientas.Label label7;
        private System.Windows.Forms.Panel pnlArticulo;
        private Utilidades.Herramientas.Label label9;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private Utilidades.Herramientas.Label label12;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private Utilidades.Herramientas.TextBox txtArticulo;
        private Utilidades.Herramientas.Label lblNombre;
        private Utilidades.Herramientas.Label label15;
        public System.Windows.Forms.PictureBox picCodigoBarras;
        public Utilidades.Herramientas.Label lblImagen;
        public System.Windows.Forms.PictureBox picImagen;
        private Utilidades.Herramientas.Label label10;
        private System.Windows.Forms.Timer Timer;
        private Utilidades.Herramientas.TextBox txtEmail;
        private Utilidades.Herramientas.TextBox txtTelefono;
        private Utilidades.Herramientas.TextBox txtIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fallo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fallo;
        private Utilidades.Herramientas.TextBox txtCategoria;
    }
}