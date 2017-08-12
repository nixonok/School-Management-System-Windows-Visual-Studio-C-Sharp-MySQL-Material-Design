using System;
using MaterialSkin.Controls;
using MaterialSkin;
namespace SMS_PC
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.login_username_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.login_password_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // login_username_textbox
            // 
            this.login_username_textbox.Depth = 0;
            this.login_username_textbox.Hint = "username";
            this.login_username_textbox.Location = new System.Drawing.Point(154, 225);
            this.login_username_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_username_textbox.Name = "login_username_textbox";
            this.login_username_textbox.Padding = new System.Windows.Forms.Padding(5);
            this.login_username_textbox.PasswordChar = '\0';
            this.login_username_textbox.SelectedText = "";
            this.login_username_textbox.SelectionLength = 0;
            this.login_username_textbox.SelectionStart = 0;
            this.login_username_textbox.Size = new System.Drawing.Size(258, 23);
            this.login_username_textbox.TabIndex = 0;
            this.login_username_textbox.TabStop = false;
            this.login_username_textbox.UseSystemPasswordChar = false;
            // 
            // login_password_textbox
            // 
            this.login_password_textbox.Depth = 0;
            this.login_password_textbox.Hint = "password";
            this.login_password_textbox.Location = new System.Drawing.Point(154, 275);
            this.login_password_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_password_textbox.Name = "login_password_textbox";
            this.login_password_textbox.PasswordChar = '\0';
            this.login_password_textbox.SelectedText = "";
            this.login_password_textbox.SelectionLength = 0;
            this.login_password_textbox.SelectionStart = 0;
            this.login_password_textbox.Size = new System.Drawing.Size(258, 23);
            this.login_password_textbox.TabIndex = 1;
            this.login_password_textbox.TabStop = false;
            this.login_password_textbox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // login_button
            // 
            this.login_button.Depth = 0;
            this.login_button.Location = new System.Drawing.Point(378, 343);
            this.login_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_button.Name = "login_button";
            this.login_button.Primary = true;
            this.login_button.Size = new System.Drawing.Size(99, 50);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(107, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(107, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 449);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_password_textbox);
            this.Controls.Add(this.login_username_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authenticaton Area";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private MaterialSingleLineTextField login_username_textbox;
        private MaterialSingleLineTextField login_password_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialRaisedButton login_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

