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
    public partial class TicketRecords : Form
    {
        private int adminId;
        public TicketRecords(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            LoadTicketRecords();
            allTicketRecordsStyling();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        private void LoadTicketRecords(string searchQuery = "")
        {
            using (MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;"))
            {
                string query = @"
SELECT 
    t.ticket_id,
    CONCAT(u.firstname, ' ', u.lastname) AS user_fullname,
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
    CONCAT(a.firstname, ' ', a.lastname) AS assigned_admin_fullname
FROM tickets t
JOIN accounts u ON t.user_id = u.userID
LEFT JOIN accounts a ON t.assigned_to = a.userID
WHERE 1 = 1";  // Dummy WHERE so that `AND` conditions can be appended



                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    query += @" AND (
        t.ticket_id LIKE @search OR
        t.title LIKE @search OR
        t.description LIKE @search OR
        t.category LIKE @search OR
        t.priority LIKE @search OR
        t.department LIKE @search OR
        t.status LIKE @search OR
        t.note LIKE @search OR
        t.created_at LIKE @search OR
        t.updated_at LIKE @search OR
        t.completed_at LIKE @search OR
        CONCAT(u.firstname, ' ', u.lastname) LIKE @search OR
        CONCAT(a.firstname, ' ', a.lastname) LIKE @search
    )";
                }


                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@adminId", adminId);

                    if (!string.IsNullOrWhiteSpace(searchQuery))
                    {
                        cmd.Parameters.AddWithValue("@search", $"%{searchQuery}%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    allTicketRecords.DataSource = dt;

                    // Style like other tables
                    allTicketRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    allTicketRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    allTicketRecords.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading records: " + ex.Message);
                }
            }
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            string searchQuery = searchBar.Text.Trim();
            LoadTicketRecords(searchQuery);
        }
        private void allTicketRecordsStyling()
        {
            allTicketRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allTicketRecords.MultiSelect = false;
            allTicketRecords.BorderStyle = BorderStyle.None;
            allTicketRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            allTicketRecords.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            allTicketRecords.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            allTicketRecords.DefaultCellStyle.SelectionForeColor = Color.Black;
            allTicketRecords.BackgroundColor = Color.White;

            allTicketRecords.EnableHeadersVisualStyles = false;
            allTicketRecords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            allTicketRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            allTicketRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            allTicketRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            allTicketRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allTicketRecords.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            allTicketRecords.AllowUserToResizeRows = false;
            allTicketRecords.AllowUserToResizeColumns = false;

            // Optional: Customize column names if needed
            if (allTicketRecords.Columns.Contains("userID")) allTicketRecords.Columns["userID"].HeaderText = "User ID";
            if (allTicketRecords.Columns.Contains("firstname")) allTicketRecords.Columns["firstname"].HeaderText = "First Name";
            if (allTicketRecords.Columns.Contains("lastname")) allTicketRecords.Columns["lastname"].HeaderText = "Last Name";
            if (allTicketRecords.Columns.Contains("username")) allTicketRecords.Columns["username"].HeaderText = "Username";
            if (allTicketRecords.Columns.Contains("role")) allTicketRecords.Columns["role"].HeaderText = "Role";
            if (allTicketRecords.Columns.Contains("account_status")) allTicketRecords.Columns["account_status"].HeaderText = "Status";
        }
    }
}
