using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string userpassword;

        // Add a property to get the username value
        public string Username { get; private set; }

        public Form1()
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
            string username = uname.Text;
            string password = upassword.Text;

            if (CheckLogin(username, password))
            {
                // Set the username property
                Username = username;

                // Login successful, perform actions here
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckLogin(string username, string password)
        {
            try
            {
                connection.Open();

                // Use parameters to prevent SQL injection
                string query = "SELECT * FROM userdata WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenRegisterWindow();
        }

        private void OpenRegisterWindow()
        {
            Form2 form2 = new Form2();
            // Show the new form
            form2.Show();
        }
    }
}