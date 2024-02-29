
namespace Student_Management
{
    partial class Course
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Course_GridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_coursecode = new System.Windows.Forms.TextBox();
            this.txt_years = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Course_GridView)).BeginInit();
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
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(344, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "COURSE";
            // 
            // Course_GridView
            // 
            this.Course_GridView.AllowUserToAddRows = false;
            this.Course_GridView.AllowUserToDeleteRows = false;
            this.Course_GridView.AllowUserToResizeColumns = false;
            this.Course_GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Course_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Course_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Course_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Course_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Course_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Course_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Course_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Course_GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Course_GridView.Location = new System.Drawing.Point(12, 70);
            this.Course_GridView.Margin = new System.Windows.Forms.Padding(0);
            this.Course_GridView.Name = "Course_GridView";
            this.Course_GridView.RowHeadersVisible = false;
            this.Course_GridView.RowHeadersWidth = 10;
            this.Course_GridView.RowTemplate.Height = 75;
            this.Course_GridView.Size = new System.Drawing.Size(855, 552);
            this.Course_GridView.TabIndex = 23;
            this.Course_GridView.Click += new System.EventHandler(this.Course_GridView_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.txt_coursecode);
            this.panel2.Controls.Add(this.txt_years);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_course);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 625);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 117);
            this.panel2.TabIndex = 34;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.Purple;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(703, 65);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 49);
            this.btn_Add.TabIndex = 21;
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
            this.btn_Clear.Location = new System.Drawing.Point(553, 65);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(144, 49);
            this.btn_Clear.TabIndex = 20;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_coursecode
            // 
            this.txt_coursecode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_coursecode.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursecode.Location = new System.Drawing.Point(151, 83);
            this.txt_coursecode.Name = "txt_coursecode";
            this.txt_coursecode.Size = new System.Drawing.Size(97, 32);
            this.txt_coursecode.TabIndex = 40;
            // 
            // txt_years
            // 
            this.txt_years.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_years.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_years.Location = new System.Drawing.Point(345, 84);
            this.txt_years.Name = "txt_years";
            this.txt_years.Size = new System.Drawing.Size(97, 32);
            this.txt_years.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(268, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Years:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Course Code:";
            // 
            // txt_course
            // 
            this.txt_course.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_course.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course.Location = new System.Drawing.Point(3, 40);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(439, 32);
            this.txt_course.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(2, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Course:";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(877, 754);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Course_GridView);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Course_GridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Course_GridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_coursecode;
        private System.Windows.Forms.TextBox txt_years;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.Label label2;
    }
}