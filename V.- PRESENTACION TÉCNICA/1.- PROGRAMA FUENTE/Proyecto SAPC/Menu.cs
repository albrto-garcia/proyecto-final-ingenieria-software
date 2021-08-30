using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Imagenes;

namespace Proyecto_SAPC
{
    public partial class Menu : Form
    {
        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        SQLServer sql = new SQLServer();
        public static DataSet DS = new DataSet();
        public static int id_empleado;
        public string usuario;
        public string tipo_usuario;

        public Menu()
        {
            InitializeComponent();
            this.Icon = Utilidades.Imagenes.ImagesResources.logo_siglas_sistema;
        }

        void LoginActivo(int n)
        {
            Form form = Application.OpenForms["Login"];

            if (form != null)
                if (n == 0)
                    form.Close();
                else
                    form.Visible = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        private void tsmenuitemCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quiere cerrar el sistema?", "INTENTO DE CIERRE", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (respuesta == DialogResult.No)
            {
                respuesta = MessageBox.Show("¿Quiere cerrar la sesión?", "INTENTO DE CIERRE", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    this.Dispose();
                    LoginActivo(1);
                }
                else if (respuesta == DialogResult.No)
                {
                    this.Focus();
                }
            }
        }

        private void atsmenuitemBackup_Click(object sender, EventArgs e)
        {
            Utilidades.Utilidades.SoloUnForm(this, "Ajustes.Backup");
        }

        private void ptsmenuitemReparaciones_Click(object sender, EventArgs e)
        {
            Utilidades.Utilidades.SoloUnForm(this, "Procesos.Basicos.Reparaciones");
        }

        private void ptsmenuitemEstimaciones_Click(object sender, EventArgs e)
        {
            Utilidades.Utilidades.SoloUnForm(this, "Procesos.Extendidos.Predicciones");
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuario) && string.IsNullOrWhiteSpace(tipo_usuario))
            {
                tsslblUsuario.Text = "USUARIO: ADMIN";
                tsslblTipoUsuario.Text = "TIPO: ADMINISTRADOR";
            }
            else
            {
                tsslblUsuario.Text = "USUARIO: " + usuario.ToUpper();
                tsslblTipoUsuario.Text = "TIPO: " + tipo_usuario;
            }
        }
    }
}
