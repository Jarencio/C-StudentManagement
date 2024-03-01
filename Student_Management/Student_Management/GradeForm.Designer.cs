
namespace Student_Management
{
    partial class GradeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.CB_SelCor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SubAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GWA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Grades = new System.Windows.Forms.Label();
            this.Grades_GridView = new System.Windows.Forms.DataGridView();
            this.CB_connector = new System.Windows.Forms.ComboBox();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.CB_Sem = new System.Windows.Forms.ComboBox();
            this.Txt_Sec = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grades_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.CB_Sem);
            this.panel2.Controls.Add(this.CB_Year);
            this.panel2.Controls.Add(this.CB_connector);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.Txt_Sec);
            this.panel2.Controls.Add(this.CB_SelCor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_SubAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_GWA);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_ID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 125);
            this.panel2.TabIndex = 25;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.Purple;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(750, 66);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 49);
            this.btn_Add.TabIndex = 34;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.Orange;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(642, 66);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 49);
            this.btn_Clear.TabIndex = 33;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // CB_SelCor
            // 
            this.CB_SelCor.Font = new System.Drawing.Font("Century", 12F);
            this.CB_SelCor.FormattingEnabled = true;
            this.CB_SelCor.Location = new System.Drawing.Point(649, 21);
            this.CB_SelCor.Name = "CB_SelCor";
            this.CB_SelCor.Size = new System.Drawing.Size(201, 31);
            this.CB_SelCor.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(330, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Section:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(150, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Semester:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Year:";
            // 
            // txt_SubAmount
            // 
            this.txt_SubAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_SubAmount.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubAmount.Location = new System.Drawing.Point(566, 77);
            this.txt_SubAmount.Name = "txt_SubAmount";
            this.txt_SubAmount.Size = new System.Drawing.Size(66, 32);
            this.txt_SubAmount.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(387, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Subject Amount:";
            // 
            // txt_GWA
            // 
            this.txt_GWA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_GWA.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GWA.Location = new System.Drawing.Point(306, 76);
            this.txt_GWA.Name = "txt_GWA";
            this.txt_GWA.Size = new System.Drawing.Size(66, 32);
            this.txt_GWA.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(233, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "GWA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(497, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Course:";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ID.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(145, 76);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(66, 32);
            this.txt_ID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Lbl_Grades);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 62);
            this.panel1.TabIndex = 24;
            // 
            // Lbl_Grades
            // 
            this.Lbl_Grades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Grades.AutoSize = true;
            this.Lbl_Grades.Font = new System.Drawing.Font("Century Schoolbook", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Grades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Grades.Location = new System.Drawing.Point(333, 9);
            this.Lbl_Grades.Name = "Lbl_Grades";
            this.Lbl_Grades.Size = new System.Drawing.Size(205, 46);
            this.Lbl_Grades.TabIndex = 0;
            this.Lbl_Grades.Text = "GRADES";
            // 
            // Grades_GridView
            // 
            this.Grades_GridView.AllowUserToAddRows = false;
            this.Grades_GridView.AllowUserToDeleteRows = false;
            this.Grades_GridView.AllowUserToResizeColumns = false;
            this.Grades_GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Grades_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grades_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grades_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grades_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grades_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grades_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grades_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grades_GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grades_GridView.Location = new System.Drawing.Point(12, 70);
            this.Grades_GridView.Margin = new System.Windows.Forms.Padding(0);
            this.Grades_GridView.Name = "Grades_GridView";
            this.Grades_GridView.RowHeadersVisible = false;
            this.Grades_GridView.RowHeadersWidth = 10;
            this.Grades_GridView.RowTemplate.Height = 100;
            this.Grades_GridView.Size = new System.Drawing.Size(855, 554);
            this.Grades_GridView.TabIndex = 23;
            // 
            // CB_connector
            // 
            this.CB_connector.Font = new System.Drawing.Font("Century", 12F);
            this.CB_connector.FormattingEnabled = true;
            this.CB_connector.Location = new System.Drawing.Point(769, 22);
            this.CB_connector.Name = "CB_connector";
            this.CB_connector.Size = new System.Drawing.Size(10, 31);
            this.CB_connector.TabIndex = 35;
            this.CB_connector.Visible = false;
            // 
            // CB_Year
            // 
            this.CB_Year.Font = new System.Drawing.Font("Century", 12F);
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_Year.Location = new System.Drawing.Point(75, 21);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(69, 31);
            this.CB_Year.TabIndex = 37;
            // 
            // CB_Sem
            // 
            this.CB_Sem.Font = new System.Drawing.Font("Century", 12F);
            this.CB_Sem.FormattingEnabled = true;
            this.CB_Sem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CB_Sem.Location = new System.Drawing.Point(255, 22);
            this.CB_Sem.Name = "CB_Sem";
            this.CB_Sem.Size = new System.Drawing.Size(69, 31);
            this.CB_Sem.TabIndex = 38;
            // 
            // Txt_Sec
            // 
            this.Txt_Sec.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Sec.Location = new System.Drawing.Point(424, 21);
            this.Txt_Sec.Name = "Txt_Sec";
            this.Txt_Sec.Size = new System.Drawing.Size(66, 32);
            this.Txt_Sec.TabIndex = 32;
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(877, 754);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grades_GridView);
            this.Name = "GradeForm";
            this.Text = "GradeForm";
            this.Load += new System.EventHandler(this.GradeForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grades_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Grades;
        private System.Windows.Forms.DataGridView Grades_GridView;
        private System.Windows.Forms.ComboBox CB_SelCor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SubAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GWA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox CB_connector;
        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.ComboBox CB_Sem;
        private System.Windows.Forms.TextBox Txt_Sec;
    }
}