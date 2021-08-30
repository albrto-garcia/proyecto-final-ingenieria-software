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
    public partial class Suplidores_Vs_Fallos : Utilidades.Herramientas.Form
    {
        public int id_suplidor;

        public Suplidores_Vs_Fallos()
        {
            InitializeComponent();
            ConfiguracionBotones();
            CargarFallos();
        }

        void CargarFallos()
        {
            DS = Busqueda(txtConsultar.Text.Trim());

            if (DS.Tables.Count > 0)
                DGV.DataSource = DS.Tables[0];
        }

        public DataSet Busqueda(string valor)
        {
            string comando = "EXEC BUSCAR_SUPLIDORES_VS_FALLOS " + id_suplidor + ", '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_SUPLIDORES_VS_FALLOS {0}, '{1}'", id_suplidor, valor);

            DS = sql.EjecutarBD(comando);

            return DS;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarFallos();
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

        private void Suplidores_Load(object sender, EventArgs e)
        {
            CargarFallos();
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            CargarFallos();
        }
    }
}
