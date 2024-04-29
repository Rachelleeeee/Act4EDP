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
    public partial class SignUpForm : Form
    {
        private string connectionString = "server=localhost;user=root;database=valorantplayersdb; password=rachelle040403;";
        public SignUpForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool IsEmailUnique(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM players WHERE email = @Email";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0;
                }
            }
        }

        private bool IsUsernameUnique(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM players WHERE username = @Username";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0;
                }
            }
        }


        private void SU_Closing_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void emaillabel_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUsername_Click(object sender, EventArgs e)
        {

        }

        private void NewUNtxtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPass_Click(object sender, EventArgs e)
        {

        }

        private void NewPasstxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string username = NewUNtxtb.Text;
            string password = NewPasstxtbx.Text;
            string birthday = birthdate.Value.ToString("yyyy-MM-dd");
            string status = "active"; // Set the default status as 'active'

            if (!IsEmailUnique(email))
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsUsernameUnique(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO players (email, username, password, birthday, status) VALUES (@Email, @Username, @Password, @Birthday, @Status)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Birthday", birthday);
                        command.Parameters.AddWithValue("@Status", status); // Provide status parameter
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Additional logic if needed
                        }
                        else
                        {
                            MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();

        }


        private void Email_Leave(object sender, EventArgs e)
        {
            string email = Email.Text;
            if (!IsEmailUnique(email))
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewUNtxtb_Leave(object sender, EventArgs e)
        {
            string username = NewUNtxtb.Text;
            if (!IsUsernameUnique(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = birthdate.Value;
            // Convert the selected date to the MySQL date format (YYYY-MM-DD)
           string birthday = selectedDate.ToString("yyyy-MM-dd");
        }
    }
}
