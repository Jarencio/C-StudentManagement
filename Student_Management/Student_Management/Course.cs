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
    public partial class Course : Form
    {
        CourseClass CC = new CourseClass();
        public Course()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string Course = txt_course.Text;
            string Code = txt_coursecode.Text;
            string holdplacer = txt_years.Text;
            int year;

            
                if (verify())
                {
                if (int.TryParse(holdplacer, out year))
                {
                    CC.insertC(Course, Code, year);
                    ShowData(new MySqlCommand("SELECT * FROM `course`"));
                    MessageBox.Show("New Course is added to the record!", "Course Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearall();
                }
                else
                {
                    MessageBox.Show("Please fill up the information correctly", "Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_years.Text = "";
                }
            } else
                {
                    MessageBox.Show("Fill Up all the Important Informations", "Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        



        private void Course_Load(object sender, EventArgs e)
        {
            ShowData(new MySqlCommand("SELECT * FROM `course`"));
        }

        public void ShowData(MySqlCommand com)
        {
            Course_GridView.ReadOnly = true;
            DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            //Student_GridView.Height = 100;
            Course_GridView.DataSource = CC.Getlist(com);
        }

        bool verify()
        {
            if((txt_course.Text == "") || (txt_coursecode.Text == "") || (txt_years.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void clearall()
        {
            txt_course.Text = "";
            txt_coursecode.Text = "";
            txt_years.Text = "";
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void Course_GridView_Click(object sender, EventArgs e)
        {

        }
    }
    }
