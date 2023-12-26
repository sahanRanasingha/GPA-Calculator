using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPA_Calculator
{
    public partial class Form2 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string userpassword;

        public Form2()
        {
            InitializeComponent();

            // Initialize database connection parameters
            server = "127.0.0.1";
            database = "gpa_calculator";
            uid = "root";
            userpassword = "";

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={userpassword};";
            connection = new MySqlConnection(connectionString);
        }

        private void formlogin_Click(object sender, EventArgs e)
        {
            string input_name = regname.Text;
            string input_username = regusername.Text;
            string input_password = regpassword.Text; // Use plain text password
            string input_email = regemail.Text;

            if (string.IsNullOrEmpty(input_name) || string.IsNullOrEmpty(input_username)|| string.IsNullOrEmpty(input_password)|| string.IsNullOrEmpty(input_email))
            {
                MessageBox.Show("Some details are missing", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Insert user data into the database
            InsertUserData(input_name, input_username, input_password, input_email);

            // Additional actions after registration if needed
            MessageBox.Show("Registration successful!");
            Close();
        }

        private void InsertUserData(string name, string username, string password, string email)
        {
            try
            {
                connection.Open();

                // Use parameters to prevent SQL injection
                string query = "INSERT INTO userdata (name, username, password, email) VALUES (@name, @username, @password, @email)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // Use plain text password
                cmd.Parameters.AddWithValue("@email", email);

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
    }
}
