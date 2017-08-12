namespace SMS_PC
{
    partial class Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentWelcomeText = new MaterialSkin.Controls.MaterialLabel();
            this.studentProfilePicture = new System.Windows.Forms.PictureBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.student_class = new MaterialSkin.Controls.MaterialLabel();
            this.student_roll = new MaterialSkin.Controls.MaterialLabel();
            this.guardian_number = new MaterialSkin.Controls.MaterialLabel();
            this.student_admission_date = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.student_address = new MaterialSkin.Controls.MaterialLabel();
            this.student_phone = new MaterialSkin.Controls.MaterialLabel();
            this.student_email = new MaterialSkin.Controls.MaterialLabel();
            this.student_name = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.class_routine = new MaterialSkin.Controls.MaterialLabel();
            this.routineDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultSummary = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfilePicture)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routineDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // studentWelcomeText
            // 
            this.studentWelcomeText.AutoSize = true;
            this.studentWelcomeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.studentWelcomeText.Depth = 0;
            this.studentWelcomeText.Font = new System.Drawing.Font("Roboto", 11F);
            this.studentWelcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentWelcomeText.Location = new System.Drawing.Point(333, 121);
            this.studentWelcomeText.MouseState = MaterialSkin.MouseState.HOVER;
            this.studentWelcomeText.Name = "studentWelcomeText";
            this.studentWelcomeText.Size = new System.Drawing.Size(126, 19);
            this.studentWelcomeText.TabIndex = 1;
            this.studentWelcomeText.Text = "Welcome, Nissan";
            // 
            // studentProfilePicture
            // 
            this.studentProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("studentProfilePicture.Image")));
            this.studentProfilePicture.Location = new System.Drawing.Point(226, 80);
            this.studentProfilePicture.Name = "studentProfilePicture";
            this.studentProfilePicture.Size = new System.Drawing.Size(101, 92);
            this.studentProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentProfilePicture.TabIndex = 2;
            this.studentProfilePicture.TabStop = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 220);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(724, 313);
            this.materialTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.student_class);
            this.tabPage1.Controls.Add(this.student_roll);
            this.tabPage1.Controls.Add(this.guardian_number);
            this.tabPage1.Controls.Add(this.student_admission_date);
            this.tabPage1.Controls.Add(this.materialDivider1);
            this.tabPage1.Controls.Add(this.student_address);
            this.tabPage1.Controls.Add(this.student_phone);
            this.tabPage1.Controls.Add(this.student_email);
            this.tabPage1.Controls.Add(this.student_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // student_class
            // 
            this.student_class.AutoSize = true;
            this.student_class.Depth = 0;
            this.student_class.Font = new System.Drawing.Font("Roboto", 11F);
            this.student_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.student_class.Location = new System.Drawing.Point(467, 97);
            this.student_class.MouseState = MaterialSkin.MouseState.HOVER;
            this.student_class.Name = "student_class";
            this.student_class.Size = new System.Drawing.Size(75, 19);
            this.student_class.TabIndex = 8;
            this.student_class.Text = "Class : 10";
            // 
            // student_roll
            // 
            this.student_roll.AutoSize = true;
            this.student_roll.Depth = 0;
            this.student_roll.Font = new System.Drawing.Font("Roboto", 11F);
            this.student_roll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.student_roll.Location = new System.Drawing.Point(467, 68);
            this.student_roll.MouseState = MaterialSkin.MouseState.HOVER;
            this.student_roll.Name = "student_roll";
            this.student_roll.Size = new System.Drawing.Size(63, 19);
            this.student_roll.TabIndex = 7;
            this.student_roll.Text = "Roll : 14";
            // 
            // guardian_number
            // 
            this.guardian_number.AutoSize = true;
            this.guardian_number.Depth = 0;
            this.guardian_number.Font = new System.Drawing.Font("Roboto", 11F);
            this.guardian_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guardian_number.Location = new System.Drawing.Point(467, 126);
            this.guardian_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.guardian_number.Name = "guardian_number";
            this.guardian_number.Size = new System.Drawing.Size(193, 19);
            this.guardian_number.TabIndex = 6;
            this.guardian_number.Text = "Guardian : +8801914545412";
            // 
            // student_admission_date
            // 
            this.student_admission_date.AutoSize = true;
            this.student_admission_date.Depth = 0;
            this.student_admission_date.Font = new System.Drawing.Font("Roboto", 11F);
            this.student_admission_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.student_admission_date.Location = new System.Drawing.Point(437, 36);
            this.student_admission_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.student_admission_date.Name = "student_admission_date";
            this.student_admission_date.Size = new System.Drawing.Size(196, 19);
            this.student_admission_date.TabIndex = 5;
            this.student_admission_date.Text = "Admission Date: 2013-08-13";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(365, 23);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 237);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // student_address
            // 
            this.student_address.AutoSize = true;
            this.student_address.Depth = 0;
            this.student_address.Font = new System.Drawing.Font("Roboto", 11F);
            this.student_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.student_address.Location = new System.Drawing.Point(76, 126);
            this.student_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.student_address.Name = "student_address";
            this.student_address.Size = new System.Drawing.Size(158, 19);
            this.student_address.TabIndex = 3;
            this.student_address.Text = "B.K Main Road, Khulna";
            // 
            // student_phone
            // 
            this.student_phone.AutoSize = true;
            this.student_phone.Depth = 0;
            this.student_phone.Font = new System.Drawing.Font("Roboto", 11F);
            this.student_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.student_phone.Location = new System.Drawing.Point(76, 97);
            this.student_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.student_phone.Name = "student_phone";
            this.student_phone.Size = new System.Drawing.Size(122, 19);
            this.student_phone.TabIndex = 2;
            this.student_phone.Text = "+8801712310081";
            // 
            // student_email
            // 
            this.student_email.AutoSize = true;
            this.student_email.Depth = 0;
            this.student_email.Font = new System.Drawing.Font("Roboto", 11F);
            this.student_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.student_email.Location = new System.Drawing.Point(76, 68);
            this.student_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(141, 19);
            this.student_email.TabIndex = 1;
            this.student_email.Text = "aan007@gmail.com";
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Depth = 0;
            this.student_name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.ForeColor = System.Drawing.Color.Black;
            this.student_name.Location = new System.Drawing.Point(55, 36);
            this.student_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(120, 23);
            this.student_name.TabIndex = 0;
            this.student_name.Text = "Nissan Ahmed";
            this.student_name.Click += new System.EventHandler(this.student_name_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.class_routine);
            this.tabPage2.Controls.Add(this.routineDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Routine";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // class_routine
            // 
            this.class_routine.AutoSize = true;
            this.class_routine.Depth = 0;
            this.class_routine.Font = new System.Drawing.Font("Roboto", 11F);
            this.class_routine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.class_routine.Location = new System.Drawing.Point(265, 16);
            this.class_routine.MouseState = MaterialSkin.MouseState.HOVER;
            this.class_routine.Name = "class_routine";
            this.class_routine.Size = new System.Drawing.Size(148, 19);
            this.class_routine.TabIndex = 1;
            this.class_routine.Text = "Routine For Class 10";
            // 
            // routineDataGridView
            // 
            this.routineDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.routineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routineDataGridView.Location = new System.Drawing.Point(99, 48);
            this.routineDataGridView.Name = "routineDataGridView";
            this.routineDataGridView.Size = new System.Drawing.Size(529, 229);
            this.routineDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.resultSummary);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.resultDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(716, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Result";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resultSummary
            // 
            this.resultSummary.AutoSize = true;
            this.resultSummary.Depth = 0;
            this.resultSummary.Font = new System.Drawing.Font("Roboto", 11F);
            this.resultSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultSummary.Location = new System.Drawing.Point(266, 247);
            this.resultSummary.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultSummary.Name = "resultSummary";
            this.resultSummary.Size = new System.Drawing.Size(202, 19);
            this.resultSummary.TabIndex = 2;
            this.resultSummary.Text = "Total Marks : 710, GPA : 5.00";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(241, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(249, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Final Term Result : Roll 14, Class 10";
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(153, 41);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(416, 203);
            this.resultDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(716, 287);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transactions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 188);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(724, 36);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(630, 121);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Login";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 531);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.studentProfilePicture);
            this.Controls.Add(this.studentWelcomeText);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Form";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Area";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfilePicture)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routineDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel studentWelcomeText;
        private System.Windows.Forms.PictureBox studentProfilePicture;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel student_class;
        private MaterialSkin.Controls.MaterialLabel student_roll;
        private MaterialSkin.Controls.MaterialLabel guardian_number;
        private MaterialSkin.Controls.MaterialLabel student_admission_date;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel student_address;
        private MaterialSkin.Controls.MaterialLabel student_phone;
        private MaterialSkin.Controls.MaterialLabel student_email;
        private MaterialSkin.Controls.MaterialLabel student_name;
        private MaterialSkin.Controls.MaterialLabel class_routine;
        private System.Windows.Forms.DataGridView routineDataGridView;
        private MaterialSkin.Controls.MaterialLabel resultSummary;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}