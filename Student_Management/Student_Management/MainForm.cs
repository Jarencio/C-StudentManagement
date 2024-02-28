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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CusDes();
        }

        StudentClass cl = new StudentClass();

        private void Form1_Load(object sender, EventArgs e)
        {
            StdCount();
        }

        private void StdCount()
        {
            lbl_TS.Text = "Total Students: " + cl.TotalStudent();
            lbl_TSM.Text = "Male: " + cl.MaleStd();
            lbl_TSF.Text = "Female: " + cl.FemaleStd();
        }

        private void CusDes()
        {
            pnl_StudentSubmenu.Visible = false;
            pnl_GradesSubmenu.Visible = false;
            pnl_CourseSubmenu.Visible = false;
        }

        private void Hidesubmenu()
        {
            if (pnl_StudentSubmenu.Visible == true)
                pnl_StudentSubmenu.Visible = false;
            if (pnl_GradesSubmenu.Visible == true)
                pnl_GradesSubmenu.Visible = false;
            if (pnl_CourseSubmenu.Visible == true)
                pnl_CourseSubmenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                Hidesubmenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }

        }


        private void Btn_Student_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_StudentSubmenu);
        }

        #region pnl_StudentSubmenu
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterForm());
            Hidesubmenu();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MSForm());
            Hidesubmenu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //...
            Hidesubmenu();
        }
        private void Btn_StdPrint_Click(object sender, EventArgs e)
        {
            //...
            Hidesubmenu();
        }

        #endregion pnl_StudentSubmenu
        private void Btn_Course_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_CourseSubmenu);
        }

        # region pnl_CourseSubmenu
        private void Btn_NewCourse_Click(object sender, EventArgs e)
        {
            //...
            Hidesubmenu();
        }

        private void Btn_MngCourse_Click(object sender, EventArgs e)
        {
            //...
            Hidesubmenu();
        }

        private void Btn_CoursePrint_Click(object sender, EventArgs e)
        {
            //...
            Hidesubmenu();
        }
        #endregion pnl_CourseSubmenu

        private void Btn_Grades_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_GradesSubmenu);
        }

        # region pnl_GradesSubmenu


        private void Btn_NewGrades_Click(object sender, EventArgs e)
        {
            //...
            Hidesubmenu();
        }

        private void Btn_MngGrades_Click(object sender, EventArgs e)
        {
            //...
            Hidesubmenu();
        }

        private void Btn_GradesPrint_Click(object sender, EventArgs e)
        {
            //...
            Hidesubmenu();
        }
        #endregion pnl_GradesSubmenu

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
 
        }

        private void lbl_Short_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Form activeform = null;

        private void OpenChildForm(Form ChildForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Pnl_Main.Controls.Add(ChildForm);
            Pnl_Main.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void Btn_Exit_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            // Close the active form if there is one
            if (activeform != null)
            {
                activeform.Close();
                StdCount();
            }

            // Show the cover panel
            Pnl_Main.Controls.Add(pnl_cover);

        }
    }
}
