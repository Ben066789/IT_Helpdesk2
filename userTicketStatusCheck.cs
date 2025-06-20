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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT_Helpdesk
{
    public partial class userTicketStatusCheck : Form
    {
        private string status;
        private int ticketId;
        private string userId; // CHANGED from int to string
        private onHoverProgressRemarks hoverRemarksForm;
        private onHoverResolveRemarks hoverResolveForm;
        private onHoverOnHoldRemarks hoverOnHoldForm;

        public userTicketStatusCheck(int ticketId, string status, string userId) // CHANGED userId to string
        {
            InitializeComponent();
            this.ticketId = ticketId;
            this.status = status;
            this.userId = userId; // assignment remains
            LoadTicketStatus();
            LoadStatusBarImage();
            onHoverTrigger.MouseEnter += onHoverTrigger_MouseEnter;
            onHoverTrigger.MouseLeave += onHoverTrigger_MouseLeave;

            lblResolved.MouseEnter += lblResolved_MouseEnter;
            lblResolved.MouseLeave += lblResolved_MouseLeave;

            lblOnHold.MouseEnter += lblOnHold_MouseEnter;
            lblOnHold.MouseLeave += lblOnHold_MouseLeave;
        }
        private string serverConnect()
        {
            return "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";
        }

        private void LoadTicketStatus()
        {
            string query = @"
    SELECT 
        ticket_id, 
        title, 
        category, 
        priority, 
        status, 
        description, 
        created_at,
        CONCAT(a.firstname, ' ', a.lastname) AS assigned_to,
        t.user_extra_remarks
    FROM tickets t
    LEFT JOIN accounts a ON t.assigned_to = a.userID
    WHERE t.ticket_id = @ticketId";

            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTicketTitle.Text = reader["title"].ToString();
                            lblCategory.Text = reader["category"].ToString();
                            lblDesc.Text = reader["description"].ToString();
                            this.status = reader["status"].ToString();

                            // Set admin name
                            string statusLower = this.status.ToLowerInvariant();
                            if (statusLower != "open")
                            {
                                lblAdminName.Text = reader["assigned_to"] == DBNull.Value || string.IsNullOrWhiteSpace(reader["assigned_to"].ToString())
                                    ? "Unassigned"
                                    : reader["assigned_to"].ToString();
                            }
                            else
                            {
                                lblAdminName.Text = "Unassigned";
                            }

                            // Load user extra remarks
                            txtLiveRemarksPrev.Text = reader["user_extra_remarks"] == DBNull.Value ? "" : reader["user_extra_remarks"].ToString();

                            // Enable btnPost only for "On Hold" or "In Progress"
                            btnPost.Enabled = (statusLower == "on hold" || statusLower == "in progress" || statusLower == "resolved");
                        }
                        else
                        {
                            MessageBox.Show("Ticket not found.");
                        }
                    }
                }
            }
            btnConfirm.Enabled = (this.status == "Resolved");
        }

        private void LoadStatusBarImage()
        {
            string imagePath = GetStatusImagePath(status);
            //MessageBox.Show($"Status: '{status}'\nPath: {imagePath}\nExists: {File.Exists(imagePath)}");
            if (File.Exists(imagePath))
            {
                pbStatusBar.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image not found for status: " + status);
                pbStatusBar.Image = Image.FromFile(Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "default.png")); // Default image if not found
            }
        }

        private string GetStatusImagePath(string status)
        {
            switch (status)
            {
                case "Open":
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "Opened.png"); //ticket has been made
                case "Assigned":
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "Assigned.png"); //ticket has been assigned to an admin
                case "On Hold":
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "On Hold.png"); //ticket is not being worked on
                case "In Progress":
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "In Progress.png"); //ticket is being worked on
                case "Resolved":
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "Resolved.png"); //ticket has been resolved by an admin
                case "Completed":
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "Completed.png"); //ticket has been confirmed as resolved by the user
                default:
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "default.png");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tickets SET status = 'Closed', completed_at = NOW() WHERE ticket_id = @ticketId";
            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    cmd.ExecuteNonQuery();
                }
            }

            this.status = "Completed";
            LoadStatusBarImage();

            // Optionally, update any status label on the form
            // lblStatus.Text = "Completed";

            MessageBox.Show("Ticket marked as Completed.");
            btnConfirm.Enabled = false;
        }

        //progress remarks hover
        private void onHoverTrigger_MouseEnter(object sender, EventArgs e)
        {
            if (hoverRemarksForm == null || hoverRemarksForm.IsDisposed)
            {
                // Parse userId to int for onHoverProgressRemarks constructor
                int parsedUserId = 0;
                int.TryParse(userId, out parsedUserId);
                hoverRemarksForm = new onHoverProgressRemarks(ticketId, parsedUserId);
                hoverRemarksForm.StartPosition = FormStartPosition.Manual;
                // Position the form next to the panel
                var panelLocation = this.PointToScreen(onHoverTrigger.Location);
                hoverRemarksForm.Location = new Point(panelLocation.X + onHoverTrigger.Width, panelLocation.Y);
                hoverRemarksForm.Show(this);
            }
        }
        private void onHoverTrigger_MouseLeave(object sender, EventArgs e)
        {
            if (hoverRemarksForm != null && !hoverRemarksForm.IsDisposed)
            {
                hoverRemarksForm.Close();
            }
        }

        // on hold hover
        private void lblOnHold_MouseEnter(object sender, EventArgs e)
        {
            if (hoverOnHoldForm == null || hoverOnHoldForm.IsDisposed)
            {
                hoverOnHoldForm = new onHoverOnHoldRemarks(ticketId);
                hoverOnHoldForm.FormBorderStyle = FormBorderStyle.None; // No border
                hoverOnHoldForm.StartPosition = FormStartPosition.Manual;
                var labelLocation = this.PointToScreen(lblOnHold.Location);
                hoverOnHoldForm.Location = new Point(labelLocation.X + lblOnHold.Width, labelLocation.Y);
                hoverOnHoldForm.Show(this);
            }
        }
        private void lblOnHold_MouseLeave(object sender, EventArgs e)
        {
            if (hoverOnHoldForm != null && !hoverOnHoldForm.IsDisposed)
            {
                hoverOnHoldForm.Close();
            }
        }

        // resolve remarks hover
        private void lblResolved_MouseEnter(object sender, EventArgs e)
        {
            if (hoverResolveForm == null || hoverResolveForm.IsDisposed)
            {
                hoverResolveForm = new onHoverResolveRemarks(ticketId);
                hoverResolveForm.StartPosition = FormStartPosition.Manual;
                // Position the form next to lblResolved
                var labelLocation = this.PointToScreen(lblResolved.Location);
                hoverResolveForm.Location = new Point(labelLocation.X + lblResolved.Width, labelLocation.Y);
                hoverResolveForm.Show(this);
            }
        }

        private void lblResolved_MouseLeave(object sender, EventArgs e)
        {
            if (hoverResolveForm != null && !hoverResolveForm.IsDisposed)
            {
                hoverResolveForm.Close();
            }
        }


        private void btnPost_Click(object sender, EventArgs e)
        {
            string userRemark = txtLiveRemarks.Text.Trim();
            if (string.IsNullOrEmpty(userRemark))
            {
                MessageBox.Show("Please enter a remark before posting.");
                return;
            }

            string updateQuery = "UPDATE tickets SET user_extra_remarks = @remark WHERE ticket_id = @ticketId";
            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@remark", userRemark);
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Refresh the remarks display
            txtLiveRemarksPrev.Text = userRemark;
            txtLiveRemarks.Clear();
            MessageBox.Show("Remark posted.");
        }
    }
}
