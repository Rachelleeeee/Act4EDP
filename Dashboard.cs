using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;

namespace Act4EDP
{
    public partial class Dashboard : Form
    {
        private MySqlConnection connection;
        private string PlayerID;

        public Dashboard(string playerID)
        {
            InitializeComponent();
            PlayerID = playerID;
            this.StartPosition = FormStartPosition.CenterScreen;

            string connectionString = "server=localhost;user=root;database=valorantplayersdb;password=rachelle040403;";
            connection = new MySqlConnection(connectionString);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show(); // Show the login form
            this.Close(); // Close the dashboard form
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            connection.Open();

            // Count maps 
            string mapQuery = "SELECT COUNT(*) FROM Maps WHERE PlayerID = @PlayerID";

            try
            {
                MySqlCommand mapCommand = new MySqlCommand(mapQuery, connection);
                mapCommand.Parameters.AddWithValue("@PlayerID", 16); 

                int mapCount = Convert.ToInt32(mapCommand.ExecuteScalar());
                tmlbl.Text = mapCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting maps: " + ex.Message);
            }


            // Count weapons 
            string weaponQuery = "SELECT COUNT(*) FROM Weapons WHERE PlayerID = @PlayerID";

            try
            {
                MySqlCommand weaponCommand = new MySqlCommand(weaponQuery, connection);
                weaponCommand.Parameters.AddWithValue("@PlayerID", 16); 

                int weaponCount = Convert.ToInt32(weaponCommand.ExecuteScalar());
                twlbl.Text = weaponCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting weapons: " + ex.Message);
            }

            // Count player statistics
            string statQuery = "SELECT COUNT(*) FROM PlayerStatistics";

            try
            {
                MySqlCommand statCommand = new MySqlCommand(statQuery, connection);

                int statCount = Convert.ToInt32(statCommand.ExecuteScalar());
                numberSOlbl.Text = statCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting player statistics: " + ex.Message);
            }
        }




        private void PlayerUN_Click(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maplbl_Click(object sender, EventArgs e)
        {
            Map mapForm = new Map();
            mapForm.Show();

            this.Hide();
        }

        private void userlbl_Click(object sender, EventArgs e)
        {

        }

        private void weaponlbl_Click(object sender, EventArgs e)
        {
            Weapon weaponForm = new Weapon();
            weaponForm.Show();

            this.Hide();
        }

        private void matcheslbl_Click(object sender, EventArgs e)
        {
            Match matchForm = new Match();
            matchForm.Show();

            this.Hide();
        }

        private void dashboardlbl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numberSOlbl_Click(object sender, EventArgs e)
        {

        }

        private void mtchlbl_Click(object sender, EventArgs e)
        {

        }

        private void twlbl_Click(object sender, EventArgs e)
        {

        }

        private void tmlbl_Click(object sender, EventArgs e)
        {

        }

        private void agentslbl_Click(object sender, EventArgs e)
        {
            Agents agentsForm = new Agents();
            agentsForm.Show();

            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            User userForm = new User();
            userForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UpdateProf updateProf = new UpdateProf();
            updateProf.Show();

            this.Hide();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topmaplbl_Click(object sender, EventArgs e)
        {

        }

        private void topweplbl_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            Report reportform = new Report(PlayerID);
            reportform.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
