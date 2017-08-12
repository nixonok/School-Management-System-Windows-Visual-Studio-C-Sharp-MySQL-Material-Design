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
    public partial class Accounts_Form : MaterialForm
    {
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sms_database;";
        int total = 0;

        Image img;
        public Accounts_Form(string username)
        {
            InitializeComponent();

            profilePictureBox.Visible = false;
            materialLabel1.Text ="Welcome, "+ username;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private void Accounts_Form_Load(object sender, EventArgs e)
        {
            Search();
            

        }

        public void Search()
        {
            String query = "SELECT * FROM cash_received where student_id like '%" + textBox1.Text + "%'";
            String query2 = "SELECT * FROM cash_paid where EmployeeID like '%" + textBox2.Text + "%'";

            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection);

            try
            {

                MySqlDataAdapter msda = new MySqlDataAdapter();
                msda.SelectCommand = commandDatabase;
                DataTable dt = new DataTable();
                msda.Fill(dt);

                BindingSource bs = new BindingSource();


                bs.DataSource = dt;
                cashReceivedDataGridView1.DataSource = bs;
                msda.Update(dt);

                MySqlDataAdapter msda2 = new MySqlDataAdapter();
                msda2.SelectCommand = commandDatabase2;
                DataTable dt2 = new DataTable();
                msda2.Fill(dt2);

                BindingSource bs2 = new BindingSource();

                bs2.DataSource = dt2;
                cashPaidDataGridView2.DataSource = bs2;
                msda2.Update(dt2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(opf.FileName);
                addPhotoButton.Visible = false;
                materialLabel2.Visible = false;
                profilePictureBox.Image = img;
                profilePictureBox.Visible = true;
                profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string gender = "Male";
            if (maleGenderCheckBox.Checked != true)
            {
                gender = "Female";
            }
            String query = "INSERT INTO student_database(first_name, last_name, gender, address, phone, birth_date, email, parent_name, relation, parent_phone, nationality, religion, roll, photo, admisson_date, class, previous_school) VALUES ('" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "', '" + gender + "', '" + addressTextBox.Text + "', '"+ phoneTextBox.Text + "', '" + birthDateTimePicker.Text + "', '" + emainTextBox.Text + "', '" + parentNameTextBox.Text + "', '" + relationParentTextBox.Text + "', '" + parentPhoneTextBox.Text + "', '" + nationalityTextBox.Text + "', '" + religionTextBox.Text + "', '" + studentRollTextBox.Text + "', '" + img + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + classTextBox.Text + "', '" + previoudSchoolTextBox.Text+ "' ); ";

            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlConnection databaseConnection2 = new MySqlConnection(conString);

            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            databaseConnection2.Open();
            Login_Form f1 = new Login_Form();
            string pass = f1.getMD5(studentPassTextBox.Text);

            String query2 = "INSERT INTO user_data(username, pass, access_lvl, id_number) VALUES ('" + userNameTextBox.Text + "', '" + pass + "', '" + "Student" + "', '" + studentRollTextBox.Text + "');";

            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2);
            MySqlDataReader myReader2 = commandDatabase2.ExecuteReader();

            databaseConnection.Close();
            databaseConnection2.Close();

            MessageBox.Show("Successfully Completed!");
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            string gender = "Male";
            if (genderCheckBox1.Checked != true)
            {
                gender = "Female";
            }
            String query = "INSERT INTO employee_database(first_name, last_name, gender, address, phone, birthday, email, religion, employee_id, photo, join_date, designation, qualification) VALUES ('" + employeeFirstNameTextBox.Text + "', '" + employeeLastNameTextBox.Text + "', '" + gender + "', '" + addressTextField.Text + "', '" + phoneTextField1.Text + "', '" + birthDateTextField.Text + "', '" + emailTextField1.Text + "', '" + employeeReligionTextField1.Text + "', '" + employeeIdTextField.Text + "', '" + img + "', '" + joinDateTextField.Text + "', '" + designationTextField.Text + "', '" + QualificationTextField.Text + "' ); ";

            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlConnection databaseConnection2 = new MySqlConnection(conString);

            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            databaseConnection2.Open();
            Login_Form f1 = new Login_Form();
            string pass = f1.getMD5(employeePassTextField.Text);

            string access_lvl = designationTextField.Text == "Staff" ? "Staff" : "Teacher";

            String query2 = "INSERT INTO user_data(username, pass, access_lvl, id_number) VALUES ('" + employeeUserNameTextField.Text + "', '" + pass + "', '" + access_lvl + "', '" + employeeIdTextField.Text + "');";

            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2);
            MySqlDataReader myReader2 = commandDatabase2.ExecuteReader();

            databaseConnection.Close();
            databaseConnection2.Close();

            MessageBox.Show("Successfully Completed!");
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(opf.FileName);
                pictureBox2.Image = img;
                
            }
        }

        private void empIdTextField1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string query = "Select * from employee_database where employee_id ='" + employeeIdTextBox.Text + "'";

            MySqlConnection databaseConnection = new MySqlConnection(conString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            MySqlDataReader reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {
                Byte[] Blob;

                Blob = reader["photo"] as Byte[];
                if(Blob != null)
                {
                    MemoryStream ms = new MemoryStream();

                    ms.Write(Blob, 0, Blob.Length);

                    pictureBox3.Image = Image.FromStream(ms, true);
                    empNameTextField1.Text = "" + reader["first_name"] +" "+ reader["last_name"];
                }
                
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            total = (Convert.ToInt32(empSalaryTextField1.Text) + Convert.ToInt32(empOtherTextField1.Text));
            String query = "INSERT INTO cash_paid(employee_name, EmployeeID, salary, other, for_month, date_paid, total) VALUES ('" + empNameTextField1.Text + "', '" + employeeIdTextBox.Text + "', '" + empSalaryTextField1.Text + "', '" + empOtherTextField1.Text + "', '" + forMonthTextField1.Text + "', '"+ transactionDateTextField1.Text +"', '" + total + "');";

            MySqlConnection databaseConnection = new MySqlConnection(conString);

            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            MessageBox.Show("Successfully Completed!");
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            total = (Convert.ToInt32(monthlyFeeTextField1.Text) + Convert.ToInt32(otherStudentTextField1.Text));
            String query = "INSERT INTO cash_received(student_name, student_roll, class, monthly_fees, others, for_month, total_cash, receive_date, student_id) VALUES ('" + nameTextField1.Text + "', '" + rollTextField1.Text + "', '" + classTextField1.Text + "', '" + monthlyFeeTextField1.Text + "', '" + otherStudentTextField1.Text + "', '" + payForMonthTextField1.Text + "', '" + total + "', '"+ dateReceivedTextField1.Text +"', '"+ studentIDTextField1.Text + "'); ";

            MySqlConnection databaseConnection = new MySqlConnection(conString);

            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            totalLabel.Text = "Total : " + total;

            MessageBox.Show("Successfully Completed!");
        }

        private void studentIDTextField1_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * from student_database where id ='" + studentIDTextField1.Text + "'";

            MySqlConnection databaseConnection = new MySqlConnection(conString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            MySqlDataReader reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {
                Byte[] Blob;

                Blob = reader["photo"] as Byte[];
                if (Blob != null)
                {
                    MemoryStream ms = new MemoryStream();

                    ms.Write(Blob, 0, Blob.Length);

                    pictureBox4.Image = Image.FromStream(ms, true);
                    nameTextField1.Text = "" + reader["first_name"] + " " + reader["last_name"];
                    classTextField1.Text ="" + reader["Class"];
                    rollTextField1.Text = "" + reader["Roll"];
                }

            }
        }

        private void historyPage_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Search();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Login_Form();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Login_Form();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
