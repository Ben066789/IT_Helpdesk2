﻿using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT_Helpdesk
{
    public partial class AdminDashboard : Form
    {
        private string currentUsername;
        private string userId; // CHANGED from int to string

        public AdminDashboard(string username, string userId) // CHANGED from int to string
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            currentUsername = username;
            this.FormClosed += AdminDashboard_FormClosed;
            this.FormClosing += AdminDashboard_FormClosing;
            this.userId = userId; // assignment remains
            LoadAssignedTickets();
            adminDataGridViewStyling();
            LoadClosedTicketsHistory();
            historyDataGridViewStyling();
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            adminDataGridView.CellClick += adminDataGridView_CellClick;
            adminDataGridView.CellFormatting += DataGridView_CellFormatting;
            historyDataGridView.CellFormatting += DataGridView_CellFormatting;
            historyDataGridView.CellClick += historyDataGridView_CellClick;
        }// Constructor receives the logged-in username

        private string serverConnect()
        {
            return "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";
        } // Connection string method

        private void LoadAssignedTickets()
        {
            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                string query = @"
SELECT 
    t.ticket_id,
    t.title,
    CONCAT(a.firstname, ' ', a.lastname) AS owner_name,
    t.description,
    t.priority,
    t.status,
    t.created_at,
    t.note
FROM tickets t
JOIN accounts a ON t.user_id = a.userID
WHERE t.assigned_to = @adminId AND t.status != 'closed'
ORDER BY 
    CASE 
        WHEN t.priority = 'low' THEN 4
        WHEN t.priority = 'normal' THEN 3
        WHEN t.priority = 'high' THEN 2
        WHEN t.priority = 'urgent' THEN 1
        ELSE 5
    END,
    t.created_at DESC";

                /* t
                 * CONCAT for joining admin's firstname & lastname*/

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@adminId", userId); // userId is now string

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    adminDataGridView.DataSource = dt;

                    // Optional styling
                    adminDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    adminDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    adminDataGridView.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tickets: " + ex.Message);
                }
            }
        }//loads datagrid

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].Name == "status" && e.Value != null)
            {
                e.CellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Bold);
                string status = e.Value.ToString().ToLower();
                // Color indicator for status
                if (status == "in progress") e.CellStyle.ForeColor = Color.Orange;
                else if (status == "resolved") e.CellStyle.ForeColor = Color.Green;
                else if (status == "closed") e.CellStyle.ForeColor = Color.Gray;
                else e.CellStyle.ForeColor = Color.Black;
            }

            if (dgv.Columns[e.ColumnIndex].Name == "priority" && e.Value != null)
            {
                e.CellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Bold);
                string priority = e.Value.ToString().ToLower();
                // Color indicator for priority
                if (priority == "high") e.CellStyle.ForeColor = Color.Red;
                else if (priority == "medium") e.CellStyle.ForeColor = Color.Goldenrod;
                else if (priority == "low") e.CellStyle.ForeColor = Color.Blue;
                else e.CellStyle.ForeColor = Color.Black;
            }
            if (dgv.Columns[e.ColumnIndex].Name == "priority" && e.Value != null)
            {
                e.CellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Bold);
                string priority = e.Value.ToString().ToLower();
                switch (priority)
                {
                    case "urgent":
                        e.CellStyle.ForeColor = Color.DarkViolet;
                        break;
                    case "high":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                    case "normal":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        break;
                    case "low":
                        e.CellStyle.ForeColor = Color.Blue;
                        break;
                    default:
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }

        }

        private void adminDataGridViewStyling()
        {
            adminDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adminDataGridView.MultiSelect = false;
            adminDataGridView.BorderStyle = BorderStyle.None;
            adminDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            adminDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            adminDataGridView.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            adminDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            adminDataGridView.BackgroundColor = Color.White;

            adminDataGridView.EnableHeadersVisualStyles = false;
            adminDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            adminDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            adminDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            adminDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adminDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            adminDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            adminDataGridView.AllowUserToResizeRows = false;
            adminDataGridView.AllowUserToResizeColumns = false;

            if (adminDataGridView.Columns.Contains("ticket_id")) adminDataGridView.Columns["ticket_id"].HeaderText = "Ticket ID";
            if (adminDataGridView.Columns.Contains("owner_name")) adminDataGridView.Columns["owner_name"].HeaderText = "Submitted By";
            if (adminDataGridView.Columns.Contains("title")) adminDataGridView.Columns["title"].HeaderText = "Title";
            if (adminDataGridView.Columns.Contains("department")) adminDataGridView.Columns["department"].HeaderText = "Department";
            if (adminDataGridView.Columns.Contains("updated_at")) adminDataGridView.Columns["updated_at"].HeaderText = "Updated";
            if (adminDataGridView.Columns.Contains("category")) adminDataGridView.Columns["category"].HeaderText = "Category";
            if (adminDataGridView.Columns.Contains("priority")) adminDataGridView.Columns["priority"].HeaderText = "Priority";
            if (adminDataGridView.Columns.Contains("status")) adminDataGridView.Columns["status"].HeaderText = "Status";
            if (adminDataGridView.Columns.Contains("description")) adminDataGridView.Columns["description"].HeaderText = "Description";
            if (adminDataGridView.Columns.Contains("created_at")) adminDataGridView.Columns["created_at"].HeaderText = "Created";
            if (adminDataGridView.Columns.Contains("note")) adminDataGridView.Columns["note"].HeaderText = "Note";
            if (adminDataGridView.Columns.Contains("handled_by")) adminDataGridView.Columns["handled_by"].HeaderText = "Handled By";
        }

        private void historyDataGridViewStyling()
        {
            historyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            historyDataGridView.MultiSelect = false;
            historyDataGridView.BorderStyle = BorderStyle.None;
            historyDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            historyDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            historyDataGridView.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            historyDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            historyDataGridView.BackgroundColor = Color.White;

            historyDataGridView.EnableHeadersVisualStyles = false;
            historyDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            historyDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            historyDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            historyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            historyDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            historyDataGridView.AllowUserToResizeRows = false;
            historyDataGridView.AllowUserToResizeColumns = false;

            if (historyDataGridView.Columns.Contains("ticket_id")) historyDataGridView.Columns["ticket_id"].HeaderText = "Ticket ID";
            if (historyDataGridView.Columns.Contains("title")) historyDataGridView.Columns["title"].HeaderText = "Title";
            if (historyDataGridView.Columns.Contains("category")) historyDataGridView.Columns["category"].HeaderText = "Category";
            if (historyDataGridView.Columns.Contains("priority")) historyDataGridView.Columns["priority"].HeaderText = "Priority";
            if (historyDataGridView.Columns.Contains("status")) historyDataGridView.Columns["status"].HeaderText = "Status";
            if (historyDataGridView.Columns.Contains("description")) historyDataGridView.Columns["description"].HeaderText = "Description";
            if (historyDataGridView.Columns.Contains("created_at")) historyDataGridView.Columns["created_at"].HeaderText = "Created";
            if (historyDataGridView.Columns.Contains("updated_at")) historyDataGridView.Columns["updated_at"].HeaderText = "Updated";
            if (historyDataGridView.Columns.Contains("completed_at")) historyDataGridView.Columns["completed_at"].HeaderText = "Resolved";
            if (historyDataGridView.Columns.Contains("note")) historyDataGridView.Columns["note"].HeaderText = "Note";
            if (historyDataGridView.Columns.Contains("submitted_by")) historyDataGridView.Columns["submitted_by"].HeaderText = "Submitted By";
            if (historyDataGridView.Columns.Contains("department")) historyDataGridView.Columns["department"].HeaderText = "Department";
            if (historyDataGridView.Columns.Contains("handled_by")) historyDataGridView.Columns["handled_by"].HeaderText = "Handled By";
        }
        private void historyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = historyDataGridView.Rows[e.RowIndex];
            int selectedTicketId = Convert.ToInt32(row.Cells["ticket_id"].Value);
            string status = row.Cells["status"].Value.ToString();
            userTicketStatusCheck statusCheckForm = new userTicketStatusCheck(selectedTicketId, status, userId);
            statusCheckForm.ShowDialog();
        }



        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //welcome text
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
            timer1.Start();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
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

        /*private void update_Click(object sender, EventArgs e)
        {
            if (adminDataGridView.SelectedRows.Count > 0)
            {
                int ticketId = Convert.ToInt32(adminDataGridView.SelectedRows[0].Cells["ticket_id"].Value);
                string newStatus = statusCmb.SelectedItem?.ToString().ToLower(); // normalize status
                string note = noteTxtBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(newStatus) || string.IsNullOrWhiteSpace(note))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                string query = newStatus == "closed"
                    ? "UPDATE tickets SET status = @status, note = @note, completed_at = NOW() WHERE ticket_id = @ticketId"
                    : "UPDATE tickets SET status = @status, note = @note WHERE ticket_id = @ticketId";

                using (MySqlConnection conn = new MySqlConnection(serverConnect()))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@note", note);
                        cmd.Parameters.AddWithValue("@ticketId", ticketId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ticket updated successfully.");

                        LoadAssignedTickets();
                        LoadClosedTicketsHistory(); // refresh table after update
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating ticket: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a ticket to update.");
            }
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("f");
        }

        /*private void reassignBtn_Click(object sender, EventArgs e)
        {
            if (adminDataGridView.SelectedRows.Count > 0)
            {
                int selectedTicketId = Convert.ToInt32(adminDataGridView.SelectedRows[0].Cells["ticket_id"].Value);
                string ticketStatus = adminDataGridView.SelectedRows[0].Cells["status"].Value.ToString().ToLower();

                // Prevent reassignment of closed tickets
                if (ticketStatus == "closed")
                {
                    MessageBox.Show("This ticket is closed and cannot be reassigned.");
                    return;
                }

                // Create and show the reassign form
                AdminTicketManager reassignForm = new AdminTicketManager(selectedTicketId);
                reassignForm.FormClosed += (s, args) => LoadAssignedTickets(); // Refresh the grid after reassignment
                reassignForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a ticket to reassign.");
            }
        }*/

        private void adminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = adminDataGridView.Rows[e.RowIndex];
            int selectedTicketId = Convert.ToInt32(row.Cells["ticket_id"].Value);
            string ticketStatus = row.Cells["status"].Value.ToString().ToLower();

            // Prevent reassignment of closed tickets
            if (ticketStatus == "closed")
            {
                MessageBox.Show("This ticket is closed and cannot be reassigned.");
                return;
            }

            // Open the AdminTicketManager form for the selected ticket
            AdminTicketManager ticketManagerForm = new AdminTicketManager(selectedTicketId, userId); // userId is now string
            ticketManagerForm.FormClosed += (s, args) => LoadAssignedTickets(); // Refresh the grid after reassignment
            ticketManagerForm.ShowDialog();
        }


        private void LoadClosedTicketsHistory()
        {
            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                string query = @"
            SELECT 
                t.ticket_id,
                CONCAT(userAcc.firstname, ' ', userAcc.lastname) AS submitted_by,
                t.title,
                t.description,
                t.category,
                t.priority,
                t.department,
                t.status,
                t.created_at,
                t.updated_at,
                t.completed_at,
                t.note,
                CONCAT(adminAcc.firstname, ' ', adminAcc.lastname) AS handled_by
                FROM tickets t
                JOIN accounts userAcc ON t.user_id = userAcc.userID
                LEFT JOIN accounts adminAcc ON t.assigned_to = adminAcc.userID
                WHERE t.status = 'closed' AND t.assigned_to = @adminId
                ORDER BY t.completed_at DESC";

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@adminId", userId); // userId is now string

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    historyDataGridView.DataSource = dt;

                    // Style like other tables
                    historyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    historyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    historyDataGridView.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ticket history: " + ex.Message);
                }
            }
        }


        private void eeAccManagerBtn_Click(object sender, EventArgs e)
        {
            eeAccManager accManagerForm = new eeAccManager();
            accManagerForm.ShowDialog();
        }

        // ...existing code...
        private void ticketRecordsBtn_Click(object sender, EventArgs e)
        {
            TicketRecords ticketRecordsForm = new TicketRecords(userId); // userId is now string
            ticketRecordsForm.ShowDialog();
        }

        private void adminDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyword = historySearchBar.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                string query = @"
        SELECT 
            t.ticket_id,
            CONCAT(userAcc.firstname, ' ', userAcc.lastname) AS submitted_by,
            t.title,
            t.description,
            t.category,
            t.priority,
            t.department,
            t.status,
            t.created_at,
            t.updated_at,
            t.completed_at,
            t.note,
            CONCAT(adminAcc.firstname, ' ', adminAcc.lastname) AS handled_by
        FROM tickets t
        JOIN accounts userAcc ON t.user_id = userAcc.userID
        LEFT JOIN accounts adminAcc ON t.assigned_to = adminAcc.userID
        WHERE 
            t.status = 'closed' AND 
            t.assigned_to = @adminId AND (
                t.title LIKE @keyword OR 
                t.description LIKE @keyword OR 
                userAcc.firstname LIKE @keyword OR 
                userAcc.lastname LIKE @keyword
            )
        ORDER BY t.completed_at DESC";

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@adminId", userId); // userId is now string
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    historyDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message);
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newStatus = cmbStatus.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newStatus)) return;

            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                conn.Open();
                string query = "UPDATE accounts SET eeStatus = @eeStatus WHERE userID = @userId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eeStatus", newStatus);
                    cmd.Parameters.AddWithValue("@userId", userId); // userId is now string
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Availability status updated to: " + newStatus);
        }
    }
}
