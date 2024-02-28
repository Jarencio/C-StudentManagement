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

namespace Student_Management
{
    public partial class PrintStdForm : Form
    {
        StudentClass student = new StudentClass();

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
           // Student_GridView.Height = 100;
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
    }
}
