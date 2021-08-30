
namespace Proyecto_SAPC
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmenuitemProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.ptsmenuitemReparaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.ptsmenuitemPredicciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuitemAjustes = new System.Windows.Forms.ToolStripMenuItem();
            this.atsmenuitemBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuitemCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblUsuario = new System.Windows.Forms.StatusStrip();
            this.tsslblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblTipoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.lblUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuitemProcesos,
            this.tsmenuitemAjustes,
            this.tsmenuitemCerrar});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(803, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmenuitemProcesos
            // 
            this.tsmenuitemProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptsmenuitemReparaciones});
            this.tsmenuitemProcesos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.tsmenuitemProcesos.Name = "tsmenuitemProcesos";
            this.tsmenuitemProcesos.Size = new System.Drawing.Size(94, 20);
            this.tsmenuitemProcesos.Text = "PROCESOS";
            // 
            // ptsmenuitemReparaciones
            // 
            this.ptsmenuitemReparaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptsmenuitemPredicciones});
            this.ptsmenuitemReparaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptsmenuitemReparaciones.Name = "ptsmenuitemReparaciones";
            this.ptsmenuitemReparaciones.Size = new System.Drawing.Size(180, 22);
            this.ptsmenuitemReparaciones.Text = "REPARACIONES";
            this.ptsmenuitemReparaciones.Click += new System.EventHandler(this.ptsmenuitemReparaciones_Click);
            // 
            // ptsmenuitemPredicciones
            // 
            this.ptsmenuitemPredicciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptsmenuitemPredicciones.Name = "ptsmenuitemPredicciones";
            this.ptsmenuitemPredicciones.Size = new System.Drawing.Size(180, 22);
            this.ptsmenuitemPredicciones.Text = "PREDICCIONES";
            this.ptsmenuitemPredicciones.Click += new System.EventHandler(this.ptsmenuitemEstimaciones_Click);
            // 
            // tsmenuitemAjustes
            // 
            this.tsmenuitemAjustes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atsmenuitemBackup});
            this.tsmenuitemAjustes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.tsmenuitemAjustes.Name = "tsmenuitemAjustes";
            this.tsmenuitemAjustes.Size = new System.Drawing.Size(80, 20);
            this.tsmenuitemAjustes.Text = "AJUSTES";
            // 
            // atsmenuitemBackup
            // 
            this.atsmenuitemBackup.Font = new System.Drawing.Font("Arial", 9.75F);
            this.atsmenuitemBackup.Name = "atsmenuitemBackup";
            this.atsmenuitemBackup.Size = new System.Drawing.Size(180, 22);
            this.atsmenuitemBackup.Text = "BACKUP";
            this.atsmenuitemBackup.Click += new System.EventHandler(this.atsmenuitemBackup_Click);
            // 
            // tsmenuitemCerrar
            // 
            this.tsmenuitemCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.tsmenuitemCerrar.Name = "tsmenuitemCerrar";
            this.tsmenuitemCerrar.Size = new System.Drawing.Size(74, 20);
            this.tsmenuitemCerrar.Text = "CERRAR";
            this.tsmenuitemCerrar.Click += new System.EventHandler(this.tsmenuitemCerrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblUsuario,
            this.tsslblTipoUsuario});
            this.lblUsuario.Location = new System.Drawing.Point(0, 431);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(803, 22);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "statusStrip1";
            // 
            // tsslblUsuario
            // 
            this.tsslblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.tsslblUsuario.Name = "tsslblUsuario";
            this.tsslblUsuario.Size = new System.Drawing.Size(72, 17);
            this.tsslblUsuario.Text = "USUARIO:";
            // 
            // tsslblTipoUsuario
            // 
            this.tsslblTipoUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.tsslblTipoUsuario.Name = "tsslblTipoUsuario";
            this.tsslblTipoUsuario.Size = new System.Drawing.Size(42, 17);
            this.tsslblTipoUsuario.Text = "TIPO:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 453);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.lblUsuario.ResumeLayout(false);
            this.lblUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmenuitemCerrar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUsuario;
        public System.Windows.Forms.ToolStripMenuItem tsmenuitemProcesos;
        public System.Windows.Forms.ToolStripMenuItem tsmenuitemAjustes;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTipoUsuario;
        private System.Windows.Forms.ToolStripMenuItem ptsmenuitemReparaciones;
        private System.Windows.Forms.ToolStripMenuItem atsmenuitemBackup;
        public System.Windows.Forms.ToolStripMenuItem ptsmenuitemPredicciones;
    }
}