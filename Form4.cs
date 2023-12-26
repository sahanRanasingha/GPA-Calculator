using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPA_Calculator
{
    public partial class Form4 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string userpassword;

        // Add a property to store the username value
        public string ReceivedUsername { get; private set; }

        public Form4(string receivedUsername)
        {
            InitializeComponent();

            // Initialize database connection parameters
            server = "127.0.0.1";
            database = "gpa_calculator";
            uid = "root";
            userpassword = "";

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={userpassword};";
            connection = new MySqlConnection(connectionString);

            // Set the received username
            ReceivedUsername = receivedUsername;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check comboBox
            if (!AreComboBoxesValid())
            {
                MessageBox.Show("Please select a value for all ComboBoxes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // comboBox ok, Dataset to database
            else
            {
                string username = ReceivedUsername;

                string pst11201 = comboBox1.Text;
                string pst11202 = comboBox2.Text;
                string pst11203 = comboBox3.Text;
                string pst11204 = comboBox4.Text;
                string pst11205 = comboBox5.Text;
                string pst11206 = comboBox6.Text;
                string pst11207 = comboBox7.Text;
                string pst11208 = comboBox8.Text;
                string pst11209 = comboBox9.Text;
                string pst11210 = comboBox11.Text;

                string pst12102 = comboBox10.Text;
                string pst12103 = comboBox12.Text;
                string pst12104 = comboBox13.Text;
                string pst12205 = comboBox14.Text;
                string pst12206 = comboBox15.Text;
                string pst12107 = comboBox16.Text;
                string pst12108 = comboBox17.Text;
                string pst12209 = comboBox18.Text;
                string pst12110 = comboBox19.Text;
                string pst12211 = comboBox20.Text;
                string pst12201 = comboBox21.Text;

                // insert data to database
                InsertSubjectData(username, pst11201, pst11202, pst11203, pst11204, pst11205, pst11206, pst11207, pst11208, pst11209, pst11210,
                   pst12102, pst12103, pst12104, pst12205, pst12206, pst12107, pst12108, pst12209, pst12110, pst12211,
                   pst12201);

                // Additional actions after registration if needed
                MessageBox.Show("GPA Calculate successful!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();
            }
        }

        private bool AreComboBoxesValid()
        {
            // Iterate through ComboBox controls
            for (int i = 1; i <= 21; i++)
            {
                ComboBox comboBox = Controls.Find($"comboBox{i}", true).FirstOrDefault() as ComboBox;

                // Check if the ComboBox is found and its selected value is null or empty
                if (comboBox != null && string.IsNullOrEmpty(comboBox.Text))
                {
                    return false; // At least one ComboBox has a null or empty value
                }
            }

            return true; // All ComboBoxes have a non-null and non-empty value
        }

        private void InsertSubjectData(string username, string pst11201, string pst11202, string pst11203, string pst11204, string pst11205,
                                   string pst11206, string pst11207, string pst11208, string pst11209, string pst11210,
                                   string pst12102, string pst12103, string pst12104, string pst12205, string pst12206,
                                   string pst12107, string pst12108, string pst12209, string pst12110, string pst12211,
                                   string pst12201)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO first_year_subject (username,pst11201, pst11202, pst11203, pst11204, pst11205, pst11206, " +
                               "pst11207, pst11208, pst11209, pst11210, pst12102, pst12103, pst12104, pst12205, pst12206, " +
                               "pst12107, pst12108, pst12209, pst12110, pst12211, pst12201) " +
                               "VALUES (@username,@pst11201, @pst11202, @pst11203, @pst11204, @pst11205, @pst11206, @pst11207, @pst11208, " +
                               "@pst11209, @pst11210, @pst12102, @pst12103, @pst12104, @pst12205, @pst12206, @pst12107, " +
                               "@pst12108, @pst12209, @pst12110, @pst12211, @pst12201)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pst11201", pst11201);
                cmd.Parameters.AddWithValue("@pst11202", pst11202);
                cmd.Parameters.AddWithValue("@pst11203", pst11203);
                cmd.Parameters.AddWithValue("@pst11204", pst11204);
                cmd.Parameters.AddWithValue("@pst11205", pst11205);
                cmd.Parameters.AddWithValue("@pst11206", pst11206);
                cmd.Parameters.AddWithValue("@pst11207", pst11207);
                cmd.Parameters.AddWithValue("@pst11208", pst11208);
                cmd.Parameters.AddWithValue("@pst11209", pst11209);
                cmd.Parameters.AddWithValue("@pst11210", pst11210);
                cmd.Parameters.AddWithValue("@pst12102", pst12102);
                cmd.Parameters.AddWithValue("@pst12103", pst12103);
                cmd.Parameters.AddWithValue("@pst12104", pst12104);
                cmd.Parameters.AddWithValue("@pst12205", pst12205);
                cmd.Parameters.AddWithValue("@pst12206", pst12206);
                cmd.Parameters.AddWithValue("@pst12107", pst12107);
                cmd.Parameters.AddWithValue("@pst12108", pst12108);
                cmd.Parameters.AddWithValue("@pst12209", pst12209);
                cmd.Parameters.AddWithValue("@pst12110", pst12110);
                cmd.Parameters.AddWithValue("@pst12211", pst12211);
                cmd.Parameters.AddWithValue("@pst12201", pst12201);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
