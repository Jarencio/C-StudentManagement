using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class GradesList : Form
    {
        public GradesList()
        {
            InitializeComponent();
        }

        DGVPrinter printer = new DGVPrinter();
        GradeClass GC = new GradeClass();
        private void GradesList_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            Grades_GridView.DataSource = GC.gradelist();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Grades_GridView.Rows)
            {
                // Access the cell in the 4th column (index 3)
                DataGridViewCell cell = row.Cells[3];
                if (cell.Value != null)
                {
                    string cellValue = cell.Value.ToString();
                    if (!string.IsNullOrEmpty(cellValue))
                    {
                        // Specify the desired height for the cell
                        int fixedHeight = 100; // Adjust this value as needed
                                               // Update the cell's height
                        cell.Style.Padding = new Padding(0, 0, 0, fixedHeight - cell.Size.Height);
                    }
                }
            }

            printer.Title = "PDM Course's List";
            printer.SubTitle = string.Format("Date: " + DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.printDocument.DefaultPageSettings.Landscape = true;

            // Set the page settings to fit all rows and columns on a single page

            // Print the DataGridView
            printer.PrintPreviewDataGridView(Grades_GridView);

            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Grades_GridView.DataSource = GC.SearchGrade(txt_searchbox.Text);
        }
    }
}
