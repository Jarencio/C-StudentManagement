using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class RegisterForm : Form
    {
        StudentClass student = new StudentClass();
        public RegisterForm()
        {
            InitializeComponent();
            CB_M.CheckedChanged += CheckBox_CheckedChanged;
            CB_F.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                PB_Student.Image = Image.FromFile(opf.FileName);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
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
                    if (student.insertSTD(FName, LName, MiddleI, BDD, Sx, Num, Addr, img))
                    {
                        showTable();
                        MessageBox.Show("New Student is added to the record!", "Registraion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_All();
        }

        private void CB_M_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CB_F_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure only one checkbox is checked at a time
            if (((CheckBox)sender).Checked)
            {
                if (sender == CB_M)
                {
                    CB_F.Checked = false;
                }
                else if (sender == CB_F)
                {
                    CB_M.Checked = false;
                }
            }
        }

        private void Registration_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showTable()
        {
            Registration_GridView.DataSource = student.getstudentlist();
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)Registration_GridView.Columns[8];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
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
