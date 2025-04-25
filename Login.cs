using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        //everything else in form
        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM accounts WHERE username = @username AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(serverConnect()))
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();

                        this.Hide();

                        if (role == "admin")
                        {
                            AdminDashboard adminForm = new AdminDashboard();
                            adminForm.Show();
                        }
                        else if (role == "user")
                        {
                            UserDashboard userForm = new UserDashboard();
                            userForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("User Not Found");
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
