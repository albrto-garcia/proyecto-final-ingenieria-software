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

namespace Proyecto_SAPC.Ajustes
{
    public partial class Backup : Utilidades.Herramientas.Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string comando = String.Format("EXEC BACKUP_BD '{0}', '{1}'", txtRuta.Text, txtNombre.Text);

            DS = sql.EjecutarBD(comando);

            MessageBox.Show("Backup realizado correctamente!");
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtRuta.Text = fbd.SelectedPath + "\\";
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.Utilidades.ValidarInput(txtNombre, e);
        }
    }
}
