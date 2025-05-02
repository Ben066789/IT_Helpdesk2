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
        }

        private string serverConnect()
        {
            return "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT userID, role FROM accounts WHERE username = @username AND password = @password";

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
                        int userId = Convert.ToInt32(reader["userID"]);
                        string role = reader["role"].ToString();

                        this.Hide();

                        if (role == "admin")
                        {
                            AdminDashboard adminForm = new AdminDashboard(username.Text);
                            adminForm.Show();
                        }
                        else if (role == "user")
                        {
                            UserDashboard userForm = new UserDashboard(userId);
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
    }
}
