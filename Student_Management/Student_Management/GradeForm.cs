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
    public partial class GradeForm : Form
    {
        CourseClass CC = new CourseClass();
        StudentClass SClass = new StudentClass();
        GradeClass GC = new GradeClass();
        public GradeForm()
        {
            InitializeComponent();
        }

        private void GradeForm_Load(object sender, EventArgs e)
        {
            ShowData(new MySqlCommand("SELECT `Student_ID`, `FirstName`, `LastName`, `Course`, `GWA`, `SubjCount`, CONCAT(`Year`, `Sem`, ' - ', `Section`) AS `Section` FROM `grades`"));
            CB_SelCor.DataSource = CC.Getlist(new MySqlCommand ("SELECT * FROM `course`"));
            CB_SelCor.ValueMember = "Code";
            CB_SelCor.DisplayMember = "Code";
            clearall();

        }
        public void ShowData(MySqlCommand com)
        {
            Grades_GridView.ReadOnly = true;
            DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            //Student_GridView.Height = 100;
            Grades_GridView.DataSource = CC.Getlist(com);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            CB_connector.Visible = true;
            int StudID = Convert.ToInt32(txt_ID.Text);

            CB_connector.DataSource = SClass.Names(new MySqlCommand("SELECT `FirstName` FROM `student` WHERE `StudentID` = @id"), StudID);
            CB_connector.ValueMember = "FirstName";
            string FN = CB_connector.Text;
            CB_connector.DataSource = SClass.Names(new MySqlCommand("SELECT `LastName` FROM `student` WHERE `StudentID` = @id"), StudID);
            CB_connector.ValueMember = "LastName";
            string LN = CB_connector.Text;
            string course = CB_SelCor.Text;
            float G = Convert.ToSingle(txt_GWA.Text);
            int SC = Convert.ToInt32(txt_SubAmount.Text);
            int Y = Convert.ToInt32(CB_Year.Text);
            int S = Convert.ToInt32(CB_Sem.Text);
            string Sec = Txt_Sec.Text;
            GC.insertC(StudID, FN, LN, course,G, SC, Y, S,Sec);
            CB_connector.Visible = false;
            clearall();
        }

        private void clearall()
        {
            txt_GWA.Text = "";
            txt_ID.Text = "";
            txt_SubAmount.Text = "";
            Txt_Sec.Text = "";
            CB_SelCor.SelectedIndex = 0;
            CB_Year.SelectedIndex = 0;
            CB_Sem.SelectedIndex = 0;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearall();
        }
    }
}
