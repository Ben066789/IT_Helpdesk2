using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT_Helpdesk
{
    public partial class UserDashboard : Form
    {
        private int userId;
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User=root; Password=;";

        public UserDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadTickets();
        }

        private void LoadTickets()
        {
            string query = "SELECT ticket_id, title, category, priority, status, created_at FROM tickets WHERE user_id = @userId";

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
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void cancelButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ticketId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ticket_id"].Value);
                string query = "UPDATE tickets SET status = 'Cancelled' WHERE ticket_id = @ticketId";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                LoadTickets();
            }
            else
            {
                MessageBox.Show("Please select a ticket to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
