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
    public partial class FYA : Form
    {
        private string connectionString = "server=localhost;user=root;database=valorantplayersdb; password=rachelle040403;";

        public FYA()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string email = this.email.Text;

            // Check if email exists in the database
            if (CheckEmailExists(email))
            {
                // Email exists, proceed with next steps
                MessageBox.Show("Email exists. Proceed with next steps.", "FYA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Add code to proceed to the next form or perform further actions
            }
            else
            {
                // Email does not exist, show error message
                MessageBox.Show("No existing account found for the provided email.", "FYA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM users WHERE email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = this.email.Text;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=rachelle040403;database=valorantplayersdb;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                string sql = "SELECT COUNT(*) FROM players WHERE email = @email";

                MySqlCommand command = new MySqlCommand(sql, conn);
                {
                    command.Parameters.AddWithValue("@email", email);

                    int result = Convert.ToInt32(command.ExecuteScalar());
                    if (result > 0)
                    {
                        this.Hide();
                        ResetPass resetForm = new ResetPass();
                        resetForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email. Please try again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FYA_Closing_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
