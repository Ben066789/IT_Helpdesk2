using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT_Helpdesk
{
    public partial class onHoverProgressRemarks : Form
    {
        private int ticketId;
        private int userId;
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";

        public onHoverProgressRemarks(int ticketId, int userId)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.ticketId = ticketId;
            this.userId = userId;
            LoadRemarks();
        }

        private void LoadRemarks()
        {
            string query = "SELECT * FROM ticket_progress_remarks WHERE ticket_id = @ticketId";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ticketId", ticketId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        SetRemarkVisibility(
                            txtRemark1, timeDate1, reader["remark1"], reader["remark1_created_at"]);
                        SetRemarkVisibility(
                            txtRemark2, timeDate2, reader["remark2"], reader["remark2_created_at"]);
                        SetRemarkVisibility(
                            txtRemark3, timeDate3, reader["remark3"], reader["remark3_created_at"]);
                        SetRemarkVisibility(
                            txtRemark4, timeDate4, reader["remark4"], reader["remark4_created_at"]);
                        SetRemarkVisibility(
                            txtRemark5, timeDate5, reader["remark5"], reader["remark5_created_at"]);
                        SetRemarkVisibility(
                            txtRemark6, timeDate6, reader["remark6"], reader["remark6_created_at"]);
                    }
                    else
                    {
                        // Hide all if no data
                        SetRemarkVisibility(txtRemark1, timeDate1, null, null);
                        SetRemarkVisibility(txtRemark2, timeDate2, null, null);
                        SetRemarkVisibility(txtRemark3, timeDate3, null, null);
                        SetRemarkVisibility(txtRemark4, timeDate4, null, null);
                        SetRemarkVisibility(txtRemark5, timeDate5, null, null);
                        SetRemarkVisibility(txtRemark6, timeDate6, null, null);
                    }
                }
            }
        }

        private void SetRemarkVisibility(TextBox txtRemark, Label timeDate, object remarkValue, object createdAtValue)
        {
            string remark = remarkValue?.ToString();
            bool hasText = !string.IsNullOrWhiteSpace(remark);
            txtRemark.Text = hasText ? remark : "";
            txtRemark.Visible = hasText;
            timeDate.Visible = hasText;
            if (hasText && createdAtValue != DBNull.Value && createdAtValue != null)
            {
                DateTime createdAt = Convert.ToDateTime(createdAtValue);
                timeDate.Text = createdAt.ToString("MM/dd/yyyy hh:mm tt");
            }
            else
            {
                timeDate.Text = "";
            }
        }
    }
}
