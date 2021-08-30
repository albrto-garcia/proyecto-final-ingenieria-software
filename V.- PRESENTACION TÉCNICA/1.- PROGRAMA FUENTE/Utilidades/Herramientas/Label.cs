using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Herramientas
{
    public partial class Label : System.Windows.Forms.Label
    {
        public Label()
        {
            InitializeComponent();
        }

        public Label(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
