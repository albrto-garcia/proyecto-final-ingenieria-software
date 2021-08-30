using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Herramientas
{
    public partial class MaskedTextBox : System.Windows.Forms.MaskedTextBox
    {
        public MaskedTextBox()
        {
            InitializeComponent();
        }

        public bool Validar { set; get; }
        public bool CorreoValido { set; get; }
        public bool SoloNumeros { set; get; }
        public bool SoloLetras { set; get; }
        public bool SoloAlfanumerico { set; get; }

        public MaskedTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
