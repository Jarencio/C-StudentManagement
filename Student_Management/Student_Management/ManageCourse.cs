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
    public partial class ManageCourse : Form
    {
        CourseClass CC = new CourseClass();
        public ManageCourse()
        {
            InitializeComponent();
        }

        public void ShowData(MySqlCommand com)
        {
            Course_GridView.ReadOnly = true;
           // DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            //Student_GridView.Height = 100;
            Course_GridView.DataSource = CC.Getlist(com);
        }

        public void showTable()
        {
             Course_GridView.DataSource = CC.getcourselist();
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void Course_GridView_Click(object sender, EventArgs e)
        {
            txt_ID.Text = Course_GridView.CurrentRow.Cells[0].Value.ToString();
            txt_course.Text = Course_GridView.CurrentRow.Cells[1].Value.ToString();
            txt_coursecode.Text = Course_GridView.CurrentRow.Cells[2].Value.ToString();
            txt_years.Text = Course_GridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearall();
        }



        public void clearall()
        {
            txt_ID.Text = "";
            txt_course.Text = "";
            txt_coursecode.Text = "";
            txt_years.Text = "";
        }

        private void btn_Upd_Click(object sender, EventArgs e)
        {
            string Course = txt_course.Text;
            string Code = txt_coursecode.Text;
            string holdplacer = txt_years.Text;
            string holdplacer2 = txt_ID.Text;
            int year;
            int I ;

            if (verify())
            {
                if (int.TryParse(holdplacer, out year))
                {
                    if (int.TryParse(holdplacer2, out I))
                    {
                        CC.updateC(I, Course, Code, year);
                        ShowData(new MySqlCommand("SELECT * FROM `course`"));
                        MessageBox.Show("New Course is updated to the record!", "Course Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearall();
                    }
                    else
                    {
                        MessageBox.Show("Please fill up the information correctly", "Adding Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                    else
                    {
                    MessageBox.Show("Please fill up the information correctly", "Adding Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_years.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fill Up all the Important Informations", "Adding Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool verify()
        {
            if ((txt_course.Text == "") || (txt_coursecode.Text == "") || (txt_years.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Course_GridView.DataSource = CC.SearchCourse(txt_searchbox.Text);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            int s;
            if (int.TryParse(txt_ID.Text,out s))
            {   }
            CC.deltcourse(s);
            showTable();
        }
    }
}