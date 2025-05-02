using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT_Helpdesk
{
    public partial class CreateTicketForm : Form
    {
        private int userId;

        public CreateTicketForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void CreateTicketForm_Load(object sender, EventArgs e)
        {
            // Optional: preload dropdowns
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connString = "Server=127.0.0.1; Database=company_helpdesk; User=root; Password=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO tickets 
                        (user_id, title, description, category, priority, department, status, created_at, updated_at) 
                        VALUES 
                        (@user_id, @title, @description, @category, @priority, @department, 'Open', @created_at, @updated_at)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        DateTime now = DateTime.Now;

                        cmd.Parameters.AddWithValue("@user_id", this.userId);
                        cmd.Parameters.AddWithValue("@title", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@priority", cmbPriority.Text);
                        cmd.Parameters.AddWithValue("@department", cmbDepartment.Text);
                        cmd.Parameters.AddWithValue("@created_at", now);
                        cmd.Parameters.AddWithValue("@updated_at", now);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ticket submitted successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
