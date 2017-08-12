using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_PC
{
    public partial class Admin_Form : MaterialForm
    {
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sms_database;";
        public Admin_Form()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Login_Form f1 = new Login_Form();
            string pass = f1.getMD5(user_pass.Text);
            String query = "INSERT INTO user_data(username, pass, access_lvl, id_number) VALUES ('" + user_name.Text + "', '" + pass + "', '" + accessTypeComboBox.Text + "', '" + user_id.Text + "');";
            

            MySqlConnection databaseConnection = new MySqlConnection(conString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            MessageBox.Show("Successfully Completed!");
        }

        private void submitButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(typeQueryTextField1.Text, databaseConnection);
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            MessageBox.Show("Successfully Completed!");
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Login_Form();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
