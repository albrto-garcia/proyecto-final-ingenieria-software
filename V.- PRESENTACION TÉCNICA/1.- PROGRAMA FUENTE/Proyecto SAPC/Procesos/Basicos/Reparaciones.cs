using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Utilidades;
using ZXing;

namespace Proyecto_SAPC.Procesos.Basicos
{
    public partial class Reparaciones : Utilidades.Herramientas.Form
    {
        public static string num_renta;
        public static int id_cliente;
        public bool ocupado;
        public string empleado;
        private System.Collections.Generic.Dictionary<int, bool> checkFallosState, checkArreglosState;
        Utilidades.Clases.Tablas.Detalles_Reparaciones detalles_reparaciones;
        List<int> lista_detalles_reparaciones;
        DateTime fecha;

        public Reparaciones()
        {
            InitializeComponent();

            DGV_Fallos.AutoGenerateColumns = false;
            CargarFallos();
            Utilidades.Utilidades.ConfiguracionBotones(this);
            this.picImagen.Image = Utilidades.Imagenes.ImagesResources.imagen_por_defecto;

            // The check box column will be virtual.
            DGV_Fallos.VirtualMode = true;
            DGV_Fallos.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            DGV_Fallos.Columns[0].Width = 30;

            // Initialize the dictionary that contains the boolean check state.
            checkFallosState = new Dictionary<int, bool>();
            checkArreglosState = new Dictionary<int, bool>();

            txtNumeroReparacion.Text = Utilidades.Utilidades.NumeroFactura("id_reparacion", "REPARACIONES").ToString();
            empleado = txtUsuario.Text;

            pnlAcciones.Width = 800;

            txtFecha.Text = sql.FechaBD();
            Timer.Enabled = true;
        }

        void CargarFallos()
        {
            Utilidades.Modelos.Fallos modelo = new Utilidades.Modelos.Fallos();

            DS = modelo.Busqueda(txtBuscarFallo.Text.Trim());

            if (DS.Tables.Count > 0)
                DGV_Fallos.DataSource = DS.Tables[0];
        }

        private void pnlSuplidor_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Black;
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.pnlSuplidor.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void picImagen_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Black;
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.picImagen.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void Reparaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnNuevoSuplidor_Click(this, EventArgs.Empty);
            else
               if (e.KeyCode == Keys.F7)
                btnBuscarSuplidor_Click(this, EventArgs.Empty);
            else
                if (e.KeyCode == Keys.F9)
                btnBuscarArticulo_Click(this, EventArgs.Empty);
            else
                if (e.KeyCode == Keys.F5)
                btnGuardar_Click(this, EventArgs.Empty);
        }

        private void btnNuevoSuplidor_Click(object sender, EventArgs e)
        {
            Mantenimientos.Crear.Suplidores obj = new Mantenimientos.Crear.Suplidores();
            Form menu = Utilidades.Utilidades.MDIParentMenu();
            if (menu != null)
                obj.MdiParent = menu;
            obj.TopMost = true;
            obj.Visible = true;
        }

