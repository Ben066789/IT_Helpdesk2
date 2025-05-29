using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT_Helpdesk
{
    public partial class onHoverResolveRemarks : Form
    {
        private int ticketId;
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";

        public onHoverResolveRemarks(int ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
            this.FormBorderStyle = FormBorderStyle.None;
            LoadResolveRemarks();
        }

        private void LoadResolveRemarks()
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
                            string remarks = reader["resolve_remarks"] == DBNull.Value ? "" : reader["resolve_remarks"].ToString();
                            txtResolveRemarks.Text = remarks;
                        }
                        else
                        {
                            txtResolveRemarks.Text = "No resolve remarks found.";
                        }
                    }
                }
            }
        }
    }
}
