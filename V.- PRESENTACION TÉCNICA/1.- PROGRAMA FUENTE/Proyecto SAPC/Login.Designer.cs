
namespace Proyecto_SAPC
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblContrasena = new Utilidades.Herramientas.Label(this.components);
            this.lblUsuario = new Utilidades.Herramientas.Label(this.components);
            this.mtxtContrasena = new Utilidades.Herramientas.MaskedTextBox(this.components);
            this.txtUsuario = new Utilidades.Herramientas.TextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(432, 125);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnSalir.Location = new System.Drawing.Point(219, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(201, 59);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR\r\nF11";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnIngresar.Location = new System.Drawing.Point(12, 188);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(201, 59);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "INGRESAR\r\nF5";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblContrasena.Location = new System.Drawing.Point(9, 152);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(130, 18);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "CONTRASEÑA:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblUsuario.Location = new System.Drawing.Point(9, 114);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // mtxtContrasena
            // 
            this.mtxtContrasena.CorreoValido = false;
            this.mtxtContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtContrasena.Location = new System.Drawing.Point(170, 149);
            this.mtxtContrasena.Name = "mtxtContrasena";
            this.mtxtContrasena.PasswordChar = '●';
            this.mtxtContrasena.ShortcutsEnabled = false;
            this.mtxtContrasena.Size = new System.Drawing.Size(250, 26);
            this.mtxtContrasena.SoloAlfanumerico = true;
            this.mtxtContrasena.SoloLetras = false;
            this.mtxtContrasena.SoloNumeros = false;
            this.mtxtContrasena.TabIndex = 1;
            this.mtxtContrasena.Validar = false;
            this.mtxtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtContrasena_KeyDown);
            this.mtxtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtContrasena_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.CorreoValido = false;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(170, 111);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(250, 26);
            this.txtUsuario.SoloAlfanumerico = true;
            this.txtUsuario.SoloLetras = false;
            this.txtUsuario.SoloNumeros = false;
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Validar = false;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 259);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.mtxtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO DE SESIÓN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilidades.Herramientas.TextBox txtUsuario;
        private Utilidades.Herramientas.MaskedTextBox mtxtContrasena;
        private Utilidades.Herramientas.Label lblUsuario;
        private Utilidades.Herramientas.Label lblContrasena;
        private System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnIngresar;
    }
}