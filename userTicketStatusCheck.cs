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

    public userTicketStatusCheck(int ticketId, string status)
    {
        InitializeComponent();
        this.ticketId = ticketId;
        this.status = status;
        LoadTicketStatus();
        LoadStatusBarImage();
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
                            /*lblPriority.Text = reader["priority"].ToString();
                            lblStatus.Text = reader["status"].ToString();
                            lblDescription.Text = reader["description"].ToString();
                            lblAssignedTo.Text = reader["assigned_to"].ToString();
                            lblCreatedAt.Text = Convert.ToDateTime(reader["created_at"]).ToString("g");*/

                        }
                        else
                    {
                        MessageBox.Show("Ticket not found.");
                    }
                }
            }
        }
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
            case "Closed":
                return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "Default.png"); //idk
            default:
                return Path.Combine(Application.StartupPath, "progressTracker_ITHelpdesk", "default.png");
        }
    }
}

}
