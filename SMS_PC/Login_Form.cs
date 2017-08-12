using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace SMS_PC
{
    public partial class Login_Form : MaterialForm
    {
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sms_database;";
        public Login_Form()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        // MD5 Hash Generator Method
        public string getMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (byte b in result)
            {
                sb.Append(result[i].ToString("x2"));
                i++;
            }

            return sb.ToString();
        }

        // login button click event
        private void login_button_Click_1(object sender, EventArgs e)
        {
            string query = "Select * from user_data where username ='" + login_username_textbox.Text + "'";
            string md = getMD5(login_password_textbox.Text);
            string hashData = "";

            try
            {
                MySqlDataReader reader = null;

                MySqlConnection databaseConnection = new MySqlConnection(conString);
                databaseConnection.Open();

                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {

                    hashData = (string)reader["pass"];

                    if (hashData == md)
                    {
                        switch ((string)reader["access_lvl"])
                        {
                            case "Student":
                                this.Hide();
                                var form2 = new Student_Form((int)reader["id_number"]);
                                form2.Closed += (s, args) => this.Close();
                                form2.Show();
                                break;

                            case "Admin":
                                this.Hide();
                                var form3 = new Admin_Form();
                                form3.Closed += (s, args) => this.Close();
                                form3.Show();
                                break;

                            case "Accounts":
                                this.Hide();
                                var form4 = new Accounts_Form((string)reader["username"]);
                                form4.Closed += (s, args) => this.Close();
                                form4.Show();
                                break;

                            case "Teacher":
                                this.Hide();
                                var form6 = new Teacher_Form((int)reader["id_number"]);
                                form6.Closed += (s, args) => this.Close();
                                form6.Show();
                                break;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid Password!  Please, Try Again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
