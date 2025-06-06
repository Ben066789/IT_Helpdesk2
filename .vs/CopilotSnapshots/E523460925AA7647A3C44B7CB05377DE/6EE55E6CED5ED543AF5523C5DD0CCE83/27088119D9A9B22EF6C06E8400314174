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
            this.AutoScaleMode = AutoScaleMode.Dpi;
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

                    // Step 1: Find least-loaded admin
                    int assignedAdminId = -1;
                    string assignedAdminName = "Unassigned";

                    string getAdminQuery = @"
                    SELECT userID FROM accounts
                    WHERE role = 'admin' AND eeStatus = 'Available'
                    ORDER BY (SELECT COUNT(*) FROM tickets 
                    WHERE assigned_to = accounts.userID AND status = 'Open') ASC LIMIT 1;";

                    using (MySqlCommand adminCmd = new MySqlCommand(getAdminQuery, conn))
                    {
                        var result = adminCmd.ExecuteScalar();
                        if (result != null)
                        {
                            assignedAdminId = Convert.ToInt32(result);
                        }
                    }

                    // Step 2: Insert ticket
                    string insertQuery = @"
                    INSERT INTO tickets 
                    (user_id, title, description, category, priority, department, status, created_at, updated_at, assigned_to) 
                    VALUES 
                    (@user_id, @title, @description, @category, @priority, @department, 'Open', @created_at, @updated_at, @assigned_to)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
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
                        cmd.Parameters.AddWithValue("@assigned_to", assignedAdminId);

                        cmd.ExecuteNonQuery();
                    }

                    // Step 3: Fetch full name of assigned admin
                    if (assignedAdminId != -1)
                    {
                        string nameQuery = @"
                SELECT CONCAT(firstname, ' ', lastname) AS fullname 
                FROM accounts 
                WHERE userID = @adminId";

                        using (MySqlCommand nameCmd = new MySqlCommand(nameQuery, conn))
                        {
                            nameCmd.Parameters.AddWithValue("@adminId", assignedAdminId);
                            object result = nameCmd.ExecuteScalar();
                            if (result != null)
                            {
                                assignedAdminName = result.ToString();
                            }
                        }
                    }

                    MessageBox.Show("Ticket successfully submitted");
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
