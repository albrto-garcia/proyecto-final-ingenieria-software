using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SAPC.Mantenimientos.Crear
{
    public partial class Suplidores : Utilidades.Herramientas.Form
    {
        public Utilidades.Clases.Tablas.Suplidores suplidor;
        public IEnumerable<DataGridViewRow> CachedRows;
        public List<DataGridViewRow> CachedRowsList;
        private System.Collections.Generic.Dictionary<int, bool> checkState;

        public Suplidores()
        {
            InitializeComponent();

            Utilidades.Utilidades.ConfiguracionBotones(this);
            this.picImagen.Image = Utilidades.Imagenes.ImagesResources.imagen_por_defecto;

            btnAgregarTipoIdentificacion.ImageList = null;
            btnAgregarTipoIdentificacion.BackgroundImage = Utilidades.Imagenes.ImagesResources.agregar;
            btnAgregarTipoIdentificacion.BackgroundImageLayout = ImageLayout.Stretch;

            LlenarCbx();
            cbxEstado.SelectedIndex = 0;
            DGV_Fallos.AutoGenerateColumns = false;
            CargarFallos();

            // The check box column will be virtual.
            DGV_Fallos.VirtualMode = true;
            DGV_Fallos.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            DGV_Fallos.Columns[0].Width = 30;

            // Initialize the dictionary that contains the boolean check state.
            checkState = new Dictionary<int, bool>();
        }

        public void LlenarCbx()
        {
            String comando = @"SELECT * FROM TIPOS_IDENTIFICACIONES;";

            DS = sql.EjecutarBD(comando);

            cbxTipoIdentificacion.DataSource = DS.Tables[0].DefaultView;
            cbxTipoIdentificacion.DisplayMember = "tipo_identificacion";
            cbxTipoIdentificacion.ValueMember = "id_tipo_identificacion";

            btnAgregarTipoIdentificacion.Location = new Point(cbxTipoIdentificacion.Location.X + cbxTipoIdentificacion.Size.Width + 6, btnAgregarTipoIdentificacion.Location.Y);
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {

        }

        private void picImagen_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.Black;
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.picImagen.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void btnImagenPorDefecto_Click(object sender, EventArgs e)
        {
            this.picImagen.Image = Utilidades.Imagenes.ImagesResources.imagen_por_defecto;
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Utilidades.FormAbierto("Proyecto_SAPC.Mantenimientos.Imagenes"))
            {
                Mantenimientos.Imagenes obj = new Mantenimientos.Imagenes();

                if (obj.ShowDialog() == DialogResult.OK)
                {
                    picImagen.Image = obj.picImagen.Image;
                    LlenarCbx();
                }
            }
            else
            {
                Utilidades.Utilidades.Form("Proyecto_SAPC.Mantenimientos.Imagenes").BringToFront();
            }
        }

        void CargarFallos()
        {
            Utilidades.Modelos.Fallos modelo = new Utilidades.Modelos.Fallos();

            DS = modelo.Busqueda(txtBuscarFallo.Text.Trim());

            if (DS.Tables.Count > 0)
                DGV_Fallos.DataSource = DS.Tables[0];
        }

        private void txtBuscarFallo_TextChanged(object sender, EventArgs e)
        {
            CargarFallos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || Utilidades.Utilidades.CorreoValido(txtEmail.Text) == true)
            {
                txtBuscarFallo.Text = "";
                List<int> fallos = new List<int>();
                suplidor = new Utilidades.Clases.Tablas.Suplidores();
                suplidor.Id_suplidor = 0;
                suplidor.Id_identificacion = 0;
                suplidor.Id_tipo_identificacion = int.Parse(cbxTipoIdentificacion.SelectedValue.ToString());
                suplidor.Identificacion = txtIdentificacion.Text;
                suplidor.Nombre = txtNombre.Text;
                suplidor.Id_direccion = 0;
                suplidor.Direccion = rtxtDireccion.Text;
                suplidor.Estado = cbxEstado.SelectedItem.ToString().Trim().Contains("ACTIVO".Trim()) ? 1 : 0;
                suplidor.Id_email = 0;
                suplidor.Email = txtEmail.Text;
                suplidor.Id_telefono = 0;
                suplidor.Telefono = txtTelefono.Text;
                suplidor.Imagen = picImagen.Image;

                foreach (var row in checkState)
                {
                    fallos.Add(row.Key);
                }

                suplidor.Fallos = fallos;

                try
                {
                    Utilidades.Controladores.Suplidores control = new Utilidades.Controladores.Suplidores();
                    string respuesta = control.Registro(suplidor);

                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Suplidor registrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancelar.PerformClick();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Correo inválido!");
        }

        private void btnAgregarTipoIdentificacion_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Utilidades.FormAbierto("Proyecto_SAPC.Mantenimientos.Crear.Tipos_Identificaciones"))
            {
                Mantenimientos.Crear.Tipos_Identificaciones obj = new Mantenimientos.Crear.Tipos_Identificaciones();

                if (obj.ShowDialog() == DialogResult.Cancel)
                {
                    LlenarCbx();
                }
            }
            else
            {
                Utilidades.Utilidades.Form("Proyecto_SAPC.Mantenimientos.Crear.Tipos_Identificaciones").BringToFront();
            }
        }

        private void DGV_Fallos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                // Get the id_fallo from the id_fallo column.
                int id_fallo = (int)DGV_Fallos.Rows[e.RowIndex].Cells["id_fallo"].Value;
                checkState[id_fallo] = (bool)DGV_Fallos.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void DGV_Fallos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            // Handle the notification that the value for a cell in the virtual column
            // is needed. Get the value from the dictionary if the key exists.

            if (e.ColumnIndex == 0 && checkState != null)
            {
                int id_fallo = (int)DGV_Fallos.Rows[e.RowIndex].Cells["id_fallo"].Value;
                if (checkState.ContainsKey(id_fallo))
                    e.Value = checkState[id_fallo];
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
                if (!checkState.ContainsKey(id_fallo))
                {
                    checkState.Add(id_fallo, (bool)e.Value);
                }
                else
                    checkState[id_fallo] = (bool)e.Value;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            checkState.Clear();
            DGV_Fallos.DataSource = null;
            CargarFallos();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidades.ValidarInput(txtIdentificacion, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidades.ValidarInput(txtNombre, e);
        }

        private void txtBuscarFallo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidades.ValidarInput(txtBuscarFallo, e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidades.ValidarInput(txtEmail, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidades.ValidarInput(txtTelefono, e);
        }
    }
}
