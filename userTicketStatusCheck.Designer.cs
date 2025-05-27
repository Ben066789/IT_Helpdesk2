namespace IT_Helpdesk
{
    partial class userTicketStatusCheck
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
            pbStatusBar = new PictureBox();
            lblTicketTitle = new Label();
            lblCategory = new Label();
            lblOpen = new Label();
            lblAssigned = new Label();
            lblOnHold = new Label();
            lblInProgress = new Label();
            lblResolved = new Label();
            lblCompleted = new Label();
            lblClosed = new Label();
            ((System.ComponentModel.ISupportInitialize)pbStatusBar).BeginInit();
            SuspendLayout();
            // 
            // pbStatusBar
            // 
            pbStatusBar.Location = new Point(52, 83);
            pbStatusBar.Name = "pbStatusBar";
            pbStatusBar.Size = new Size(861, 110);
            pbStatusBar.TabIndex = 0;
            pbStatusBar.TabStop = false;
            // 
            // lblTicketTitle
            // 
            lblTicketTitle.AutoSize = true;
            lblTicketTitle.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            lblTicketTitle.Location = new Point(52, 54);
            lblTicketTitle.Name = "lblTicketTitle";
            lblTicketTitle.Size = new Size(183, 28);
            lblTicketTitle.TabIndex = 2;
            lblTicketTitle.Text = "ticket title here";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Gray;
            lblCategory.Location = new Point(56, 80);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 16);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "category here";
            // 
            // lblOpen
            // 
            lblOpen.AutoSize = true;
            lblOpen.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblOpen.Location = new Point(80, 181);
            lblOpen.Name = "lblOpen";
            lblOpen.Size = new Size(53, 19);
            lblOpen.TabIndex = 3;
            lblOpen.Text = "Open";
            lblOpen.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAssigned
            // 
            lblAssigned.AutoSize = true;
            lblAssigned.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblAssigned.Location = new Point(192, 181);
            lblAssigned.Name = "lblAssigned";
            lblAssigned.Size = new Size(79, 19);
            lblAssigned.TabIndex = 3;
            lblAssigned.Text = "Assigned";
            lblAssigned.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOnHold
            // 
            lblOnHold.AutoSize = true;
            lblOnHold.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblOnHold.Location = new Point(317, 181);
            lblOnHold.Name = "lblOnHold";
            lblOnHold.Size = new Size(72, 19);
            lblOnHold.TabIndex = 3;
            lblOnHold.Text = "On Hold";
            lblOnHold.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblInProgress.Location = new Point(433, 181);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(89, 19);
            lblInProgress.TabIndex = 3;
            lblInProgress.Text = "In Progress";
            lblInProgress.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResolved
            // 
            lblResolved.AutoSize = true;
            lblResolved.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblResolved.Location = new Point(562, 181);
            lblResolved.Name = "lblResolved";
            lblResolved.Size = new Size(78, 19);
            lblResolved.TabIndex = 3;
            lblResolved.Text = "Resolved";
            lblResolved.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblCompleted.Location = new Point(675, 181);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(97, 19);
            lblCompleted.TabIndex = 3;
            lblCompleted.Text = "Completed";
            lblCompleted.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblClosed
            // 
            lblClosed.AutoSize = true;
            lblClosed.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblClosed.Location = new Point(820, 181);
            lblClosed.Name = "lblClosed";
            lblClosed.Size = new Size(62, 19);
            lblClosed.TabIndex = 3;
            lblClosed.Text = "Closed";
            lblClosed.TextAlign = ContentAlignment.TopCenter;
            // 
            // userTicketStatusCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 324);
            Controls.Add(lblClosed);
            Controls.Add(lblCompleted);
            Controls.Add(lblResolved);
            Controls.Add(lblInProgress);
            Controls.Add(lblOnHold);
            Controls.Add(lblAssigned);
            Controls.Add(lblOpen);
            Controls.Add(lblCategory);
            Controls.Add(lblTicketTitle);
            Controls.Add(pbStatusBar);
            ForeColor = Color.FromArgb(64, 64, 64);
            Name = "userTicketStatusCheck";
            Text = "Ticket Status";
            ((System.ComponentModel.ISupportInitialize)pbStatusBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbStatusBar;
        private Label lblTicketTitle;
        private Label lblCategory;
        private Label lblOpen;
        private Label lblAssigned;
        private Label lblOnHold;
        private Label lblInProgress;
        private Label lblResolved;
        private Label lblCompleted;
        private Label lblClosed;
    }
}