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
    public partial class CoursePrintForm : Form
    {
        public CoursePrintForm()
        {
            InitializeComponent();
        }

        DGVPrinter printer = new DGVPrinter();


        private void btn_Print_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Course_GridView.Rows)
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
            printer.PrintPreviewDataGridView(Course_GridView);

            this.Close();
        }
        CourseClass CC = new CourseClass();
        public void ShowData(MySqlCommand com)
        {
            Course_GridView.ReadOnly = true;
            //Student_GridView.Height = 100;
            Course_GridView.DataSource = CC.Getlist(com);
        }

        private void CoursePrintForm_Load(object sender, EventArgs e)
        {
            ShowData(new MySqlCommand("SELECT * FROM `course` "));
        }
    }
}
