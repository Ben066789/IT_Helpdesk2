using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace IT_Helpdesk
{
    public partial class ReassignForm : Form
    {
        private int ticketId;
        private string connectionString = "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";

        public string NewDescription => txtDescription.Text.Trim();
        public int SelectedAdminId => Convert.ToInt32(comboBoxAdmins.SelectedValue);

        public ReassignForm(int ticketId)
        {
            InitializeComponent();
            LoadAdmins();
            this.ticketId = ticketId;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Text = "Reassign Form";
        }

        private void LoadAdmins()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT userID, CONCAT(firstname, ' ', lastname) AS fullname FROM accounts WHERE role = 'admin'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxAdmins.DataSource = dt;
                comboBoxAdmins.DisplayMember = "fullname";
                comboBoxAdmins.ValueMember = "userID";
            }
        }

        private void reassignBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxAdmins.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an admin to reassign the ticket to.");
                return;
            }

            // Make sure the description is filled in
            if (string.IsNullOrWhiteSpace(NewDescription))
            {
                MessageBox.Show("Please provide a description for the reassignment.");
                return;
            }

            // Update the assigned_to and description in the database
            string updateQuery = "UPDATE tickets SET assigned_to = @newAdminId, note = @newDescription WHERE ticket_id = @ticketId AND status != 'closed'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@newAdminId", SelectedAdminId);
                    cmd.Parameters.AddWithValue("@newDescription", NewDescription);
                    cmd.Parameters.AddWithValue("@ticketId", ticketId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ticket reassigned and description updated successfully.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to reassign ticket. The ticket may be closed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reassigning ticket: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }


}
