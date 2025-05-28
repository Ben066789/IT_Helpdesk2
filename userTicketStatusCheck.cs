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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT_Helpdesk
{
    public partial class userTicketStatusCheck : Form
    {
        private string status;
        private int ticketId;
        private int userId;
        private onHoverProgressRemarks hoverRemarksForm;

        public userTicketStatusCheck(int ticketId, string status, int userId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
            this.status = status;
            this.userId = userId;
            LoadTicketStatus();
            LoadStatusBarImage();
            onHoverTrigger.MouseEnter += onHoverTrigger_MouseEnter;
            onHoverTrigger.MouseLeave += onHoverTrigger_MouseLeave;
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
            CONCAT(a.firstname, ' ', a.lastname) AS assigned_to
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
                            // Optionally update status label
                            // lblStatus.Text = this.status;
                        }
                        else
                        {
                            MessageBox.Show("Ticket not found.");
                        }
                    }
                }
            }
            // Enable or disable the button after loading status
            btnConfirm.Enabled = (this.status == "Resolved");
        }



        private void LoadStatusBarImage()
        {
            string imagePath = GetStatusImagePath(status);
            if (File.Exists(imagePath))
            {
                pbStatusBar.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image not found for status: " + status);
            }
        }

        private string GetStatusImagePath(string status)
        {
            switch (status)
            {
                case "Open":
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "Open.png"); //ticket has been made
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
                case "Closed":
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "Default.png"); //idk
                default:
                    return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "default.png");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tickets SET status = 'Completed' WHERE ticket_id = @ticketId";
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
        private void onHoverTrigger_MouseEnter(object sender, EventArgs e)
        {
            if (hoverRemarksForm == null || hoverRemarksForm.IsDisposed)
            {
                hoverRemarksForm = new onHoverProgressRemarks(ticketId, userId); // Pass ticketId if needed
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
    }
}
