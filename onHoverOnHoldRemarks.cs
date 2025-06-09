using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT_Helpdesk
{
    public partial class onHoverOnHoldRemarks : Form
    {
        private int ticketId;
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";

        public onHoverOnHoldRemarks(int ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
            this.FormBorderStyle = FormBorderStyle.None;
            LoadOnHoldInfo();
        }

        private void LoadOnHoldInfo()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT on_hold_reason, on_hold_until FROM tickets WHERE ticket_id = @ticketId";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string reason = reader["on_hold_reason"] == DBNull.Value ? "" : reader["on_hold_reason"].ToString();
                            string until = reader["on_hold_until"] == DBNull.Value
                                ? "N/A"
                                : Convert.ToDateTime(reader["on_hold_until"]).ToString("yyyy-MM-dd HH:mm");

                            lblOnHoldUntil.Text = $"On hold until estimated: {until}";
                            txtBoxOnHoldRemarks.Text = reason;
                        }
                        else
                        {
                            lblOnHoldUntil.Text = "On hold until estimated: N/A";
                            txtBoxOnHoldRemarks.Text = "";
                        }
                    }
                }
            }
        }
    }
}
