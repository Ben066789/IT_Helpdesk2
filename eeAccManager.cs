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
    public partial class eeAccManager : Form
    {
        public eeAccManager()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
        }
        private string serverConnect()
        {
            return "Server=127.0.0.1; Database=company_helpdesk; User ID=root; Password=;";
        }
        private void LoadRoles()
        {
            roleCmb.SelectedIndex = 0;  // Set default selection (Admin)
        }

        private void eeAccManager_Load(object sender, EventArgs e)
        {
            LoadAccountList();
            LoadRoles(); // Populate the role combobox
        }

        private void accountListStyling()
        {
            accountList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            accountList.MultiSelect = false;
            accountList.BorderStyle = BorderStyle.None;
            accountList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            accountList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            accountList.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            accountList.DefaultCellStyle.SelectionForeColor = Color.Black;
            accountList.BackgroundColor = Color.White;

            accountList.EnableHeadersVisualStyles = false;
            accountList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            accountList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            accountList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            accountList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            accountList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            accountList.AllowUserToResizeRows = false;
            accountList.AllowUserToResizeColumns = false;

            // Optional: Customize column names if needed
            if (accountList.Columns.Contains("userID")) accountList.Columns["userID"].HeaderText = "User ID";
            if (accountList.Columns.Contains("firstname")) accountList.Columns["firstname"].HeaderText = "First Name";
            if (accountList.Columns.Contains("lastname")) accountList.Columns["lastname"].HeaderText = "Last Name";
            if (accountList.Columns.Contains("username")) accountList.Columns["username"].HeaderText = "Username";
            if (accountList.Columns.Contains("role")) accountList.Columns["role"].HeaderText = "Role";
            if (accountList.Columns.Contains("account_status")) accountList.Columns["account_status"].HeaderText = "Status";
        }

        private void LoadAccountList()
        {
            string query = "SELECT userID, firstname, lastname, username, role, account_status FROM accounts";

            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    accountList.DataSource = table;
                    accountListStyling(); // Apply the styling
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameCreate.Text.Trim();
            string lastName = lastNameCreate.Text.Trim();
            string userName = userNameCreate.Text.Trim();
            string password = passwordCreate.Text.Trim();
            string role = roleCmb.SelectedItem.ToString().ToLower();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newUserId = "ITHD001"; // Default for first user

            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                try
                {
                    conn.Open();

                    // Get the highest current userID
                    string getMaxIdQuery = "SELECT userID FROM accounts WHERE userID LIKE 'ITHD%' ORDER BY userID DESC LIMIT 1";
                    MySqlCommand getMaxIdCmd = new MySqlCommand(getMaxIdQuery, conn);
                    object result = getMaxIdCmd.ExecuteScalar();

                    if (result != null)
                    {
                        string lastUserId = result.ToString();
                        // Extract the numeric part and increment
                        int lastNum = int.Parse(lastUserId.Substring(4));
                        newUserId = "ITHD" + (lastNum + 1).ToString("D3");
                    }

                    string query = "INSERT INTO accounts (userID, firstname, lastname, username, password, role, account_status) " +
                                   "VALUES (@userID, @firstname, @lastname, @username, @password, @role, @account_status)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", newUserId);
                    cmd.Parameters.AddWithValue("@firstname", firstName);
                    cmd.Parameters.AddWithValue("@lastname", lastName);
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@account_status", "active");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void deactivateBtn_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedRows.Count > 0)
            {
                // Change from int to string, remove Convert.ToInt32
                string userId = accountList.SelectedRows[0].Cells["userID"].Value.ToString();

                string query = "UPDATE accounts SET account_status = 'deactivated', eeStatus = 'unavailable' WHERE userID = @userID";

                using (MySqlConnection conn = new MySqlConnection(serverConnect()))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAccountList();  // Reload the list to show the updated status
                        }
                        else
                        {
                            MessageBox.Show("Failed to deactivate account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an account to deactivate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reactivateBtn_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedRows.Count > 0)
            {
                // Change from int to string, remove Convert.ToInt32
                string userId = accountList.SelectedRows[0].Cells["userID"].Value.ToString();

                string query = "UPDATE accounts SET account_status = 'active' WHERE userID = @userID";

                using (MySqlConnection conn = new MySqlConnection(serverConnect()))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account reactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAccountList();  // Reload the list to reflect the change
                        }
                        else
                        {
                            MessageBox.Show("Failed to reactivate account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an account to reactivate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchBar.Text.Trim();

            string query = "SELECT userID, firstname, lastname, username, role, account_status " +
                           "FROM accounts " +
                           "WHERE firstname LIKE @keyword OR lastname LIKE @keyword OR username LIKE @keyword";

            using (MySqlConnection conn = new MySqlConnection(serverConnect()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    accountList.DataSource = table;
                    accountListStyling(); // Apply styling again
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
