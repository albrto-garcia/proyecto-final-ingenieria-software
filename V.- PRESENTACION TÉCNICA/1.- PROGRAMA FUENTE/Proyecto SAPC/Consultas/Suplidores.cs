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
    public partial class Suplidores : Utilidades.Herramientas.Form
    {
        public List<int> lista_detalles_reparaciones;

        public Suplidores()
        {
            InitializeComponent();
            ConfiguracionBotones();
            LLenarCbx();
        }

        public static DataSet Buscar(string valor, string buscar_por)
        {
            Utilidades.Modelos.Suplidores modelo = new Utilidades.Modelos.Suplidores();

            DS = modelo.Busqueda(valor, buscar_por);

            return DS;
        }

        public void LLenarCbx()
        {
            cbxCampos.DisplayMember = "Texto";
            cbxCampos.ValueMember = "Valor";

            var items = new[] {
                new { Texto = "CÓDIGO", Valor = "id_suplidor" },
                new { Texto = "IDENTIFICACION", Valor = "identificacion" },
                new { Texto = "NOMBRE", Valor = "nombre" },
            };

            cbxCampos.DataSource = items;
            cbxCampos.SelectedIndex = 0;
        }

        public DataSet Busqueda(string valor, string id_suplidor)
        {
            string comando = "EXEC BUSCAR_SUPLIDORES_VS_FALLOS " + id_suplidor + ", '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_SUPLIDORES_VS_FALLOS {0}, '{1}'", id_suplidor, valor);

            DS = sql.EjecutarBD(comando);

            return DS;
        }

        void CargarSuplidores()
        {
            DS = Buscar(txtConsultar.Text.Trim(), cbxCampos.SelectedValue.ToString());

            if (DS.Tables.Count > 0)
            {
                try
                {
                    foreach (DataRow fila in DS.Tables[0].Rows)
                    {
                        foreach (int id_fallo in lista_detalles_reparaciones)
                        {
                            DS = Busqueda(id_fallo.ToString(), fila["id_suplidor"].ToString());

                            if (DS != null && DS.Tables[0].Rows.Count > 0)
                            {
                                DS = Buscar(fila["id_suplidor"].ToString(), "id_suplidor");

                                DGV.Rows.Add(fila["id_suplidor"], fila["identificacion"],
                                             fila["nombre"], fila["imagen"]);
                                break;
                            }
                        }
                    }

                    foreach (DataGridViewRow row in DGV.Rows)
                    {
                        string name = row.Cells[3].Value.ToString().Split(new[] { ": " }, StringSplitOptions.None)[2];
                        string fullName = @"" + Utilidades.Utilidades.ruta + @"Proyecto SAPC\Utilidades\Imagenes\" + name;
                        ((DataGridViewImageCell)row.Cells["imagen"]).Value = GetPhoto(fullName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarSuplidores();
        }

        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();

            return photo;
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

        private void Suplidores_Load(object sender, EventArgs e)
        {
            CargarSuplidores();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
            if (!Utilidades.Utilidades.FormAbierto("Proyecto_SAPC.Consultas.Suplidores_Vs_Fallos"))
            {
                if (DGV.Rows.Count > 0)
                {
                    Consultas.Suplidores_Vs_Fallos obj = new Consultas.Suplidores_Vs_Fallos();
                    obj.id_suplidor = int.Parse(DGV.SelectedRows[0].Cells["id_suplidor"].Value.ToString());

                    if (obj.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
            }
            else
            {
                Utilidades.Utilidades.Form("Proyecto_SAPC.Consultas.Suplidores_Vs_Fallos").BringToFront();
            }
        }
    }
}
