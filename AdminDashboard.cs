using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace IT_Helpdesk
{
    public partial class AdminDashboard : Form
    {
        private string currentUsername;

        // Constructor receives the logged-in username
        public AdminDashboard(string username)
        {
            InitializeComponent();
            currentUsername = username;
            this.FormClosed += AdminDashboard_FormClosed;
            this.FormClosing += AdminDashboard_FormClosing;
        }

        // Connection string method
        private string serverConnect()
        {
            return "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT firstname FROM accounts WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", currentUsername);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            lblWelcome.Text = "Welcome, " + result.ToString();
                        }
                        else
                        {
                            lblWelcome.Text = "Welcome, Admin";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching name: " + ex.Message);
                }
            }
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Ensures app completely closes
        }

        // Asks for confirmation before closing
        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
