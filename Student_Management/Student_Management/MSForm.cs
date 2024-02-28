using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class MSForm : Form
    {
        StudentClass student = new StudentClass();



        public MSForm()
        {
            InitializeComponent();
        }

        private void MSForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            Student_GridView.DataSource = student.getstudentlist();
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)Student_GridView.Columns[8];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void Registration_GridView_Click(object sender, EventArgs e)
        {

        }

        private void Student_GridView_Click(object sender, EventArgs e)
        {
            
            txt_ID.Text = Student_GridView.CurrentRow.Cells[0].Value.ToString();
            txt_FN.Text = Student_GridView.CurrentRow.Cells[1].Value.ToString();
            txt_LN.Text = Student_GridView.CurrentRow.Cells[2].Value.ToString();
            txt_MI.Text = Student_GridView.CurrentRow.Cells[3].Value.ToString();

            DT_Birth.Value = (DateTime)Student_GridView.CurrentRow.Cells[4].Value;
            if (Student_GridView.CurrentRow.Cells[5].Value.ToString() == "Male")
            {
                if (CB_F.Checked = true)
                    CB_F.Checked = false;

                CB_M.Checked = true;
            }
            else
            {
                if (CB_M.Checked = true)
                    CB_M.Checked = false;

                CB_F.Checked = true;
            }
            txt_PhoneNumber.Text = Student_GridView.CurrentRow.Cells[6].Value.ToString();
            txt_Address.Text = Student_GridView.CurrentRow.Cells[7].Value.ToString();
            byte[] img = (byte[])Student_GridView.CurrentRow.Cells[8].Value;
            MemoryStream ms = new MemoryStream(img);
            PB_Student.Image = Image.FromStream(ms);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Address.Clear();
            txt_FN.Clear();
            txt_LN.Clear();
            txt_MI.Clear();
            txt_PhoneNumber.Clear();
            txt_ID.Clear();
            PB_Student.Image = null;
            DT_Birth.Value = DateTime.Now;
            CB_M.Checked = true;
            CB_F.Checked = false;
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                PB_Student.Image = Image.FromFile(opf.FileName);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Student_GridView.DataSource = student.SearchStudent(txt_searchbox.Text);
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)Student_GridView.Columns[8];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }


        private void btn_Upd_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txt_ID.Text);
            String FName = txt_FN.Text;
            String LName = txt_LN.Text;
            String MiddleI = txt_MI.Text;
            String Addr = txt_Address.Text;
            String Num = txt_PhoneNumber.Text;
            DateTime BDD = DT_Birth.Value;
            String Sx = CB_M.Checked ? "Male" : "Female";


            int birthyear = DT_Birth.Value.Year;
            int nowyear = DateTime.Now.Year;
            if ((nowyear - birthyear) < 10 || (nowyear - birthyear) > 100)
            {
                MessageBox.Show("You Must be in the age of 10 to 100 years old to register", "Registraion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    PB_Student.Image.Save(ms, PB_Student.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.updateSTD(ID,FName, LName, MiddleI, BDD, Sx, Num, Addr, img))
                    {
                        showTable();
                        MessageBox.Show("Student is updated to the record!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_All();

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill Up all the Important Informations", "Registraion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool verify()
        {
            if ((txt_FN.Text == "") || (txt_LN.Text == "") ||
                (txt_Address.Text == "") || (txt_PhoneNumber.Text == "") ||
                PB_Student.Image == null)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private void Clear_All()
        {
            txt_Address.Clear();
            txt_FN.Clear();
            txt_LN.Clear();
            txt_MI.Clear();
            txt_PhoneNumber.Clear();
            PB_Student.Image = null;
            DT_Birth.Value = DateTime.Now;
            CB_M.Checked = true;
            CB_F.Checked = false;
        }


    }
}
