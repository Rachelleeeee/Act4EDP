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

namespace Act4EDP
{
    public partial class Match : Form
    {
        public string PlayerID { get; set; }
        private string connectionString = "server=localhost;user=root;database=valorantplayersdb;password=rachelle040403;";
        public Match()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Match_Load(object sender, EventArgs e)
        {
            LoadMatchesData();
        }

        private void LoadMatchesData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL command to select all rows from 'matches' table
                    string query = "SELECT * FROM matches";

                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Create a DataTable to hold the query result
                        DataTable matchesTable = new DataTable();

                        // Load data from the query into the DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(matchesTable);
                        }

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = matchesTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading matches data: " + ex.Message);
            }
        }

        private void SgnBTN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Show the login form
            this.Close(); // Close the dashboard form
        }

        private void DshbrdLbel_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(PlayerID);
            dashboardForm.Show();

            this.Hide();
        }

        private void weaponlbl_Click(object sender, EventArgs e)
        {
            Weapon weaponForm = new Weapon();
            weaponForm.Show();

            this.Hide();
        }

        private void agentslbl_Click(object sender, EventArgs e)
        {
            Agents agentsForm = new Agents();
            agentsForm.Show();

            this.Hide();
        }

        private void maplbl_Click(object sender, EventArgs e)
        {
            Map mapForm = new Map();
            mapForm.Show();

            this.Hide();
        }

        private void PlayerList_Click(object sender, EventArgs e)
        {
            User userForm = new User();
            userForm.Show();

            this.Hide();
        }

        private void matcheslbl_Click(object sender, EventArgs e)
        {

        }

        private void reportlbl_Click(object sender, EventArgs e)
        {
            Report reportform = new Report(PlayerID);
            reportform.Show();

            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
