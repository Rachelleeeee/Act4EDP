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
    public partial class DashboardPlayers : Form
    {
        private string PlayerID;
        private MySqlConnection connection;
        public DashboardPlayers(string playerID)
        {
            InitializeComponent();
            PlayerID = playerID;

            this.StartPosition = FormStartPosition.CenterScreen;

            string connectionString = "server=localhost;user=root;database=valorantplayersdb;password=rachelle040403;";
            connection = new MySqlConnection(connectionString);

            SetPlayerRank();
        }

        private void SetPlayerRank()
        {
            string rankQuery = "SELECT player_rank FROM players WHERE PlayerID = @PlayerID";

            try
            {
                connection.Open();
                MySqlCommand rankCommand = new MySqlCommand(rankQuery, connection);
                rankCommand.Parameters.AddWithValue("@PlayerID", PlayerID);

                // Execute the query to fetch the rank
                object result = rankCommand.ExecuteScalar();
                if (result != null)
                {
                    Rank = result.ToString();
                }
                else
                {
                    // Handle the case when the rank is not found
                    Rank = "Unknown";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error fetching rank: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public string Username
        {
            get { return usernameTextBox.Text; }
            set { usernameTextBox.Text = value; }
        }

        public string Rank
        {
            get { return rankTextBox.Text; }
            set { rankTextBox.Text = value; }
        }
        public string WelcomeMessage
        {
            get { return welcomeTextBox.Text; }
            set { welcomeTextBox.Text = value; }
        }

        private void Dashboard__Players__Load(object sender, EventArgs e)
        {
            connection.Open();

            // Count matches for the logged-in player
            string query = "SELECT COUNT(*) FROM matches WHERE PlayerID = @PlayerID";

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlayerID", PlayerID);

                int matchCount = Convert.ToInt32(command.ExecuteScalar());
                mtchlbl.Text = matchCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            string agentQuery = "SELECT COUNT(*) FROM PlayerAgents WHERE PlayerID = @PlayerID";

            try
            {
                MySqlCommand agentCommand = new MySqlCommand(agentQuery, connection);
                agentCommand.Parameters.AddWithValue("@PlayerID", PlayerID);

                int agentCount = Convert.ToInt32(agentCommand.ExecuteScalar());
                agentlbl.Text = agentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void DshbrdLbel_Click(object sender, EventArgs e)
        {

        }

        private void matcheslbl_Click(object sender, EventArgs e)
        {
            Match matchForm = new Match();
            matchForm.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agentslbl_Click(object sender, EventArgs e)
        {

        }

        private void SgnBTN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Show the login form
            this.Close(); // Close the dashboard form
        }

        private void welcomeTextBo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rankTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agentlbl_Click(object sender, EventArgs e)
        {
             My_Agent myAgentForm = new My_Agent();
             myAgentForm.Show();
             this.Close();
        }

        private void mtchlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
