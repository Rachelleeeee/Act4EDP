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
    public partial class Weapon : Form
    {
        public string PlayerID { get; set; }
        public Weapon()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Matches_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DshbrdLbel_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(PlayerID);
            dashboardForm.Show();

            this.Hide();
        }

        private void matcheslbl_Click(object sender, EventArgs e)
        {
            Match matchForm = new Match();
            matchForm.Show();

            this.Hide();
        }

        private void SgnBTN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Show the login form
            this.Close(); // Close the dashboard form
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

        private void label10_Click(object sender, EventArgs e)
        {
            Report reportform = new Report(PlayerID);
            reportform.Show();

            this.Hide();
        }
    }
}
