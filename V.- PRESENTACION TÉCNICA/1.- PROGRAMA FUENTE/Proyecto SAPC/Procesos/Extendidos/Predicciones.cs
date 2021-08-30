using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SAPC.Procesos.Extendidos
{
    public partial class Predicciones : Utilidades.Herramientas.Form
    {
        public DateTime fecha_emision, fecha_prediccion;

        public Predicciones()
        {
            InitializeComponent();
            ConfiguracionBotones();
        }

        private void ConfiguracionBotones()
        {
            ImageList img = new ImageList();
            img.ImageSize = new Size(44, 44);
            img.Images.Add(Utilidades.Imagenes.ImagesResources.prediccion);
            img.Images.Add(Utilidades.Imagenes.ImagesResources.cancelar);
            img.Images.Add(Utilidades.Imagenes.ImagesResources.salir);
            btnModificar.ImageIndex = 0;
            btnCancelar.ImageIndex = 1;
            btnSalir.ImageIndex = 2;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel)
                {
                    foreach (Panel pnl in this.Controls.OfType<Panel>())
                    {
                        foreach (Control pnl_ctrl in pnl.Controls)
                        {
                            if (pnl_ctrl is Button)
                            {
                                ((Button)pnl_ctrl).ImageAlign = ContentAlignment.MiddleRight;
                                ((Button)pnl_ctrl).TextImageRelation = TextImageRelation.ImageBeforeText;
                                ((Button)pnl_ctrl).TextAlign = ContentAlignment.MiddleCenter;
                                ((Button)pnl_ctrl).ImageList = img;
                            }
                        }
                    }
                }
                else if (ctrl is Button)
                {
                    ((Button)ctrl).ImageAlign = ContentAlignment.MiddleRight;
                    ((Button)ctrl).TextImageRelation = TextImageRelation.ImageBeforeText;
                    ((Button)ctrl).TextAlign = ContentAlignment.MiddleCenter;
                    ((Button)ctrl).ImageList = img;
                }
            }
        }

        public static DataSet Buscar(string valor, string buscar_por)
        {
            string comando = "EXEC BUSCAR_REPARACIONES '0', '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_REPARACIONES '{0}', '{1}'", valor, buscar_por);

            DS = sql.EjecutarBD(comando);

            return DS;
        }

        void CargarReparacion()
        {
            DS = Buscar(txtReparacion.Text, "r.id_reparacion");

            if (DS.Tables[0].Rows.Count > 0)
            {
                try
                {
                    dtpFecha.Enabled = dtpFechaPrediccion.Enabled = true;
                    txtBuscar.ReadOnly = false;
                    txtArticulo.Text = DS.Tables[0].Rows[0]["articulo"].ToString();
                    txtSuplidor.Text = DS.Tables[0].Rows[0]["suplidor"].ToString();
                    txtUsuario.Text = DS.Tables[0].Rows[0]["usuario"].ToString();
                    rtxtNota.Text = DS.Tables[0].Rows[0]["nota"].ToString();
                    txtDiasPrediccion.Text = DS.Tables[0].Rows[0]["dias_prediccion"].ToString();

                    fecha_emision = DateTime.Parse(DS.Tables[0].Rows[0]["fecha"].ToString());
                    fecha_prediccion = DateTime.Parse(DS.Tables[0].Rows[0]["fecha_prediccion"].ToString());

                    dtpFecha.MinDate = fecha_emision;
                    dtpFecha.MaxDate = fecha_prediccion;

                    dtpFechaPrediccion.MinDate = fecha_emision;
                    dtpFechaPrediccion.MaxDate = fecha_prediccion;

                    dtpFecha.Value = fecha_emision;
                    dtpFechaPrediccion.Value = fecha_prediccion;

                    picImagen.Image = Image.FromFile(@"" + Utilidades.Utilidades.ruta + @"Proyecto SAPC\Utilidades\Imagenes\" + DS.Tables[0].Rows[0]["imagen"].ToString().Split(new[] { ": " }, StringSplitOptions.None)[2]);
                    picCodigoBarras.Image = Image.FromFile(@"" + Utilidades.Utilidades.ruta + @"Proyecto SAPC\Utilidades\Imagenes\" + DS.Tables[0].Rows[0]["codigo_barras"].ToString().Split(new[] { ": " }, StringSplitOptions.None)[2]);

                    foreach (DataRow fila in DS.Tables[0].Rows)
                        DGV_Fallos.Rows.Add(fila["id_fallo"].ToString(), fila["descripcion"].ToString().Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("¡Esta reparación no existe!");
                if (dtpFecha.Enabled = true && dtpFechaPrediccion.Enabled == true) dtpFecha.Enabled = dtpFechaPrediccion.Enabled = false;
                txtBuscar.ReadOnly = true;
                btnCancelar.PerformClick();
            }
        }

        private void picArticulo_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Black;
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.picImagen.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxArticulos_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void txtId_reparacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarFallos();
        }

        void CargarFallos()
        {
            DS = Busqueda(txtBuscar.Text.Trim());

            if (DS.Tables.Count > 0)
            {
                DGV_Fallos.Rows.Clear();

                foreach (DataRow fila in DS.Tables[0].Rows)
                    DGV_Fallos.Rows.Add(fila["id_fallo"].ToString(), fila["descripcion"].ToString().Trim());
            }
        }

        public DataSet Busqueda(string valor)
        {
            string comando = "EXEC BUSCAR_DETALLES_REPARACIONES " + txtReparacion.Text + ", '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_DETALLES_REPARACIONES {0}, '{1}'", txtReparacion.Text, valor);

            DS = sql.EjecutarBD(comando);

            return DS;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DGV_Fallos.Rows.Clear();
            if (dtpFecha.Enabled = true && dtpFechaPrediccion.Enabled == true) dtpFecha.Enabled = dtpFechaPrediccion.Enabled = false;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (txtArticulo.Text != "")
                dtpFecha.Value = fecha_emision;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtReparacion.Text.Trim() != "")
                CargarReparacion();
        }

        private void picCodigoBarras_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Black;
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.picCodigoBarras.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void dtpFechaPrediccion_ValueChanged(object sender, EventArgs e)
        {
            if (txtArticulo.Text != "")
                dtpFechaPrediccion.Value = fecha_prediccion;
        }
    }
}
