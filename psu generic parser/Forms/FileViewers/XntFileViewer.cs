using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSULib.FileClasses.Models;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace psu_generic_parser.FileViewers
{
    public partial class XntFileViewer : UserControl
    {
        public XntFile loadedFile;
        private TextBox externalTextBox;

        public XntFileViewer(XntFile xnt, TextBox textBox)
        {
            InitializeComponent();
            loadedFile = xnt;
            dataGridView1.DataSource = xnt.fileEntries;


            externalTextBox = textBox;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the clicked cell
                    var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Retrieve the text value of the cell
                    string cellValue = cell.Value?.ToString() ?? string.Empty;

                    Clipboard.SetText(cellValue);
                    if (externalTextBox != null)
                    {
                        externalTextBox.Text = cellValue;
                    }
                }
            }
        }
    }
}
