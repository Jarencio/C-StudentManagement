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
            ShowData();
            CB_SelCor.DataSource = CC.Getlist(new MySqlCommand ("SELECT * FROM `course`"));
            CB_SelCor.ValueMember = "Code";
            CB_SelCor.DisplayMember = "Code";
            ShowData();
            clearall();
        }

        public void ShowData()
        {
            Grades_GridView.DataSource = GC.gradelist();
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
                        GC.insertC(StudID, FN, LN, course, G, SC, Y, S, Sec);
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
    }
}
