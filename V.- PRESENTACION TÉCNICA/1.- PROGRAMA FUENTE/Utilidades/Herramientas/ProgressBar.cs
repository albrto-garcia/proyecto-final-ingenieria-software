using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades.Herramientas
{
    public partial class ProgressBar : Component
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        public ProgressBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
	}
}
