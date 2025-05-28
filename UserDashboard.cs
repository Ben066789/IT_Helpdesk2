using System;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT_Helpdesk
{
    public partial class UserDashboard : Form
    {
        private int userId;
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User=root; Password=;";
        private string currentUsername;

        public UserDashboard(int userId, string username)
        {
            InitializeComponent();
            currentUsername = username;
            this.userId = userId;
            LoadTickets();
            this.Load += UserDashboard_Load;
            this.FormClosed += logoutBtn_Click;
            this.FormClosing += UserDashboard_FormClosing;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.AllowUserToAddRows = false;
        }
        private string serverConnect()
        {
            return "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";
        }
        private void StyleDataGridView()
        {
            //data grid styling
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            //name mask
            dataGridView1.Columns["ticket_id"].HeaderText = "Ticket ID";
            dataGridView1.Columns["title"].HeaderText = "Title";
            dataGridView1.Columns["category"].HeaderText = "Category";
            dataGridView1.Columns["description"].HeaderText = "Description";
            dataGridView1.Columns["created_at"].HeaderText = "Date Created";
            dataGridView1.Columns["priority"].HeaderText = "Priority";
            dataGridView1.Columns["status"].HeaderText = "Status";
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "status" && e.Value != null)
            {
                string status = e.Value.ToString().Trim();
                switch (status)
                {
                    case "Open":
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#007BFF");
                        break;
                    case "Assigned":
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#17A2B8");
                        break;
                    case "On Hold":
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#FD7E14");
                        break;
                    case "In Progress":
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#FFC107");
                        break;
                    case "Resolved":
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#28A745");
                        break;
                    case "Completed":
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#218838");
                        break;
                    case "Closed":
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#6C757D");
                        break;
                    default:
                        e.CellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                        break;
                }
            }
        }

        private void LoadTickets()
        {
            string query = @"
        SELECT 
            ticket_id, title, category, description, created_at, priority, status
            
            FROM tickets t
            LEFT JOIN accounts a ON t.assigned_to = a.userID
            WHERE t.user_id = @userId AND t.status != 'Closed'
            ORDER BY t.created_at DESC"; //CONCAT(a.firstname, ' ', a.lastname) AS assigned_to


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
                DataTable ticketTable = new DataTable();
                adapter.Fill(ticketTable);

                dataGridView1.DataSource = ticketTable;
            }
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            CreateTicketForm createForm = new CreateTicketForm(userId);
            createForm.ShowDialog();
            LoadTickets();
        }
        //historyBtn_Click
        private void historyBtn_Click(object sender, EventArgs e)
        {
            History historyForm = new History(userId);
            historyForm.ShowDialog();
            LoadTickets();
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Login loginForm = new Login();
            loginForm.Show();
        }
        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            this.Text = "IT Helpdesk - User Dashboard";
            StyleDataGridView();
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
                            lblWelcomeUser.Text = "Welcome, " + result.ToString();
                        }
                        else
                        {
                            lblWelcomeUser.Text = "Welcome, Admin";
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is a valid row (not a header)
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int ticketId = Convert.ToInt32(row.Cells["ticket_id"].Value);
                    string status = row.Cells["status"].Value.ToString().Trim();

                    userTicketStatusCheck statusForm = new userTicketStatusCheck(ticketId, status, userId);
                    statusForm.ShowDialog();

                    LoadTickets();
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
