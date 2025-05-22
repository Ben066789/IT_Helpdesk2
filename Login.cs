using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace IT_Helpdesk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosed += LoginClosed;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private string serverConnect()
        {
            return "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT userID, role, account_status FROM accounts WHERE username = @username AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(serverConnect()))
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Text.Trim());

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string accountStatus = reader["account_status"].ToString().ToLower();

                        if (accountStatus == "deactivated")
                        {
                            MessageBox.Show("This account has been deactivated. Please contact an administrator.");
                            return;
                        }

                        int userId = Convert.ToInt32(reader["userID"]);
                        string role = reader["role"].ToString().ToLower();

                        this.Hide();

                        if (role == "admin")
                        {
                            AdminDashboard adminForm = new AdminDashboard(username.Text, userId);
                            adminForm.Show();
                        }
                        else if (role == "user")
                        {
                            UserDashboard userForm = new UserDashboard(userId, username.Text);
                            userForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("User role not recognized.");
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoginClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
