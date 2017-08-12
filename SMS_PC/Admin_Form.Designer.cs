namespace SMS_PC
{
    partial class Admin_Form
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
            this.user_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.user_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.user_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.accessTypeComboBox = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.typeQueryTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.submitButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Depth = 0;
            this.user_name.Hint = "Name";
            this.user_name.Location = new System.Drawing.Point(119, 154);
            this.user_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.user_name.Name = "user_name";
            this.user_name.PasswordChar = '\0';
            this.user_name.SelectedText = "";
            this.user_name.SelectionLength = 0;
            this.user_name.SelectionStart = 0;
            this.user_name.Size = new System.Drawing.Size(90, 23);
            this.user_name.TabIndex = 0;
            this.user_name.UseSystemPasswordChar = false;
            // 
            // user_pass
            // 
            this.user_pass.Depth = 0;
            this.user_pass.Hint = "Pasword";
            this.user_pass.Location = new System.Drawing.Point(237, 153);
            this.user_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.user_pass.Name = "user_pass";
            this.user_pass.PasswordChar = '\0';
            this.user_pass.SelectedText = "";
            this.user_pass.SelectionLength = 0;
            this.user_pass.SelectionStart = 0;
            this.user_pass.Size = new System.Drawing.Size(100, 23);
            this.user_pass.TabIndex = 1;
            this.user_pass.UseSystemPasswordChar = false;
            // 
            // user_id
            // 
            this.user_id.Depth = 0;
            this.user_id.Hint = "id";
            this.user_id.Location = new System.Drawing.Point(513, 153);
            this.user_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.user_id.Name = "user_id";
            this.user_id.PasswordChar = '\0';
            this.user_id.SelectedText = "";
            this.user_id.SelectionLength = 0;
            this.user_id.SelectionStart = 0;
            this.user_id.Size = new System.Drawing.Size(75, 23);
            this.user_id.TabIndex = 3;
            this.user_id.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(72, 108);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Create New User";
            // 
            // accessTypeComboBox
            // 
            this.accessTypeComboBox.FormattingEnabled = true;
            this.accessTypeComboBox.ItemHeight = 13;
            this.accessTypeComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Accounts",
            "Admin"});
            this.accessTypeComboBox.Location = new System.Drawing.Point(364, 156);
            this.accessTypeComboBox.Name = "accessTypeComboBox";
            this.accessTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.accessTypeComboBox.TabIndex = 5;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(539, 209);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "GO!";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(76, 272);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Command";
            // 
            // typeQueryTextField1
            // 
            this.typeQueryTextField1.Depth = 0;
            this.typeQueryTextField1.Hint = "Type any query";
            this.typeQueryTextField1.Location = new System.Drawing.Point(119, 326);
            this.typeQueryTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.typeQueryTextField1.Name = "typeQueryTextField1";
            this.typeQueryTextField1.PasswordChar = '\0';
            this.typeQueryTextField1.SelectedText = "";
            this.typeQueryTextField1.SelectionLength = 0;
            this.typeQueryTextField1.SelectionStart = 0;
            this.typeQueryTextField1.Size = new System.Drawing.Size(469, 23);
            this.typeQueryTextField1.TabIndex = 8;
            this.typeQueryTextField1.UseSystemPasswordChar = false;
            // 
            // submitButton2
            // 
            this.submitButton2.Depth = 0;
            this.submitButton2.Location = new System.Drawing.Point(539, 383);
            this.submitButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton2.Name = "submitButton2";
            this.submitButton2.Primary = true;
            this.submitButton2.Size = new System.Drawing.Size(75, 23);
            this.submitButton2.TabIndex = 9;
            this.submitButton2.Text = "Go!";
            this.submitButton2.UseVisualStyleBackColor = true;
            this.submitButton2.Click += new System.EventHandler(this.submitButton2_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(538, 78);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton2.TabIndex = 10;
            this.materialRaisedButton2.Text = "Logout";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 454);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.submitButton2);
            this.Controls.Add(this.typeQueryTextField1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.accessTypeComboBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_name);
            this.Name = "Admin_Form";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField user_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField user_pass;
        private MaterialSkin.Controls.MaterialSingleLineTextField user_id;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox accessTypeComboBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField typeQueryTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton submitButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}