using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPA_Calculator
{
    public partial class Form3 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string userpassword;

        // Change from private set to public set
        public string ReceivedUsername { get; set; }

        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            OpenLoginWindow();

            // get user details
            UserData userData = GetUserData(ReceivedUsername);

            if (userData != null)
            {
                // set username to dashboard
                string userName = userData.Name;
                label1.Text = "Welcome " + userName;
            }
            else
            {
                MessageBox.Show("Error retrieving user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenLoginWindow()
        {
            Form1 form1 = new Form1();
            form1.ControlBox = false;

            // Show the new form and wait for it to close
            DialogResult result = form1.ShowDialog(this);

            // Check if the login was successful
            if (result == DialogResult.OK)
            {
                // Retrieve the username from Form1
                ReceivedUsername = form1.Username;
            }
        }

        private UserData GetUserData(string receivedUsername)
        {
            try
            {
                connection.Open();

                // Use parameters to prevent SQL injection
                string query = "SELECT id, name, email FROM userdata WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", receivedUsername);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check if there are rows in the result set
                    if (reader.Read())
                    {
                        // Retrieve the values from the reader
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        string email = reader.GetString("email");

                        // Create and return a UserData object
                        return new UserData(id, name, email);
                    }
                    else
                    {
                        // No rows found for the given username
                        return null;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        // Create a simple UserData class to hold the retrieved data
        public class UserData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

            public UserData(int id, string name, string email)
            {
                Id = id;
                Name = name;
                Email = email;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Close the current instance of the application
            Application.Exit();

            // Start a new instance of the application
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void year1_Click(object sender, EventArgs e)
        {
            OpenFirstYearDataWindow();
        }

        private void OpenFirstYearDataWindow()
        {
            Form4 form4 = new Form4(ReceivedUsername);
            // Show the new form
            form4.Show();
        }
    }
}
