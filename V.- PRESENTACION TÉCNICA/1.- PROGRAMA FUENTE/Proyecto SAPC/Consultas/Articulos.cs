using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SAPC.Consultas
{
    public partial class Articulos : Utilidades.Herramientas.Form
    {
        public Utilidades.Clases.Tablas.Articulos articulo;
        Utilidades.Modelos.Articulos modelo;
        MemoryStream ms;

        public Articulos()
        {
            InitializeComponent();
            ConfiguracionBotones();
            LLenarCbx();
            CargarArticulos();
        }

        public static DataSet Buscar(string valor, string buscar_por)
        {
            Utilidades.Modelos.Articulos modelo = new Utilidades.Modelos.Articulos();

            DS = modelo.Busqueda(valor, buscar_por);

            return DS;
        }

        void CargarArticulos()
        {
            DS = Buscar(txtConsultar.Text.Trim(), cbxCampos.SelectedValue.ToString());

            if (DS.Tables.Count > 0)
            {
                try
                {
                    DGV.Rows.Clear();

                    foreach (DataRow fila in DS.Tables[0].Rows)
                        DGV.Rows.Add(fila["id_articulo"].ToString(),
                                     fila["nombre"].ToString(),
                                     fila["categoria"].ToString(),
                                     fila["descripcion"].ToString().Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void ConfiguracionBotones()
        {
            ImageList img = new ImageList();
            img.ImageSize = new Size(44, 44);
            img.Images.Add(Utilidades.Imagenes.ImagesResources.seleccionar);
            img.Images.Add(Utilidades.Imagenes.ImagesResources.cancelar);
            img.Images.Add(Utilidades.Imagenes.ImagesResources.salir);
            img.Images.Add(Utilidades.Imagenes.ImagesResources.buscar);
            btnSeleccionar.ImageIndex = 0;
            btnCancelar.ImageIndex = 1;
            btnSalir.ImageIndex = 2;
            btnBuscar.ImageIndex = 3;

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

        private void Articulos_Load(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void LLenarCbx()
        {
            cbxCampos.DisplayMember = "Texto";
            cbxCampos.ValueMember = "Valor";

            var items = new[] {
                new { Texto = "CÓDIGO", Valor = "a.id_articulo" },
                new { Texto = "NOMBRE", Valor = "a.nombre" },
                new { Texto = "CATEGORÍA", Valor = "c.categoria" },
                new { Texto = "DESCRIPCIÓN", Valor = "a.descripcion" },
            };

            cbxCampos.DataSource = items;
            cbxCampos.SelectedIndex = 0;

            Utilidades.Utilidades.AjustarCbx(this);
        }
    }
}
