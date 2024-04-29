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

namespace Act4EDP
{
    public partial class User : Form
    {
        public string PlayerID { get; set; }
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable usersTable;

        private string connectionString = "server=localhost;user=root;database=valorantplayersdb;password=rachelle040403;";
        public User()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FYA_Closing_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(PlayerID);
            dashboardForm.Show();

            this.Hide();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchAccounts(SearchBox.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void UpdateAccountProfile(string email, string username, bool active)
        {
            
        }

        private void PopulateDataGridView()
        {
            try
            {
                // Open a connection to the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Create a new data adapter to fetch data from the players table
                    adapter = new MySqlDataAdapter("SELECT * FROM players", connection);

                    // Create a new DataTable to store the fetched data
                    usersTable = new DataTable();
                    adapter.Fill(usersTable);
                    PlayerData.DataSource = usersTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable originalDataTable;

        private void SearchAccounts(string searchTerm)
        {
            if (usersTable == null)
            {
                MessageBox.Show("No data to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                PlayerData.DataSource = originalDataTable;
                return;
            }

            if (originalDataTable == null)
            {
                originalDataTable = (DataTable)PlayerData.DataSource;
            }

            // Create a DataView to filter the data
            DataView dataView = new DataView(originalDataTable);
            dataView.RowFilter = $"username LIKE '%{searchTerm}%' OR email LIKE '%{searchTerm}%'";

            // Bind the filtered DataView back to the DataGridView
            PlayerData.DataSource = dataView.ToTable();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of resources
            connection.Dispose();
            adapter.Dispose();
            usersTable.Dispose();
        }
        private void User_Load(object sender, EventArgs e)
        {
            // Initialize the MySqlConnection with connection string
            connection = new MySqlConnection(connectionString);

            // Initialize the MySqlDataAdapter with the select query and connection
            adapter = new MySqlDataAdapter("SELECT * FROM players", connection);

            // Create and fill a DataTable with the data from the users table
            usersTable = new DataTable();
            adapter.Fill(usersTable);

            // Bind the DataTable to the DataGridView
            PlayerData.DataSource = usersTable;

            PopulateDataGridView();
        }

        private void UserLoggedIn(string userEmail)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string updateQuery = "UPDATE players SET active = 1 WHERE email = @Email";
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", userEmail);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void UserSignedOut(string userEmail)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string updateQuery = "UPDATE players SET active = 0 WHERE email = @Email";
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", userEmail);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Event handler for user login action
        private void User_Login_Event(string userEmail)
        {
            UserLoggedIn(userEmail); // Call method to update user status as active
            PopulateDataGridView(); // Refresh DataGridView
        }

        // Event handler for user signout action
        private void User_Signout_Event(string userEmail)
        {
            UserSignedOut(userEmail); // Call method to update user status as inactive
            PopulateDataGridView(); // Refresh DataGridView
        }
    }
}
