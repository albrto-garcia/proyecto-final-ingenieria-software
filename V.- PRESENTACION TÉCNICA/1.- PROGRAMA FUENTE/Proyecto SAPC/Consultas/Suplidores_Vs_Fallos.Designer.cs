
namespace Proyecto_SAPC.Consultas
{
    partial class Suplidores_Vs_Fallos
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
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.DGV = new Utilidades.Herramientas.DataGridView(this.components);
            this.id_fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscar = new Utilidades.Herramientas.Label(this.components);
            this.txtConsultar = new Utilidades.Herramientas.TextBox(this.components);
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Location = new System.Drawing.Point(12, 400);
            // 
            // btnGuardar
            // 
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
            this.DGV.AllowUserToResizeColumns = false;
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
            this.id_fallo,
            this.fallo});
            this.DGV.Location = new System.Drawing.Point(12, 51);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(563, 336);
            this.DGV.TabIndex = 35;
            // 
            // id_fallo
            // 
            this.id_fallo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_fallo.DataPropertyName = "id_fallo";
            this.id_fallo.HeaderText = "CÓDIGO";
            this.id_fallo.Name = "id_fallo";
            this.id_fallo.ReadOnly = true;
            this.id_fallo.Width = 86;
            // 
            // fallo
            // 
            this.fallo.DataPropertyName = "descripcion";
            this.fallo.HeaderText = "FALLO";
            this.fallo.Name = "fallo";
            this.fallo.ReadOnly = true;
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
            this.txtConsultar.Location = new System.Drawing.Point(85, 15);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(281, 26);
            this.txtConsultar.SoloAlfanumerico = false;
            this.txtConsultar.SoloLetras = false;
            this.txtConsultar.SoloNumeros = false;
            this.txtConsultar.TabIndex = 37;
            this.txtConsultar.Validar = false;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // Suplidores_Vs_Fallos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 471);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.DGV);
            this.Name = "Suplidores_Vs_Fallos";
            this.Text = "CONSULTA DE FALLOS QUE RESUELVE EL SUPLIDOR";
            this.Load += new System.EventHandler(this.Suplidores_Load);
            this.Controls.SetChildIndex(this.DGV, 0);
            this.Controls.SetChildIndex(this.txtConsultar, 0);
            this.Controls.SetChildIndex(this.lblBuscar, 0);
            this.Controls.SetChildIndex(this.pnlAcciones, 0);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        public Utilidades.Herramientas.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fallo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fallo;
        private Utilidades.Herramientas.Label lblBuscar;
        private Utilidades.Herramientas.TextBox txtConsultar;
    }
}