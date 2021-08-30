using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades.Herramientas
{
    public partial class TextBox : System.Windows.Forms.TextBox
    {
        public TextBox()
        {
            InitializeComponent();
        }

        public TextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool Validar { set; get; }
        public bool CorreoValido { set; get; }
        public bool SoloNumeros { set; get; }
        public bool SoloLetras { set; get; }
        public bool SoloAlfanumerico { set; get; }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
