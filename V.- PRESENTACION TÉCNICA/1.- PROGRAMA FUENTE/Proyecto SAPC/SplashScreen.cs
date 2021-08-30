using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SAPC
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.Icon = Utilidades.Imagenes.ImagesResources.logo_siglas_sistema;
            picSplashScreen.Image = Utilidades.Imagenes.ImagesResources.logo_completo_sistema;
            picSplashScreen.BackgroundImageLayout = ImageLayout.Zoom;
            tSplashScreen.Enabled = true;
        }

        private void tSplashScreen_Tick(object sender, EventArgs e)
        {
            pbSplashScreen.Increment(1);

            if(pbSplashScreen.Value == 100)
            {
                pbSplashScreen.Value = 0;
                tSplashScreen.Enabled = false;
                Login obj = new Login();
                this.Hide();
                obj.Show();
            }
        }

        private void SplashScreen_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.FromArgb(91, 195, 224/*49, 118, 125*/); 
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 5;
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }
    }
}
