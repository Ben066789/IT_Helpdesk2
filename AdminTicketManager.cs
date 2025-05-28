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

namespace IT_Helpdesk
{
    public partial class AdminTicketManager : Form
    {
        private int ticketId;
        private int userId;
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";

        public string NewDescription => txtDescription.Text.Trim();
        public int SelectedAdminId => Convert.ToInt32(comboBoxAdmins.SelectedValue);

        public AdminTicketManager(int ticketId, int userId)
        {
            InitializeComponent();
            LoadAdmins();
            this.ticketId = ticketId;
            this.userId = userId;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Text = "Reassign Form";
            pnlReassignBG.Visible = false;

            btnShowReassign.Click += (s, e) => pnlReassignBG.Visible = true;
            btnCancelReassign.Click += (s, e) => pnlReassignBG.Visible = false;
            btnAcceptTicket.Click += btnAcceptTicket_Click;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            LoadTicketInfo();
        }

        private void LoadAdmins()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT userID, CONCAT(firstname, ' ', lastname) AS fullname FROM accounts WHERE role = 'admin' AND eeStatus = 'Available'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxAdmins.DataSource = dt;
                comboBoxAdmins.DisplayMember = "fullname";
                comboBoxAdmins.ValueMember = "userID";
            }
        }

        private void reassignBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxAdmins.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an admin to reassign the ticket to.");
                return;
            }

            if (string.IsNullOrWhiteSpace(NewDescription))
            {
                MessageBox.Show("Please provide a description for the reassignment.");
                return;
            }

            string updateQuery = "UPDATE tickets SET assigned_to = @newAdminId, note = @newDescription WHERE ticket_id = @ticketId AND status != 'closed'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@newAdminId", SelectedAdminId);
                    cmd.Parameters.AddWithValue("@newDescription", NewDescription);
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ticket reassigned and description updated successfully.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to reassign ticket. The ticket may be closed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reassigning ticket: " + ex.Message);
                }
            }
        }

        private void LoadTicketInfo()
        {
            string query = "SELECT * FROM tickets WHERE ticket_id = @ticketId";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ticketId", ticketId);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblTicketTitle.Text = reader["title"].ToString();
                        lblCategory.Text = reader["category"].ToString();
                        lblDateCreated.Text = Convert.ToDateTime(reader["created_at"]).ToString("MM/dd/yyyy hh:mm tt");
                        lblPriority.Text = reader["priority"].ToString();
                        txtbxDescription.Text = reader["description"].ToString();
                        lblStatus.Text = reader["status"].ToString();

                        txtDescription.Text = reader["description"].ToString();
                        cmbStatus.SelectedItem = reader["status"].ToString();
                        SetStatusUpdaterUI(reader["status"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ticket info: " + ex.Message);
                }
            }
        }

        private void btnAcceptTicket_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string update = "UPDATE tickets SET status = 'Assigned' WHERE ticket_id = @ticketId";
                var cmd = new MySqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@ticketId", ticketId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadTicketInfo();
            MessageBox.Show("Ticket status set to assigned.");
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbStatus.SelectedItem?.ToString() ?? "";
            lblStatus.Text = selected;

            string selectedLower = selected.ToLower();
            if (selectedLower == "in progress")
            {
                txtProgRemarks.Enabled = true;
                btnProgRemarkPost.Enabled = true;
                txtResolveRemarks.Enabled = false;
                btnResolvePost.Enabled = false;
            }
            else if (selectedLower == "resolved")
            {
                txtProgRemarks.Enabled = false;
                btnProgRemarkPost.Enabled = false;
                txtResolveRemarks.Enabled = true;
                btnResolvePost.Enabled = true;
            }
            else
            {
                txtProgRemarks.Enabled = false;
                btnProgRemarkPost.Enabled = false;
                txtResolveRemarks.Enabled = false;
                btnResolvePost.Enabled = false;
            }
        }

        private void SetStatusUpdaterUI(string status)
        {
            if (status == "on hold")
            {
                pnlProgressUpdater.Enabled = false;
            }
            else
            {
                pnlProgressUpdater.Enabled = true;
                cmbStatus_SelectedIndexChanged(null, null);
            }
        }

        private void btnProgRemarkPost_Click(object sender, EventArgs e)
        {
            if (!string.Equals(cmbStatus.SelectedItem?.ToString(), "In Progress", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You can only post progress remarks when the status is 'In Progress'.");
                return;
            }

            string remark = txtProgRemarks.Text.Trim();
            if (string.IsNullOrEmpty(remark))
            {
                MessageBox.Show("Please enter a progress remark.");
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string selectQuery = "SELECT * FROM ticket_progress_remarks WHERE ticket_id = @ticketId AND user_id = @userId";
                var selectCmd = new MySqlCommand(selectQuery, conn);
                selectCmd.Parameters.AddWithValue("@ticketId", ticketId);
                selectCmd.Parameters.AddWithValue("@userId", userId);

                using (var reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int emptyIndex = -1;
                        for (int i = 1; i <= 6; i++)
                        {
                            if (string.IsNullOrEmpty(reader[$"remark{i}"].ToString()))
                            {
                                emptyIndex = i;
                                break;
                            }
                        }
                        reader.Close();

                        if (emptyIndex == -1)
                        {
                            MessageBox.Show("You have reached the maximum number of remarks (6) for this ticket.");
                            return;
                        }

                        // Update the correct remark and timestamp column
                        string updateQuery = $"UPDATE ticket_progress_remarks SET remark{emptyIndex} = @remark, remark{emptyIndex}_created_at = @createdAt WHERE ticket_id = @ticketId AND user_id = @userId";
                        var updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@remark", remark);
                        updateCmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                        updateCmd.Parameters.AddWithValue("@ticketId", ticketId);
                        updateCmd.Parameters.AddWithValue("@userId", userId);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        reader.Close();
                        // Insert a new row with remark1 and remark1_created_at
                        string insertQuery = @"INSERT INTO ticket_progress_remarks (ticket_id, user_id, remark1, remark1_created_at)
                                               VALUES (@ticketId, @userId, @remark, @createdAt)";
                        var insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@ticketId", ticketId);
                        insertCmd.Parameters.AddWithValue("@userId", userId);
                        insertCmd.Parameters.AddWithValue("@remark", remark);
                        insertCmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                string updateStatusQuery = "UPDATE tickets SET status = 'In Progress' WHERE ticket_id = @ticketId";
                var updateStatusCmd = new MySqlCommand(updateStatusQuery, conn);
                updateStatusCmd.Parameters.AddWithValue("@ticketId", ticketId);
                updateStatusCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Progress remark posted.");
            txtProgRemarks.Clear();
            LoadTicketInfo();
        }
    }
}
