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
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            string oldpass = this.oldpass.Text;
            string newpass = this.passnew.Text;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnString = "server=127.0.0.1;user=root;password=rachelle040403;database=valorantplayersdb;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnString);
                conn.Open();

                string sql = "UPDATE players SET password = @newpass WHERE password = @oldpass";

                MySqlCommand command = new MySqlCommand(sql, conn);
                {
                    command.Parameters.AddWithValue("@oldpass", oldpass);
                    command.Parameters.AddWithValue("@newpass", newpass);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password Changed Successfully");
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password change failed. Please ensure your old password is correct.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
