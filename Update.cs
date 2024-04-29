using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act4EDP
{
    public partial class UpdateProf : Form
    {
        public string PlayerID { get; set; }
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user=root;database=valorantplayersdb;password=rachelle040403;";
        public UpdateProf()
        {
            InitializeComponent();
            // Initialize MySQL connection
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UpdateUN_Click(object sender, EventArgs e)
        {
            string newUsername = usernamebox.Text;
            string newEmail = emailbox.Text;
        }

        private void UpUNtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateEmail_Click(object sender, EventArgs e)
        {

        }

        private void UpEmailxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            // Get new username and email from textboxes
            string newUsername = usernamebox.Text;
            string newEmail = emailbox.Text;

            // Get the PlayerID of the currently logged-in player (replace this with your actual logic)
            int loggedInPlayerID = GetLoggedInPlayerID();

            // Update username and email for the logged-in player
            UpdateUserInfo(newUsername, newEmail, loggedInPlayerID);

            Dashboard dashboard = new Dashboard(PlayerID);
            dashboard.Show();

            this.Hide();
        }

        private void UpdateUserInfo(string newUsername, string newEmail, int loggedInPlayerID)
        {
            string query = "UPDATE players SET username = @newUsername, email = @newEmail WHERE PlayerID = @PlayerID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@newUsername", newUsername);
            command.Parameters.AddWithValue("@newEmail", newEmail);
            command.Parameters.AddWithValue("@PlayerID", loggedInPlayerID);

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open(); // Ensure connection is open before executing command

                command.ExecuteNonQuery();
                MessageBox.Show("User information updated successfully!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Ensure connection is closed after execution
            }
        }

        // Example method to get the PlayerID of the logged-in player (replace this with your actual logic)
        private int GetLoggedInPlayerID()
        {
            // Example: Retrieve the PlayerID from session, cookie, or any other authentication mechanism
            // For the sake of demonstration, returning a hardcoded value 1
            return 1;
        }


        private void UpdateProf_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close(); // Close connection when the form is closed
        }
    }

}

