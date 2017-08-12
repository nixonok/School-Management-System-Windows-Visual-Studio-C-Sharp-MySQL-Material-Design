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
    public partial class Student_Form : MaterialForm
    {
        private int student_id = 0;
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sms_database;";
        string query = "";
        string query2 = "";
        string query3 = "";
        public Student_Form(int student_id)
        {
            InitializeComponent();
            this.student_id = student_id;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "";
            query = "Select * from student_database where id ='" + student_id + "'";
            MySqlDataReader reader = null;

            

            MySqlConnection databaseConnection = new MySqlConnection(conString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection);
            MySqlCommand commandDatabase3 = new MySqlCommand(query3, databaseConnection);
            reader = commandDatabase.ExecuteReader();

            try
            {
                

                while (reader.Read())
                {
                    
                    studentWelcomeText.Text = "Welcome, "+ (string)reader["First_Name"];
                    student_name.Text = "" + (string)reader["First_Name"] + " " + (string)reader["Last_Name"];
                    student_email.Text = "" + (string)reader["Email"];
                    student_phone.Text = "" + (string)reader["Phone"];
                    student_address.Text = "" + (string)reader["Address"];
                    student_admission_date.Text = "Admission Date : " + Convert.ToString( reader["admisson_date"]);
                    student_roll.Text = "Roll : " + Convert.ToString(reader["Roll"]);
                    student_class.Text = "Class : " + Convert.ToString(reader["Class"]);
                    guardian_number.Text = "Guardian : " + (string)reader["parent_Phone"];
                    query = "Select * from class_" + Convert.ToString(reader["Class"]) + "_routine";
                    query2 = "Select * from class_" + Convert.ToString(reader["Class"]) + "_roll_" + Convert.ToString(reader["Roll"] + "_result_final");
                    query3 = "Select Sum(Total)FROM class_" + Convert.ToString(reader["Class"]) + "_roll_" + Convert.ToString(reader["Roll"] + "_result_final");

                    Byte[] Blob;

                    Blob = reader["photo"] as Byte[];
                    if (Blob != null)
                    {
                        MemoryStream ms = new MemoryStream();

                        ms.Write(Blob, 0, Blob.Length);

                        studentProfilePicture.Image = Image.FromStream(ms, true);

                    }

                }



                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase2 = new MySqlCommand(query2, databaseConnection);
            commandDatabase3 = new MySqlCommand(query3, databaseConnection);
            // Creating datatable to store class routine
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            // Grabbing and Showing Data to Grid Data view
            try
            {
                databaseConnection.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter();
                msda.SelectCommand = commandDatabase;
                msda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                routineDataGridView.DataSource = dt;

                MySqlDataAdapter msda2 = new MySqlDataAdapter();
                msda2.SelectCommand = commandDatabase2;
                msda2.Fill(dt2);
                BindingSource bs2 = new BindingSource();
                bs2.DataSource = dt2;
                resultDataGridView.DataSource = dt2;

                Decimal total = (Decimal) commandDatabase3.ExecuteScalar();
                resultSummary.Text = "Total Marks : "+total+", GPA : "+ String.Format("{0:0.00}", ((((total / 9) / 10) + 2) / 2));
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


            query = "SELECT * FROM cash_received where student_id like '%" + student_id + "%'";

            MySqlConnection databaseConnection5 = new MySqlConnection(conString);
            MySqlCommand commandDatabase5 = new MySqlCommand(query, databaseConnection5);

            try
            {

                MySqlDataAdapter msda = new MySqlDataAdapter();
                msda.SelectCommand = commandDatabase5;
                DataTable dt5 = new DataTable();
                msda.Fill(dt5);

                BindingSource bs5 = new BindingSource();


                bs5.DataSource = dt5;
                dataGridView1.DataSource = bs5;
                msda.Update(dt5);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Login_Form();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void student_name_Click(object sender, EventArgs e)
        {

        }
    }
}