        private void btnBuscarSuplidor_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Utilidades.FormAbierto("Proyecto_SAPC.Consultas.Suplidores"))
            {
                try
                {
                    lista_detalles_reparaciones = new List<int>();
                    detalles_reparaciones = new Utilidades.Clases.Tablas.Detalles_Reparaciones();

                    var checkRows = from DataGridViewRow r in DGV_Fallos.Rows
                                    where Convert.ToBoolean(r.Cells[0].Value) == true
                                    select r;

                    if (checkRows.Count() > 0)
                    {
                        foreach (var row in checkRows)
                        {
                            string comando = "EXEC BUSCAR_SUPLIDORES_VS_FALLOS " + 0 + ", '0'";
                            string valor = row.Cells[1].Value.ToString();

                            if (!String.IsNullOrEmpty(valor))
                                comando = String.Format("EXEC BUSCAR_SUPLIDORES_VS_FALLOS {0}, '{1}'", 0, valor);

                            DS = sql.EjecutarBD(comando);

                            if (DS.Tables[0].Rows.Count > 0)
                                lista_detalles_reparaciones.Add(int.Parse(valor));
                        }

                        if (lista_detalles_reparaciones.Count <= 0)
                        {
                            MessageBox.Show("No hay suplidores que puedan reparar esos fallos.");
                            return;
                        }

                        Consultas.Suplidores obj = new Consultas.Suplidores();
                        obj.lista_detalles_reparaciones = lista_detalles_reparaciones;

                        if (obj.ShowDialog() == DialogResult.OK)
                        {
                            Utilidades.Modelos.Suplidores modelo = new Utilidades.Modelos.Suplidores();
                            DS = modelo.Busqueda(obj.DGV.SelectedRows[0].Cells["id_suplidor"].Value.ToString(), "id_suplidor");
                            txtSuplidor.Text = DS.Tables[0].Rows[0]["id_suplidor"].ToString() + " | " + DS.Tables[0].Rows[0]["nombre"].ToString();
                            txtIdentificacion.Text = DS.Tables[0].Rows[0]["identificacion"].ToString();
                            rtxtDireccion.Text = DS.Tables[0].Rows[0]["direccion"].ToString();
                            txtEmail.Text = DS.Tables[0].Rows[0]["email"].ToString();
                            txtTelefono.Text = DS.Tables[0].Rows[0]["telefono"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione al menos un fallo para ver los suplidores que reparen esos fallos.");
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                Utilidades.Utilidades.Form("Proyecto_SAPC.Consultas.Suplidores").BringToFront();
            }
        }

        private void btnConsultarArticulos_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Utilidades.FormAbierto("Proyecto_SAPC.Mantenimientos.Consultas.Articulos"))
            {
                Consultas.Articulos obj = new Consultas.Articulos();
                obj.ShowDialog();
            }
            else
            {
                Utilidades.Utilidades.Form("Proyecto_SAPC.Mantenimientos.Consultas.Articulos").BringToFront();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        DataSet Busqueda(int id_fallo)
        {
            string comando = String.Format(@"SELECT f.id_complejidad, c.dias
                                              FROM FALLOS f
                                              INNER JOIN COMPLEJIDADES c
                                              ON c.id_complejidad = f.id_complejidad
                                              WHERE f.id_fallo = {0}",
                                         id_fallo);

            DS = sql.EjecutarBD(comando);

            return DS;
        }

        void Guardar()
        {
            try
            {
                Utilidades.Clases.Tablas.Reparaciones reparaciones = new Utilidades.Clases.Tablas.Reparaciones();
                reparaciones.Num_reparacion = int.Parse(txtNumeroReparacion.Text.ToString().Trim());
                reparaciones.Id_usuario = int.Parse(txtUsuario.Text.Split('|')[0].Trim());
                reparaciones.Id_suplidor = int.Parse(txtSuplidor.Text.Split('|')[0].Trim());
                reparaciones.Nota = rtxtNota.Text.Trim();
                reparaciones.Fecha = fecha.Date;
                reparaciones.Id_articulo = int.Parse(txtArticulo.Text.Split('|')[0].Trim());

                detalles_reparaciones = new Utilidades.Clases.Tablas.Detalles_Reparaciones();
                lista_detalles_reparaciones = new List<int>();

                var checkRows = from DataGridViewRow r in DGV_Fallos.Rows
                                where Convert.ToBoolean(r.Cells[0].Value) == true
                                select r;

                int suma_complejidades = 0, cont = 0, dias_prediccion = 0, mayor_complejidad = 0, dias_mayor_complejidad = 0, dias_promedio_complejidades; float promedio_complejidades;

                List<int> lista_id_complejidad = new List<int>();

                foreach (var row in checkRows)
                {
                    detalles_reparaciones.Id_fallo = int.Parse(row.Cells[1].Value.ToString().Trim());
                    DS = Busqueda(detalles_reparaciones.Id_fallo);

                    lista_id_complejidad.Add(int.Parse(DS.Tables[0].Rows[0]["id_complejidad"].ToString()));

                    if (DS.Tables.Count > 0)
                    {
                        //MessageBox.Show("N : " + DS.Tables[0].Rows[0]["nivel"].ToString() + " 44 " + detalles_reparaciones.Id_fallo);
                        suma_complejidades += int.Parse(DS.Tables[0].Rows[0]["id_complejidad"].ToString());
                        cont++;
                        lista_detalles_reparaciones.Add(int.Parse(row.Cells[1].Value.ToString()));
                    }
                }

                mayor_complejidad = lista_id_complejidad.Max();
                DS = BuscarDias(mayor_complejidad);
                dias_mayor_complejidad = int.Parse(DS.Tables[0].Rows[0]["dias"].ToString());

                if (suma_complejidades != 0)
                {
                    promedio_complejidades = suma_complejidades / cont;
                    DS = BuscarDias((int)promedio_complejidades);
                    dias_promedio_complejidades = int.Parse(DS.Tables[0].Rows[0]["dias"].ToString());
                    dias_prediccion = dias_mayor_complejidad + dias_promedio_complejidades;
                }

                Utilidades.Controladores.Reparaciones control = new Utilidades.Controladores.Reparaciones();
                string respuesta = control.Registro(reparaciones, lista_detalles_reparaciones, dias_prediccion);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Datos registrados correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.PerformClick();
                    DS = sql.EjecutarBD(string.Format("EXEC DATOS_FACTURA_REPARACIONES {0}", reparaciones.Num_reparacion));
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        DataSet BuscarDias(int mayor_complejidad)
        {
            string comando = String.Format(@"SELECT id_complejidad, dias
                                              FROM COMPLEJIDADES 
                                              WHERE id_complejidad = {0}",
                                         mayor_complejidad);

            DS = sql.EjecutarBD(comando);

            return DS;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                txtFecha.Text = sql.FechaBD().Split(' ')[0].Trim() + " " + sql.FechaBD().Substring(sql.FechaBD().IndexOf(sql.FechaBD().Split(' ')[1].ToString()));
            }
            catch (Exception) { }
        }

        private void pnlArticulo_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Black;
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.pnlArticulo.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void txtBuscarFallo_TextChanged(object sender, EventArgs e)
        {
            CargarFallos();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Utilidades.FormAbierto("Proyecto_SAPC.Consultas.Articulos"))
            {
                Consultas.Articulos obj = new Consultas.Articulos();

                if (obj.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Utilidades.Modelos.Articulos modelo = new Utilidades.Modelos.Articulos();
                        DS = modelo.Busqueda(obj.DGV.SelectedRows[0].Cells["id_articulo"].Value.ToString(), "a.id_articulo");
                        txtArticulo.Text = DS.Tables[0].Rows[0]["id_articulo"].ToString() + " | " + DS.Tables[0].Rows[0]["nombre"].ToString();
                        txtCategoria.Text = DS.Tables[0].Rows[0]["categoria"].ToString();
                        rtxtDescripcion.Text = DS.Tables[0].Rows[0]["descripcion"].ToString();
                        picImagen.Image = Image.FromFile(@"" + Utilidades.Utilidades.ruta + @"Proyecto SAPC\Utilidades\Imagenes\" + DS.Tables[0].Rows[0]["imagen"].ToString().Split(new[] { ": " }, StringSplitOptions.None)[2]);
                        picCodigoBarras.Image = Image.FromFile(@"" + Utilidades.Utilidades.ruta + @"Proyecto SAPC\Utilidades\Imagenes\" + DS.Tables[0].Rows[0]["codigo_barras"].ToString().Split(new[] { ": " }, StringSplitOptions.None)[2]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                Utilidades.Utilidades.Form("Proyecto_SAPC.Consultas.Articulos").BringToFront();
            }
        }

        private void DGV_Fallos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                // Get the id_fallo from the id_fallo column.
                int id_fallo = (int)DGV_Fallos.Rows[e.RowIndex].Cells["id_fallo"].Value;
                checkFallosState[id_fallo] = (bool)DGV_Fallos.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void DGV_Fallos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            // Handle the notification that the value for a cell in the virtual column
            // is needed. Get the value from the dictionary if the key exists.

            if (e.ColumnIndex == 0 && checkFallosState != null)
            {
                int id_fallo = (int)DGV_Fallos.Rows[e.RowIndex].Cells["id_fallo"].Value;
                if (checkFallosState.ContainsKey(id_fallo))
                    e.Value = checkFallosState[id_fallo];
                else
                    e.Value = false;
            }
        }

        private void DGV_Fallos_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            // Handle the notification that the value for a cell in the virtual column
            // needs to be pushed back to the dictionary.

            if (e.ColumnIndex == 0)
            {
                // Get the id_fallo from the id_fallo column.
                int id_fallo = (int)DGV_Fallos.Rows[e.RowIndex].Cells["id_fallo"].Value;

                // Add or update the checked value to the dictionary depending on if the 
                // key (id_fallo) already exists.
                if (!checkFallosState.ContainsKey(id_fallo))
                {
                    checkFallosState.Add(id_fallo, (bool)e.Value);
                }
                else
                    checkFallosState[id_fallo] = (bool)e.Value;
            }
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options.Margin = 0;

            if (!string.IsNullOrWhiteSpace(txtArticulo.Text))
                picCodigoBarras.Image = writer.Write(txtArticulo.Text.Split('|')[0]);
            else
                picCodigoBarras.Image = null;
        }

        private void txtNumeroReparacion_TextChanged(object sender, EventArgs e)
        {
            txtNumeroReparacion.Text = Utilidades.Utilidades.NumeroFactura("id_reparacion", "REPARACIONES").ToString();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "1 | José Peguero";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            checkFallosState.Clear();
            DGV_Fallos.DataSource = null;
            CargarFallos();
        }

        private void picCodigoBarras_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Black;
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.picCodigoBarras.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }
    }
}
