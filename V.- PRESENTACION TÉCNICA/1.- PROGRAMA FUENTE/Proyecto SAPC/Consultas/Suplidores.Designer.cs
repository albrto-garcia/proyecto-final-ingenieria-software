
namespace Proyecto_SAPC.Consultas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new Utilidades.Herramientas.Label(this.components);
            this.cbxCampos = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new Utilidades.Herramientas.Label(this.components);
            this.txtConsultar = new Utilidades.Herramientas.TextBox(this.components);
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.DGV = new Utilidades.Herramientas.DataGridView(this.components);
            this.id_suplidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Location = new System.Drawing.Point(12, 471);
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
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(832, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnBuscar.Location = new System.Drawing.Point(455, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 62);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "BUSCAR\r\nF4";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblBusqueda.Location = new System.Drawing.Point(12, 57);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(118, 15);
            this.lblBusqueda.TabIndex = 40;
            this.lblBusqueda.Text = "BÚSQUEDA POR:";
            // 
            // cbxCampos
            // 
            this.cbxCampos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCampos.FormattingEnabled = true;
            this.cbxCampos.Items.AddRange(new object[] {
            "ID DEL ARTÍCULO",
            "NOMBRE",
            "DESCRIPCIÓN",
            "CATEGORÍA",
            "ALMACÉN"});
            this.cbxCampos.Location = new System.Drawing.Point(168, 51);
            this.cbxCampos.Name = "cbxCampos";
            this.cbxCampos.Size = new System.Drawing.Size(281, 26);
            this.cbxCampos.TabIndex = 39;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblBuscar.Location = new System.Drawing.Point(12, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(67, 15);
            this.lblBuscar.TabIndex = 38;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // txtConsultar
            // 
            this.txtConsultar.CorreoValido = false;
            this.txtConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultar.Location = new System.Drawing.Point(168, 15);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(281, 26);
            this.txtConsultar.SoloAlfanumerico = false;
            this.txtConsultar.SoloLetras = false;
            this.txtConsultar.SoloNumeros = false;
            this.txtConsultar.TabIndex = 37;
            this.txtConsultar.Validar = false;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnEliminarCliente.Location = new System.Drawing.Point(141, 0);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(141, 59);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "ELIMINAR CLIENTE\r\nF3";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnModificarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(141, 59);
            this.btnModificarCliente.TabIndex = 1;
            this.btnModificarCliente.Text = "MODIFICAR CLIENTE\r\nF2";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_suplidor,
            this.identificacion,
            this.nombre,
            this.imagen});
            this.DGV.Location = new System.Drawing.Point(12, 87);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 160;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(934, 369);
            this.DGV.TabIndex = 35;
            this.DGV.DoubleClick += new System.EventHandler(this.DGV_DoubleClick);
            // 
            // id_suplidor
            // 
            this.id_suplidor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_suplidor.DataPropertyName = "id_suplidor";
            this.id_suplidor.HeaderText = "CÓDIGO";
            this.id_suplidor.Name = "id_suplidor";
            this.id_suplidor.ReadOnly = true;
            this.id_suplidor.Width = 86;
            // 
            // identificacion
            // 
            this.identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.identificacion.DataPropertyName = "identificacion";
            this.identificacion.HeaderText = "INDENTIFICACIÓN";
            this.identificacion.Name = "identificacion";
            this.identificacion.ReadOnly = true;
            this.identificacion.Width = 152;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "IMAGEN";
            this.imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            this.imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 542);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.cbxCampos);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.DGV);
            this.Name = "Suplidores";
            this.Text = "CONSULTA DE SUPLIDORES";
            this.Load += new System.EventHandler(this.Suplidores_Load);
            this.Controls.SetChildIndex(this.DGV, 0);
            this.Controls.SetChildIndex(this.txtConsultar, 0);
            this.Controls.SetChildIndex(this.lblBuscar, 0);
            this.Controls.SetChildIndex(this.cbxCampos, 0);
            this.Controls.SetChildIndex(this.lblBusqueda, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.pnlAcciones, 0);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private Utilidades.Herramientas.Label lblBusqueda;
        private System.Windows.Forms.ComboBox cbxCampos;
        private Utilidades.Herramientas.Label lblBuscar;
        private Utilidades.Herramientas.TextBox txtConsultar;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        public Utilidades.Herramientas.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_suplidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
    }
}