using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
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

namespace SMS_PC
{
    public partial class Teacher_Form : MaterialForm
    {
        int employee_id;
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sms_database;";
        public Teacher_Form(int id)
        {
            InitializeComponent();
            employee_id = id;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private void Teacher_Form_Load(object sender, EventArgs e)
        {
            string query = "";
            query = "Select * from employee_database where id ='" + employee_id + "'";
            MySqlDataReader reader = null;



            MySqlConnection databaseConnection = new MySqlConnection(conString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            reader = commandDatabase.ExecuteReader();

            try
            {


                while (reader.Read())
                {

                    teacherWelcomeText.Text = "Welcome, " + (string)reader["First_Name"] + " Sir.";
                    teacherFullName.Text = "" + (string)reader["First_Name"] + " " + (string)reader["Last_Name"];
                    teacherEmail.Text = "" + (string)reader["Email"];
                    teacherPhoneNumber.Text = "0" + reader["Phone"];
                    teacherAddressTextBox1.Text = "" + (string)reader["Address"];
                    teacherJoinDateTextBox.Text = "" + Convert.ToString(reader["join_date"]);
                    teacherQualification.Text = "" + (string)(reader["qualification"]);
                    teacherDesignation.Text = "" + (string)(reader["designation"]);

                    Byte[] Blob;

                    Blob = reader["photo"] as Byte[];
                    if (Blob != null)
                    {
                        MemoryStream ms = new MemoryStream();

                        ms.Write(Blob, 0, Blob.Length);

                        teacherPictureBox.Image = Image.FromStream(ms, true);

                    }

                }



                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            String query2 = "SELECT * FROM cash_paid where EmployeeID like '%" + employee_id + "%'";

            MySqlConnection databaseConnection2 = new MySqlConnection(conString);

            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2);

            try
            {

                MySqlDataAdapter msda = new MySqlDataAdapter();
                msda.SelectCommand = commandDatabase2;
                DataTable dt = new DataTable();
                msda.Fill(dt);

                BindingSource bs = new BindingSource();


                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                msda.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Login_Form();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
