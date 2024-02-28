
namespace Student_Management
{
    partial class MSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PB_Student = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_F = new System.Windows.Forms.CheckBox();
            this.CB_M = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DT_Birth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Registration_GridView = new System.Windows.Forms.DataGridView();
            this.txt_FN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Student)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Registration_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Student
            // 
            this.PB_Student.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PB_Student.Location = new System.Drawing.Point(727, 535);
            this.PB_Student.Name = "PB_Student";
            this.PB_Student.Size = new System.Drawing.Size(138, 138);
            this.PB_Student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Student.TabIndex = 35;
            this.PB_Student.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(556, 646);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Phone Number:";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(115, 642);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(435, 74);
            this.txt_Address.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(13, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Address:";
            // 
            // CB_F
            // 
            this.CB_F.AutoSize = true;
            this.CB_F.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_F.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CB_F.Location = new System.Drawing.Point(634, 601);
            this.CB_F.Name = "CB_F";
            this.CB_F.Size = new System.Drawing.Size(82, 22);
            this.CB_F.TabIndex = 31;
            this.CB_F.Text = "Female";
            this.CB_F.UseVisualStyleBackColor = true;
            // 
            // CB_M
            // 
            this.CB_M.AutoSize = true;
            this.CB_M.Checked = true;
            this.CB_M.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_M.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CB_M.Location = new System.Drawing.Point(566, 601);
            this.CB_M.Name = "CB_M";
            this.CB_M.Size = new System.Drawing.Size(65, 22);
            this.CB_M.TabIndex = 30;
            this.CB_M.Text = "Male";
            this.CB_M.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(509, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sex:";
            // 
            // DT_Birth
            // 
            this.DT_Birth.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_Birth.Location = new System.Drawing.Point(161, 597);
            this.DT_Birth.Name = "DT_Birth";
            this.DT_Birth.Size = new System.Drawing.Size(345, 29);
            this.DT_Birth.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(13, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date of Birth:";
            // 
            // txt_MI
            // 
            this.txt_MI.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MI.Location = new System.Drawing.Point(634, 542);
            this.txt_MI.Name = "txt_MI";
            this.txt_MI.Size = new System.Drawing.Size(78, 32);
            this.txt_MI.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(586, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "MI:";
            // 
            // txt_LN
            // 
            this.txt_LN.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LN.Location = new System.Drawing.Point(429, 541);
            this.txt_LN.Name = "txt_LN";
            this.txt_LN.Size = new System.Drawing.Size(151, 32);
            this.txt_LN.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(302, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 62);
            this.panel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(265, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "REGISTRATON";
            // 
            // Registration_GridView
            // 
            this.Registration_GridView.AllowUserToAddRows = false;
            this.Registration_GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Registration_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Registration_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Registration_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Registration_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Registration_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Registration_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Registration_GridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.Registration_GridView.Location = new System.Drawing.Point(12, 97);
            this.Registration_GridView.Margin = new System.Windows.Forms.Padding(0);
            this.Registration_GridView.Name = "Registration_GridView";
            this.Registration_GridView.RowHeadersVisible = false;
            this.Registration_GridView.RowHeadersWidth = 10;
            this.Registration_GridView.RowTemplate.Height = 100;
            this.Registration_GridView.Size = new System.Drawing.Size(855, 428);
            this.Registration_GridView.TabIndex = 21;
            // 
            // txt_FN
            // 
            this.txt_FN.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FN.Location = new System.Drawing.Point(145, 542);
            this.txt_FN.Name = "txt_FN";
            this.txt_FN.Size = new System.Drawing.Size(151, 32);
            this.txt_FN.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(13, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "First Name:";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Purple;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(727, 731);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(138, 34);
            this.btn_Add.TabIndex = 39;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Orange;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(581, 731);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(138, 34);
            this.btn_Clear.TabIndex = 38;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Upload.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.ForeColor = System.Drawing.Color.White;
            this.btn_Upload.Location = new System.Drawing.Point(727, 679);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(138, 34);
            this.btn_Upload.TabIndex = 37;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNumber.Location = new System.Drawing.Point(560, 682);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(159, 32);
            this.txt_PhoneNumber.TabIndex = 36;
            // 
            // MSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(877, 773);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.PB_Student);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_F);
            this.Controls.Add(this.CB_M);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DT_Birth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_LN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Registration_GridView);
            this.Controls.Add(this.txt_FN);
            this.Controls.Add(this.label1);
            this.Name = "MSForm";
            this.Text = "MSForm";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Student)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Registration_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Student;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CB_F;
        private System.Windows.Forms.CheckBox CB_M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DT_Birth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Registration_GridView;
        private System.Windows.Forms.TextBox txt_FN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
    }
}