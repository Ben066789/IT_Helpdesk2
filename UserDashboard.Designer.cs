namespace IT_Helpdesk
{
    partial class UserDashboard
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
            lblWelcomeUser = new Label();
            createButton = new Button();
            dataGridView1 = new DataGridView();
            logoutBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            historyBtn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Segoe UI", 15F);
            lblWelcomeUser.Location = new Point(12, 9);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(226, 28);
            lblWelcomeUser.TabIndex = 0;
            lblWelcomeUser.Text = "welcome user name here";
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 50);
            createButton.Name = "createButton";
            createButton.Size = new Size(159, 33);
            createButton.TabIndex = 1;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(177, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1282, 243);
            dataGridView1.TabIndex = 2;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Gainsboro;
            logoutBtn.Location = new Point(12, 261);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(159, 32);
            logoutBtn.TabIndex = 1;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // historyBtn
            // 
            historyBtn.Location = new Point(12, 89);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new Size(159, 33);
            historyBtn.TabIndex = 1;
            historyBtn.Text = "History";
            historyBtn.UseVisualStyleBackColor = true;
            historyBtn.Click += historyBtn_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackgroundImage = Properties.Resources.IT_HelpdeskBG;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(historyBtn);
            panel1.Controls.Add(createButton);
            panel1.Controls.Add(lblWelcomeUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1464, 324);
            panel1.TabIndex = 4;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 324);
            Controls.Add(panel1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcomeUser;
        private Button createButton;
        private DataGridView dataGridView1;
        private Button logoutBtn;
        private System.Windows.Forms.Timer timer1;
        private Button historyBtn;
        private Panel panel1;
    }
}