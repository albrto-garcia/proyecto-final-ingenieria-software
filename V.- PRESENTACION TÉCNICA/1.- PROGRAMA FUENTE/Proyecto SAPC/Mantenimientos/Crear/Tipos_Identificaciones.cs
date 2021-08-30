using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace Proyecto_SAPC.Mantenimientos.Crear
{
    public partial class Tipos_Identificaciones : Utilidades.Herramientas.Form
    {
        public Tipos_Identificaciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Utilidades.Clases.Tablas.Tipos_Identificaciones tipos_Identificaciones = new Utilidades.Clases.Tablas.Tipos_Identificaciones();
            tipos_Identificaciones.Id_tipo_identificacion = 0;
            tipos_Identificaciones.Nombre = txtNombre.Text;
            tipos_Identificaciones.Descripcion = txtDescripcion.Text;

            try
            {
                Utilidades.Controladores.Tipos_Identificaciones control = new Utilidades.Controladores.Tipos_Identificaciones();
                string respuesta = control.Registro(tipos_Identificaciones);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Datos registrados correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
