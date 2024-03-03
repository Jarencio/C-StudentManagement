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
    public partial class UpdtGradesForm : Form
    {
        GradeClass GC = new GradeClass();
        CourseClass CC = new CourseClass();
        StudentClass SClass = new StudentClass();


        public UpdtGradesForm()
        {
            InitializeComponent();
        }

        private void UpdtGradesForm_Load(object sender, EventArgs e)
        {
            ShowData();
            CB_SelCor.DataSource = CC.Getlist(new MySqlCommand("SELECT * FROM `course`"));
            CB_SelCor.ValueMember = "Code";
            CB_SelCor.DisplayMember = "Code";
            ShowData();
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

        public void ShowData()
        {
            Grades_GridView.DataSource = GC.gradelist();
        }
        int GradesID;
        private void Grades_GridView_Click(object sender, EventArgs e)
        {
          
                GradesID = Convert.ToInt32(Grades_GridView.CurrentRow.Cells[0].Value);
            
                txt_ID.Text = Grades_GridView.CurrentRow.Cells[1].Value.ToString();
            CB_SelCor.Text = Grades_GridView.CurrentRow.Cells[4].Value.ToString();
            txt_GWA.Text = Grades_GridView.CurrentRow.Cells[5].Value.ToString();
            txt_SubAmount.Text = Grades_GridView.CurrentRow.Cells[6].Value.ToString();
            string input = Grades_GridView.CurrentRow.Cells[7].Value.ToString();
            string[] parts = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);


            string Yr = parts[0].Substring(0, 1); // First character of the first part
            string Sm = parts[0].Substring(1, 1); // Second character of the first part
            string Sec = parts[1]; // Join remaining parts as a single string

                // Assign values to controls
                CB_Year.Text = Yr;
                CB_Sem.Text = Sm;
                Txt_Sec.Text = Sec;
               
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int SubCo;
            float GD;
            int Sid;

            if (verify())
            {
                // Parse input values
                if (int.TryParse(txt_SubAmount.Text, out SubCo) &&
                    float.TryParse(txt_GWA.Text, out GD) &&
                    int.TryParse(txt_ID.Text, out Sid))
                {
                    // Check if any input field is empty
                    if (SubCo == 0 || GD == 0.0 || Sid == 0)
                    {
                        // If any input field is empty, display error message
                        MessageBox.Show("Please Fill up the Informations correctly", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // All input fields have valid values
                        CB_connector.Visible = true;
                        int StudID = Sid;
                        CB_connector.DataSource = SClass.Names(new MySqlCommand("SELECT `FirstName` FROM `student` WHERE `StudentID` = @id"), StudID);
                        CB_connector.ValueMember = "FirstName";
                        string FN = CB_connector.Text;
                        CB_connector.DataSource = SClass.Names(new MySqlCommand("SELECT `LastName` FROM `student` WHERE `StudentID` = @id"), StudID);
                        CB_connector.ValueMember = "LastName";
                        string LN = CB_connector.Text;
                        string course = CB_SelCor.Text;
                        float G = GD;
                        int SC = SubCo;
                        int Y = Convert.ToInt32(CB_Year.Text);
                        int S = Convert.ToInt32(CB_Sem.Text);
                        string Sec = Txt_Sec.Text;
                        GC.updtClass(GradesID,StudID, FN, LN, course, G, SC, Y, S, Sec);
                        CB_connector.Visible = false;
                        clearall();
                        ShowData();
                    }
                }
                else
                {
                    // If parsing fails for any input field, display error message
                    MessageBox.Show("Please Fill up the Informations correctly", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill up all the Information", "FAILED ADDITION OF GRADES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool verify()
        {
            if ((txt_GWA.Text == "") || (txt_ID.Text == "") ||
                (txt_SubAmount.Text == "") || (Txt_Sec.Text == ""))
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Grades_GridView.DataSource = GC.SearchGrade(txt_searchbox.Text);

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            GC.deltclass(GradesID);
            ShowData();

        }

        private void txt_searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
