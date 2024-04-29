using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System;

namespace Act4EDP
{
    public partial class LoginForm : Form
    {
        public string PlayerID { get; set; }
        private const char V = '*';
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user=root;database=valorantplayersdb; password=rachelle040403;";

        public LoginForm()
        {
            InitializeComponent();
            password.KeyDown += Password_KeyDown;
            UpdateSignInButtonState();

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            password.PasswordChar = V;
            UpdateSignInButtonState();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignIn();
            }
        }

        private void ClearFields()
        {
            Username.Text = "";
            password.Text = "";
        }

        private void SignIn()
        {
            // Perform user authentication
            string enteredUsername = this.Username.Text;
            string enteredPassword = this.password.Text;

            try
            {
                // Query the database for the user with the entered username
                string selectQuery = "SELECT * FROM players WHERE username = @username";
                using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection))
                {
                    selectCmd.Parameters.AddWithValue("@username", enteredUsername);

                    // Open the data reader
                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        // Check if the user exists
                        if (reader.Read())
                        {
                            string playerID = reader.GetString("PlayerID");
                            bool isAdmin = reader.GetBoolean("is_admin");

                            // Compare the hashed password with the entered password
                            string hashedPassword = reader.GetString("password");
                            if (enteredPassword == hashedPassword)
                            {
                                // Close the data reader
                                reader.Close();

                                // Update status of all users to 'inactive' initially
                                string updateAllQuery = "UPDATE players SET status = 'inactive'";
                                using (MySqlCommand updateAllCmd = new MySqlCommand(updateAllQuery, connection))
                                {
                                    updateAllCmd.ExecuteNonQuery();
                                }

                                // Update the status of the current user to 'active'
                                string updateQuery = "UPDATE players SET status = 'active' WHERE username = @username";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                                {
                                    updateCmd.Parameters.AddWithValue("@username", enteredUsername);
                                    updateCmd.ExecuteNonQuery();
                                }

                                // Proceed to appropriate dashboard
                                MessageBox.Show("Welcome, " + enteredUsername + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();

                                if (isAdmin)
                                {
                                    // Admin dashboard
                                    Dashboard adminDashboardForm = new Dashboard(PlayerID);
                                    adminDashboardForm.Show();
                                }
                                else
                                {
                                    // Player dashboard
                                    DashboardPlayers dashboardForm = new DashboardPlayers(playerID);
                                    dashboardForm.Username = enteredUsername;
                                    dashboardForm.WelcomeMessage = "Hello, " + enteredUsername + "!";
                                    dashboardForm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                // Display an error message to the user
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ClearFields();
                            }
                        }
                        else
                        {
                            // Display an error message to the user
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearFields();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Error occurred while querying the database, display error message
                MessageBox.Show("Database Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields(); // Clear fields upon database error
            }
        }




        private void button1_Click(object sender, System.EventArgs e)
        {
            SignIn();
        }

        private void UpdateSignInButtonState()
        {
            // Enable the sign-in button only if both username and password are not empty
            SignInBtn.Enabled = !string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(password.Text);
        }

        private void Username_TextChanged(object sender, System.EventArgs e)
        {
            UpdateSignInButtonState();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }

        private void forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FYA fyaForm = new FYA();
            fyaForm.Show();

            this.Hide();
        }

        private void AddAcct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
