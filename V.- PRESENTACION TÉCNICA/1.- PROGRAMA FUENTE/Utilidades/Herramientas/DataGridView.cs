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
    [Designer(typeof(System.Windows.Forms.Design.ControlDesigner))]
    public partial class DataGridView : System.Windows.Forms.DataGridView
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        public DataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool SelectNextCell()
        {
            int row = CurrentCell.RowIndex;
            int column = CurrentCell.ColumnIndex;
            DataGridViewCell startingCell = CurrentCell;

            do
            {
                column++;
                if (column == Columns.Count)
                {
                    column = 0;
                    row++;
                }
                if (row == Rows.Count)
                    row = 0;
            } while (this[column, row].ReadOnly == true && this[column, row] != startingCell);

            if (this[column, row] == startingCell)
                return false;

            CurrentCell = this[column, row];
            //BeginEdit(true);

            return true;
        }

        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
                return SelectNextCell();
            return base.ProcessDataGridViewKey(e);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((keyData & Keys.KeyCode) == Keys.Tab || (keyData & Keys.KeyCode) == Keys.Enter)
                return SelectNextCell();
            return base.ProcessDialogKey(keyData);
        }
    }
}
