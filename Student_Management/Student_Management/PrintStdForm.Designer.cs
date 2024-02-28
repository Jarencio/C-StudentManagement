
namespace Student_Management
{
    partial class PrintStdForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Student_GridView = new System.Windows.Forms.DataGridView();
            this.CB_Course = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Print = new System.Windows.Forms.Button();
            this.RB_A = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RB_F = new System.Windows.Forms.RadioButton();
            this.RB_M = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_GridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 62);
            this.panel1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(238, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(441, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "MANAGE STUDENT";
            // 
            // Student_GridView
            // 
            this.Student_GridView.AllowUserToAddRows = false;
            this.Student_GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.Student_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Student_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Student_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Student_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Student_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Student_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Student_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Student_GridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.Student_GridView.Location = new System.Drawing.Point(12, 102);
            this.Student_GridView.Margin = new System.Windows.Forms.Padding(0);
            this.Student_GridView.Name = "Student_GridView";
            this.Student_GridView.RowHeadersVisible = false;
            this.Student_GridView.RowHeadersWidth = 10;
            this.Student_GridView.RowTemplate.Height = 100;
            this.Student_GridView.Size = new System.Drawing.Size(857, 557);
            this.Student_GridView.TabIndex = 30;
            // 
            // CB_Course
            // 
            this.CB_Course.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Course.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Course.FormattingEnabled = true;
            this.CB_Course.Location = new System.Drawing.Point(428, 66);
            this.CB_Course.Name = "CB_Course";
            this.CB_Course.Size = new System.Drawing.Size(300, 31);
            this.CB_Course.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_Print);
            this.panel2.Controls.Add(this.RB_A);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.RB_F);
            this.panel2.Controls.Add(this.RB_M);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 662);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 89);
            this.panel2.TabIndex = 33;
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(704, 40);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(153, 42);
            this.btn_Print.TabIndex = 34;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            // 
            // RB_A
            // 
            this.RB_A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RB_A.AutoSize = true;
            this.RB_A.Checked = true;
            this.RB_A.Font = new System.Drawing.Font("Century", 12F);
            this.RB_A.Location = new System.Drawing.Point(8, 45);
            this.RB_A.Name = "RB_A";
            this.RB_A.Size = new System.Drawing.Size(57, 27);
            this.RB_A.TabIndex = 14;
            this.RB_A.TabStop = true;
            this.RB_A.Text = "All";
            this.RB_A.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century", 12F);
            this.radioButton1.Location = new System.Drawing.Point(299, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 27);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RB_F
            // 
            this.RB_F.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RB_F.AutoSize = true;
            this.RB_F.Font = new System.Drawing.Font("Century", 12F);
            this.RB_F.Location = new System.Drawing.Point(299, 40);
            this.RB_F.Name = "RB_F";
            this.RB_F.Size = new System.Drawing.Size(99, 27);
            this.RB_F.TabIndex = 13;
            this.RB_F.Text = "Female";
            this.RB_F.UseVisualStyleBackColor = true;
            // 
            // RB_M
            // 
            this.RB_M.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RB_M.AutoSize = true;
            this.RB_M.Font = new System.Drawing.Font("Century", 12F);
            this.RB_M.Location = new System.Drawing.Point(140, 45);
            this.RB_M.Name = "RB_M";
            this.RB_M.Size = new System.Drawing.Size(77, 27);
            this.RB_M.TabIndex = 12;
            this.RB_M.Text = "Male";
            this.RB_M.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(4, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sex:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(270, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Select Course:";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.BackColor = System.Drawing.Color.MediumBlue;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Search.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(734, 66);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(135, 29);
            this.Btn_Search.TabIndex = 36;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // PrintStdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(877, 754);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CB_Course);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Student_GridView);
            this.Name = "PrintStdForm";
            this.Text = "PrintStdForm";
            this.Load += new System.EventHandler(this.PrintStdForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_GridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Student_GridView;
        private System.Windows.Forms.ComboBox CB_Course;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RB_M;
        private System.Windows.Forms.RadioButton RB_A;
        private System.Windows.Forms.RadioButton RB_F;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Btn_Search;
    }
}