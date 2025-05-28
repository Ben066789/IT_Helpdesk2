namespace IT_Helpdesk
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblWelcome = new Label();
            adminDataGridView = new DataGridView();
            eeAccManagerBtn = new Button();
            ticketRecordsBtn = new Button();
            lblDateTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            historyDataGridView = new DataGridView();
            pendingLbl = new Label();
            historyLbl = new Label();
            panel1 = new Panel();
            label1 = new Label();
            cmbStatus = new ComboBox();
            searchButton = new Button();
            historySearchBar = new TextBox();
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 15F);
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(185, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "welcome name here";
            // 
            // adminDataGridView
            // 
            adminDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminDataGridView.Location = new Point(263, 79);
            adminDataGridView.Name = "adminDataGridView";
            adminDataGridView.ReadOnly = true;
            adminDataGridView.RowHeadersVisible = false;
            adminDataGridView.Size = new Size(1214, 260);
            adminDataGridView.TabIndex = 3;
            // 
            // eeAccManagerBtn
            // 
            eeAccManagerBtn.AutoEllipsis = true;
            eeAccManagerBtn.Location = new Point(46, 85);
            eeAccManagerBtn.Name = "eeAccManagerBtn";
            eeAccManagerBtn.Size = new Size(177, 33);
            eeAccManagerBtn.TabIndex = 4;
            eeAccManagerBtn.Text = "User Account Manager";
            eeAccManagerBtn.UseVisualStyleBackColor = true;
            eeAccManagerBtn.Click += eeAccManagerBtn_Click;
            // 
            // ticketRecordsBtn
            // 
            ticketRecordsBtn.AutoEllipsis = true;
            ticketRecordsBtn.Location = new Point(46, 152);
            ticketRecordsBtn.Name = "ticketRecordsBtn";
            ticketRecordsBtn.Size = new Size(177, 33);
            ticketRecordsBtn.TabIndex = 4;
            ticketRecordsBtn.Text = "Ticket Records";
            ticketRecordsBtn.UseVisualStyleBackColor = true;
            ticketRecordsBtn.Click += ticketRecordsBtn_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(1267, 20);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(57, 15);
            lblDateTime.TabIndex = 5;
            lblDateTime.Text = "TimeDate";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // historyDataGridView
            // 
            historyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDataGridView.Location = new Point(263, 391);
            historyDataGridView.Name = "historyDataGridView";
            historyDataGridView.ReadOnly = true;
            historyDataGridView.RowHeadersVisible = false;
            historyDataGridView.Size = new Size(1214, 260);
            historyDataGridView.TabIndex = 3;
            // 
            // pendingLbl
            // 
            pendingLbl.AutoSize = true;
            pendingLbl.BackColor = Color.Transparent;
            pendingLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingLbl.Location = new Point(263, 48);
            pendingLbl.Name = "pendingLbl";
            pendingLbl.Size = new Size(88, 28);
            pendingLbl.TabIndex = 8;
            pendingLbl.Text = "Pending";
            // 
            // historyLbl
            // 
            historyLbl.AutoSize = true;
            historyLbl.BackColor = Color.Transparent;
            historyLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyLbl.Location = new Point(263, 360);
            historyLbl.Name = "historyLbl";
            historyLbl.Size = new Size(82, 28);
            historyLbl.TabIndex = 8;
            historyLbl.Text = "History";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackgroundImage = Properties.Resources.IT_HelpdeskBG;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(historySearchBar);
            panel1.Controls.Add(historyLbl);
            panel1.Controls.Add(pendingLbl);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(ticketRecordsBtn);
            panel1.Controls.Add(eeAccManagerBtn);
            panel1.Controls.Add(historyDataGridView);
            panel1.Controls.Add(adminDataGridView);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1495, 669);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(366, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 12;
            label1.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.System;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Unavailable" });
            cmbStatus.Location = new Point(263, 13);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(100, 23);
            cmbStatus.TabIndex = 11;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1440, 365);
            searchButton.Name = "searchButton";
            searchButton.RightToLeft = RightToLeft.No;
            searchButton.Size = new Size(37, 23);
            searchButton.TabIndex = 10;
            searchButton.Text = "Go";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // historySearchBar
            // 
            historySearchBar.Location = new Point(1263, 365);
            historySearchBar.Name = "historySearchBar";
            historySearchBar.Size = new Size(171, 23);
            historySearchBar.TabIndex = 9;
            // 
            // logoutBtn
            // 
            logoutBtn.AutoEllipsis = true;
            logoutBtn.Location = new Point(46, 618);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(177, 33);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 669);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "Admin";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)adminDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            //form closed
            //this.FormClosed += Form1_FormClosed;
        }

        #endregion

        private Label lblWelcome;
        private DataGridView adminDataGridView;
        private Button eeAccManagerBtn;
        private Button ticketRecordsBtn;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private DataGridView historyDataGridView;
        private Label pendingLbl;
        private Label historyLbl;
        private Panel panel1;
        private Button searchButton;
        private TextBox historySearchBar;
        private Button logoutBtn;
        private ComboBox cmbStatus;
        private Label label1;
    }
}