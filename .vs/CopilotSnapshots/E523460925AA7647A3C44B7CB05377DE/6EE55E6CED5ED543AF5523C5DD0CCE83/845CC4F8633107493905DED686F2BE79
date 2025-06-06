using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT_Helpdesk
{
    public partial class History : Form
    {
        private int userId;
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User=root; Password=;";

        public History(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        private void History_Load_1(object sender, EventArgs e)
        {
            LoadClosedTickets();
        }
        private void LoadClosedTickets()
        {
            string query = @"
        SELECT 
            t.title, 
            t.category, 
            t.status, 
            t.description, 
            CONCAT(a.firstname, ' ', a.lastname) AS assigned_to, 
            t.created_at, 
            t.completed_at,
            t.note
        FROM tickets t
        LEFT JOIN accounts a ON t.assigned_to = a.userID
        WHERE t.user_id = @userId AND t.status = 'Closed'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
                DataTable historyTable = new DataTable();
                adapter.Fill(historyTable);

                // Set the DataSource for the history DataGrid
                historyDataGrid.DataSource = historyTable;

                // Apply the same style as the userDashboard dataGridView
                ApplyHistoryDataGridStyle(historyDataGrid);
            }
        }

        private void ApplyHistoryDataGridStyle(DataGridView dataGridView)
        {
            // Same data grid styling as user dashboard's dataGridView1
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.BorderStyle = BorderStyle.None;

            // Alternating row colors
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            // Header styles
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Resize behavior
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Disable row/column resizing
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
