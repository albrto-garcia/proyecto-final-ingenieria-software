using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using BasselTech_CamCapture;

namespace Proyecto_SAPC.Mantenimientos
{
    public partial class Imagenes : Utilidades.Herramientas.Form
    {
        public FilterInfoCollection dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        //public VideoCaptureDevice frame = null;
        //public MemoryStream ms;
        //public byte[] imagenes;
        //public static string nombre;
        Camera cam;

        public Imagenes()
        {
            InitializeComponent();
            Utilidades.Utilidades.ConfiguracionBotones(this);
            cbxOpciones.SelectedIndex = 0;
            lblDispositivos.Visible = false;
            cbxDispositivos.Visible = false;
            btnCapturar.Visible = false;
            lblRuta.Visible = true;
            btnBuscar.Visible = true;
            txtRuta.Visible = true;
            picImagen.Image = Utilidades.Imagenes.ImagesResources.imagen_por_defecto;
            LlenarCbx();
            cam = new Camera(picImagen);
        }

        public void LlenarCbx()
        {
            for (int i = 0; i < dispositivos.Count; i++)
            {
                cbxDispositivos.Items.Add(dispositivos[i].Name.ToString());
            }

            cbxDispositivos.SelectedIndex = 0;
        }

        public void Iniciar()
        {
            try
            {
                cam.Start();
            }
            catch (Exception ex)
            {
                cam.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_file_dialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "BUSCAR IMAGEN",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtRuta.Text = open_file_dialog.FileName;
                    Image imagen = Image.FromFile(txtRuta.Text);
                    picImagen.Image = imagen;
                }
                catch (Exception) { }
            }
        }

        private void cbxDispositivos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cam.Stop();
            lblDispositivos.Visible = true;
            cbxDispositivos.Visible = true;
            btnCapturar.Text = "CAPTURAR\nF3";
            btnCapturar.Visible = true;
            lblRuta.Visible = false;
            btnBuscar.Visible = false;
            txtRuta.Visible = false;
            Iniciar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Image frame = cam.GetBitmap();
                Image watermarkImage = Imagen.Size(Imagen.Opacity(Utilidades.Imagenes.ImagesResources.logo_completo_sistema, (float)0.9), 512, 128);
                Graphics imageGraphics = Graphics.FromImage(frame);
                TextureBrush watermarkBrush = new TextureBrush(watermarkImage);
                int x = (frame.Width / 2 - watermarkImage.Width / 2);
                int y = (frame.Height / 1 - watermarkImage.Height / 1);
                watermarkBrush.TranslateTransform(x, y);
                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
                picImagen.Image = frame;
            }
            catch (Exception) { }
            cam.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Imagenes_FormClosing(object sender, FormClosingEventArgs e)
        {
            cam.Stop();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text.Contains("INICIAR"))
            {
                Iniciar();
                btnCapturar.Text = "CAPTURAR\nF3";
            }
            else
            {
                try
                {
                    Image frame = cam.GetBitmap();
                    Image watermarkImage = Imagen.Size(Imagen.Opacity(Utilidades.Imagenes.ImagesResources.logo_completo_sistema, (float)0.9), 512, 128);
                    Graphics imageGraphics = Graphics.FromImage(frame);
                    TextureBrush watermarkBrush = new TextureBrush(watermarkImage);
                    int x = (frame.Width / 2 - watermarkImage.Width / 2);
                    int y = (frame.Height / 1 - watermarkImage.Height / 1);
                    watermarkBrush.TranslateTransform(x, y);
                    imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
                    picImagen.Image = frame;
                }
                catch (Exception) { }

                cam.Stop();
                btnCapturar.Text = "INICIAR\nF2";
            }
        }

        public void cbxOpciones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxOpciones.SelectedItem.ToString().Contains("Capturar"))
            {
                lblDispositivos.Visible = true;
                cbxDispositivos.Visible = true;
                btnCapturar.Text = "CAPTURAR\nF3";
                btnCapturar.Visible = true;
                lblRuta.Visible = false;
                btnBuscar.Visible = false;
                txtRuta.Visible = false;
                Iniciar();
            }
            else if (cbxOpciones.SelectedItem.ToString().Contains("Importar"))
            {
                cam.Stop();
                lblDispositivos.Visible = false;
                cbxDispositivos.Visible = false;
                btnCapturar.Visible = false;
                lblRuta.Visible = true;
                btnBuscar.Visible = true;
                txtRuta.Text = "";
                txtRuta.Visible = true;
                picImagen.Image = Utilidades.Imagenes.ImagesResources.imagen_por_defecto;
            }
        }

        private void picImagen_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Black;
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.picImagen.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cam.Stop();
            cbxOpciones.SelectedIndex = 0;
            lblDispositivos.Visible = false;
            cbxDispositivos.Visible = false;
            btnCapturar.Visible = false;
            lblRuta.Visible = true;
            btnBuscar.Visible = true;
            txtRuta.Visible = true;
            picImagen.Image = Utilidades.Imagenes.ImagesResources.imagen_por_defecto;
            txtRuta.Clear();
        }
    }

    public static class Imagen
    {
        public static Bitmap Size(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static Image Opacity(this Image image, float opacity)
        {
            var colorMatrix = new ColorMatrix();
            colorMatrix.Matrix33 = opacity;
            var imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            var output = new Bitmap(image.Width, image.Height);
            using (var gfx = Graphics.FromImage(output))
            {
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.DrawImage(
                    image,
                    new Rectangle(0, 0, image.Width, image.Height),
                    0,
                    0,
                    image.Width,
                    image.Height,
                    GraphicsUnit.Pixel,
                    imageAttributes);
            }

            return output;
        }
    }
}
