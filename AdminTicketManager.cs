﻿using System;
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
        private string userId; // CHANGED from int to string
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";

        public string NewDescription => txtDescription.Text.Trim();
        public int SelectedAdminId => Convert.ToInt32(comboBoxAdmins.SelectedValue);

        public AdminTicketManager(int ticketId, string userId, bool viewOnly = false) // CHANGED from int to string
        {
            InitializeComponent();
            pnlResolvedRemarksPrev.Visible = false;
            dateTimeUntilOnHold.Format = DateTimePickerFormat.Custom;
            dateTimeUntilOnHold.CustomFormat = "yyyy-MM-dd HH:mm";
            btnShowHideResolved.Text = "Show";
            LoadAdmins();
            this.ticketId = ticketId;
            this.userId = userId; // assignment remains
            this.AutoScaleMode = AutoScaleMode.Dpi;
            pnlReassignBG.Visible = false;

            btnShowReassign.Click += (s, e) => pnlReassignBG.Visible = true;
            btnCancelReassign.Click += (s, e) => pnlReassignBG.Visible = false;
            btnAcceptTicket.Click += btnAcceptTicket_Click;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            btnShowHideResolved.Click += btnShowHideResolved_Click;
            this.MouseDown += AdminTicketManager_MouseDown;
            pnlOnHold.Visible = false;
            LoadTicketInfo();
            /*if (viewOnly)
            {
                DisableAllControls();
            }*/
        }
        /*private void DisableAllControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && (btn.Text == "Close" || btn == btnShowHideResolved))
                    continue;
                ctrl.Enabled = false;
            }
        }*/


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
        private void AdminTicketManager_MouseDown(object sender, MouseEventArgs e)
        {
            if (pnlOnHold.Visible)
            {
                // Convert mouse position to panel's client coordinates
                Point panelPoint = pnlOnHold.PointToClient(this.PointToScreen(e.Location));
                if (!pnlOnHold.ClientRectangle.Contains(panelPoint))
                {
                    pnlOnHold.Visible = false;
                }
            }
        }


        private void reassignBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxAdmins.SelectedValue == null || string.IsNullOrWhiteSpace(comboBoxAdmins.SelectedValue.ToString()))
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
                    string SelectedAdminId = comboBoxAdmins.SelectedValue.ToString();
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
                        if (reader["user_extra_remarks"] != DBNull.Value)
                            txtExtraRemarks.Text = reader["user_extra_remarks"].ToString();
                        else
                            txtExtraRemarks.Text = "";

                        string status = reader["status"].ToString();
                        //closeTicketButton.Enabled = status.Equals("completed", StringComparison.OrdinalIgnoreCase);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ticket info: " + ex.Message);
                }
            }
            LoadProgressRemarks();
            LoadResolvedRemarks();
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
                pnlOnHold.Visible = false;
                btnPostOnHold.Enabled = false; //On Hold post disable
            }
            else if (selectedLower == "resolved")
            {
                txtProgRemarks.Enabled = false;
                btnProgRemarkPost.Enabled = false;
                txtResolveRemarks.Enabled = true;
                btnResolvePost.Enabled = true;
                pnlOnHold.Visible = false;
                btnPostOnHold.Enabled = false; //On Hold post disable
            }
            else if (selectedLower == "on hold")
            {
                txtProgRemarks.Enabled = false;
                btnProgRemarkPost.Enabled = false;
                txtResolveRemarks.Enabled = false;
                btnResolvePost.Enabled = false;
                pnlOnHold.Visible = true;
                btnPostOnHold.Enabled = true;
            }
            else
            {
                txtProgRemarks.Enabled = false;
                btnProgRemarkPost.Enabled = false;
                txtResolveRemarks.Enabled = false;
                btnResolvePost.Enabled = false;
                pnlOnHold.Visible = false;
                btnPostOnHold.Enabled = false; //On Hold post disable
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

        private void btnResolvePost_Click(object sender, EventArgs e)
        {
            string resolveRemark = txtResolveRemarks.Text.Trim();
            if (string.IsNullOrEmpty(resolveRemark))
            {
                MessageBox.Show("Please enter a resolve remark before posting.");
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE tickets SET resolve_remarks = @remark, status = 'Resolved' WHERE ticket_id = @ticketId";
                using (var cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@remark", resolveRemark);
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Resolve remark posted and ticket marked as Resolved.");
            txtResolveRemarks.Clear();
            LoadTicketInfo();
        }

        private void LoadProgressRemarks()
        {
            string query = "SELECT * FROM ticket_progress_remarks WHERE ticket_id = @ticketId";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            for (int i = 1; i <= 6; i++)
                            {
                                var txtRemark = Controls.Find($"txtRemark{i}", true).FirstOrDefault() as TextBox;
                                var timeDate = Controls.Find($"timeDate{i}", true).FirstOrDefault() as Label;
                                string remark = reader[$"remark{i}"] == DBNull.Value ? "" : reader[$"remark{i}"].ToString();
                                string dateCol = $"remark{i}_created_at";
                                string dateText = reader[dateCol] != DBNull.Value
                                    ? Convert.ToDateTime(reader[dateCol]).ToString("g")
                                    : "";
                                if (txtRemark != null) txtRemark.Text = remark;
                                if (timeDate != null) timeDate.Text = dateText;
                            }
                        }
                        else
                        {
                            for (int i = 1; i <= 6; i++)
                            {
                                var txtRemark = Controls.Find($"txtRemark{i}", true).FirstOrDefault() as TextBox;
                                var timeDate = Controls.Find($"timeDate{i}", true).FirstOrDefault() as Label;
                                if (txtRemark != null) txtRemark.Text = "";
                                if (timeDate != null) timeDate.Text = "";
                            }
                        }
                    }
                }
            }
        }
        private void LoadResolvedRemarks()
        {
            string query = "SELECT resolve_remarks FROM tickets WHERE ticket_id = @ticketId";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["resolve_remarks"] == DBNull.Value ? "" : reader["resolve_remarks"].ToString();
                        }
                        else
                        {
                            textBox1.Text = "";
                        }
                    }
                }
            }
        }
        private void btnShowHideResolved_Click(object sender, EventArgs e)
        {
            pnlResolvedRemarksPrev.Visible = !pnlResolvedRemarksPrev.Visible;
            btnShowHideResolved.Text = pnlResolvedRemarksPrev.Visible ? "Hide" : "Show";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            for (int i = 1; i <= 6; i++)
            {
                var txtRemark = Controls.Find($"txtRemark{i}", true).FirstOrDefault() as TextBox;
                if (txtRemark != null)
                {
                    txtRemark.Clear();
                }
                var timeDate = Controls.Find($"timeDate{i}", true).FirstOrDefault() as Label;
                if (timeDate != null)
                {
                    timeDate.Text = "";
                }
            }

            // Clear the remarks in the database
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = @"
            UPDATE ticket_progress_remarks
            SET
                remark1 = NULL, remark1_created_at = NULL,
                remark2 = NULL, remark2_created_at = NULL,
                remark3 = NULL, remark3_created_at = NULL,
                remark4 = NULL, remark4_created_at = NULL,
                remark5 = NULL, remark5_created_at = NULL,
                remark6 = NULL, remark6_created_at = NULL
            WHERE ticket_id = @ticketId AND user_id = @userId";
                using (var cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("All progress remarks have been cleared.");
        }

        private void btnPostOnHold_Click(object sender, EventArgs e)
        {
            string onHoldReason = txtBoxOnHold.Text.Trim();
            DateTime onHoldUntil = dateTimeUntilOnHold.Value; // Assuming you have a DateTimePicker named dtpOnHoldUntil

            if (string.IsNullOrEmpty(onHoldReason))
            {
                MessageBox.Show("Please enter a reason for putting the ticket on hold.");
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE tickets SET status = 'On Hold', on_hold_reason = @reason, on_hold_until = @until WHERE ticket_id = @ticketId";
                using (var cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@reason", onHoldReason);
                    cmd.Parameters.AddWithValue("@until", onHoldUntil);
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Ticket set to On Hold.");
            pnlOnHold.Visible = false;
            LoadTicketInfo();
        }


        /*private void closeTicketButton_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string update = "UPDATE tickets SET status = 'closed', completed_at = NOW() WHERE ticket_id = @ticketId";
                var cmd = new MySqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@ticketId", ticketId);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Ticket closed.");
            LoadTicketInfo();
        }*/
    }
}
