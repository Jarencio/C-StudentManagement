using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.IO;

namespace Student_Management
{
    public partial class PrintStdForm : Form
    {
        StudentClass student = new StudentClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintStdForm()
        {
            InitializeComponent();
            RB_M.CheckedChanged += RadioButton_CheckedChanged;
            RB_F.CheckedChanged += RadioButton_CheckedChanged;
            RB_A.CheckedChanged += RadioButton_CheckedChanged;
        }



        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            // Only execute if the radio button is checked
            if (radioButton.Checked)
            {
                // Uncheck the other two radio buttons
                if (radioButton == RB_M)
                {
                    RB_F.Checked = false;
                    RB_A.Checked = false;
                }
                else if (radioButton == RB_F)
                {
                    RB_M.Checked = false;
                    RB_A.Checked = false;
                }
                else if (radioButton == RB_A)
                {
                    RB_M.Checked = false;
                    RB_F.Checked = false;
                }
            }

        }

        private void PrintStdForm_Load(object sender, EventArgs e)
        {
            ShowData(new MySqlCommand("SELECT * FROM `student`"));
        }

        public void ShowData(MySqlCommand com)
        {
            Student_GridView.ReadOnly = true;
            DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            //Student_GridView.Height = 100;
            Student_GridView.DataSource = student.Getlist(com);

            imgcolumn = (DataGridViewImageColumn)Student_GridView.Columns[8];
            imgcolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        
        string selectquery;
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (RB_A.Checked)
            {
                selectquery = "SELECT * FROM `student`";
            }
            else if (RB_M.Checked)
            {
                selectquery = "SELECT * FROM `student` WHERE Sex = 'male'";
            }
            else
            {
                selectquery = "SELECT * FROM `student` WHERE Sex = 'female'";
            }

            ShowData(new MySqlCommand(selectquery));
        }

   


        private void Student_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {


            // Resize the images in column 8 to a fixed height
            foreach (DataGridViewRow row in Student_GridView.Rows)
            {
                DataGridViewImageCell cell = row.Cells[8] as DataGridViewImageCell;
                if (cell != null && cell.Value != null)
                {
                    byte[] imgData = (byte[])cell.Value;
                    if (imgData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            Image img = Image.FromStream(ms);
                            // Specify the desired height for the image
                            int fixedHeight = 100; // Adjust this value as needed
                                                   // Calculate the aspect ratio to maintain image proportions
                            float aspectRatio = img.Width / (float)img.Height;
                            int newWidth = (int)(fixedHeight * aspectRatio);
                            // Resize the image
                            cell.Value = img.GetThumbnailImage(newWidth, fixedHeight, null, IntPtr.Zero);
                        }
                    }
                }
            }

            // Set up the printer properties
            printer.Title = "PDM Student's List";
            printer.SubTitle = string.Format("Date: " + DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.printDocument.DefaultPageSettings.Landscape = true;

            // Set the page settings to fit all rows and columns on a single page

            // Print the DataGridView
            printer.PrintPreviewDataGridView(Student_GridView);

            this.Close();
                
        }


        private void Student_GridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RB_M_CheckedChanged(object sender, EventArgs e) { 
            selectquery = "SELECT * FROM `student` WHERE Sex = 'male'";
            ShowData(new MySqlCommand(selectquery));

        }

        private void RB_A_CheckedChanged(object sender, EventArgs e)
        {
            selectquery = "SELECT * FROM `student`";
            ShowData(new MySqlCommand(selectquery));
        }

        private void RB_Fem_CheckedChanged(object sender, EventArgs e)
        {
            selectquery = "SELECT * FROM `student` WHERE Sex = 'female'";
            ShowData(new MySqlCommand(selectquery));
        }
    }
}
