using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace Proyecto_SAPC
{
    public partial class Login : Form
    {
        //Quitar el botón de cerrar
        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        public static SQLServer sql = new SQLServer();
        public string usuario;
        public string tipo_usuario;

        string usuario_predeterminado = "admin", contrasena_predeterminada = "12345";
        string user, password;

        public Login()
        {
            InitializeComponent();
            this.Icon = Utilidades.Imagenes.ImagesResources.logo_siglas_sistema;
            Utilidades.Utilidades.ConfiguracionBotones(this);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            user = txtUsuario.Text;
            password = mtxtContrasena.Text;

            try
            {
                string respuesta = Utilidades.Controladores.Login.Ingreso(user, password);

                if (respuesta.Contains("id_usuario") == true ||
                    user.Equals(usuario_predeterminado, StringComparison.CurrentCultureIgnoreCase) &&
                    password.Equals(contrasena_predeterminada))
                {
                    TipoMenu(respuesta);
                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void TipoMenu(string datos)
        {
            Menu obj = new Menu();
            txtUsuario.Text = mtxtContrasena.Text = "";

            if (user.Equals(usuario_predeterminado, StringComparison.CurrentCultureIgnoreCase) &&
                password.Equals(contrasena_predeterminada))
            {
                usuario = usuario_predeterminado;
                tipo_usuario = "ADMINISTRADOR PREDETERMINADO";
                obj.Show();
                return;
            }
            else
            {
                int id_tipo_usuario = int.Parse(datos.Split('|')[2].Split(':')[1].Trim());
                this.Visible = false;
                usuario = datos.Split('|')[3].Split(':')[1].Trim();
                tipo_usuario = sql.EjecutarBD("SELECT tipo_usuario FROM TIPOS_USUARIOS WHERE id_tipo_usuario = " + id_tipo_usuario.ToString()).Tables[0].Rows[0]["tipo_usuario"].ToString().Trim();

                if (tipo_usuario.Contains("ADMIN"))
                {
                    obj.usuario = usuario;
                    obj.tipo_usuario = tipo_usuario;
                    obj.Show();
                    return;
                }
                else
                    if (tipo_usuario.Contains("REGULAR"))
                {
                    obj.ptsmenuitemPredicciones.Visible = false;
                    obj.tsmenuitemAjustes.Visible = false;
                    obj.Show();
                    return;
                }
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(mtxtContrasena.Text))
            {
                if (e.KeyCode == Keys.F5)
                    btnIngresar_Click(this, EventArgs.Empty);
                else
                    if (e.KeyCode == Keys.F11)
                        btnSalir_Click(this, EventArgs.Empty);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quiere salir?", "INTENTO DE SALIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (respuesta == DialogResult.No)
            {
                this.Focus();
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidades.ValidarInput(txtUsuario, e);
        }

        private void mtxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidades.ValidarInput(mtxtContrasena, e);
        }

        private void mtxtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(mtxtContrasena.Text))
                if (e.KeyCode == Keys.F5 || e.KeyCode == Keys.Enter)
                    btnIngresar_Click(this, EventArgs.Empty);
                else
                    if (e.KeyCode == Keys.F11)
                    btnSalir_Click(this, EventArgs.Empty);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(mtxtContrasena.Text))
                if (e.KeyCode == Keys.F5 || e.KeyCode == Keys.Enter)
                    btnIngresar_Click(this, EventArgs.Empty);
                else
                    if (e.KeyCode == Keys.F11)
                    btnSalir_Click(this, EventArgs.Empty);
        }
    }
}
