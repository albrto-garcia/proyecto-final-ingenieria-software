using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades.Herramientas
{
    public partial class Form : System.Windows.Forms.Form
    {
        public static DataSet DS = new DataSet();
        public static SQLServer sql = new SQLServer();

        //Para elegir la impresora principal
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDefaultPrinter(string Name);

        //Para no permitir que el botón de cerrar esté habilitado
        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        public Form()
        {
            InitializeComponent();

            this.Icon = Imagenes.ImagesResources.logo_siglas_sistema;
            this.BackColor = Color.LightSkyBlue;

            Utilidades.ConfiguracionBotones(this);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            pnlAcciones.Location = new Point(12, this.Bounds.Height - (pnlAcciones.Height - pnlAcciones.Padding.Bottom + pnlAcciones.Margin.Bottom + 48));
        }

        private void Form_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btnGuardar_Click(this, EventArgs.Empty);
            else
                if (e.KeyCode == Keys.F6)
                    btnGuardarImprimir_Click(this, EventArgs.Empty);
            else
                if (e.KeyCode == Keys.F7)
                    btnSeleccionar_Click(this, EventArgs.Empty);
            else
                if (e.KeyCode == Keys.F8)
                    btnModificar_Click(this, EventArgs.Empty);
            else
                if (e.KeyCode == Keys.F9)
                    btnEliminar_Click(this, EventArgs.Empty);
            else
                if (e.KeyCode == Keys.F10)
                    btnCancelar_Click(this, EventArgs.Empty);
            else
                if (e.KeyCode == Keys.F11)
                    btnSalir_Click(this, EventArgs.Empty);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Utilidades.Limpiar(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog PrintDialog = new PrintDialog();
            PrintDialog.ShowDialog();
            string impresora = PrintDialog.PrinterSettings.PrinterName;
            SetDefaultPrinter(impresora);
        }
    }
}
