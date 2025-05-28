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
            onHoverTrigger = new Label();
            lblResolved = new Label();
            lblCompleted = new Label();
            lblClosed = new Label();
            btnConfirm = new Button();
            lbl1AdminProgress = new Label();
            lbl2AdminProgress = new Label();
            lbl3AdminProgress = new Label();
            lbl4AdminProgress = new Label();
            lbl5AdminProgress = new Label();
            lbl6AdminProgress = new Label();
            lblDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)pbStatusBar).BeginInit();
            SuspendLayout();
            // 
            // pbStatusBar
            // 
            pbStatusBar.BackColor = Color.Transparent;
            pbStatusBar.Location = new Point(12, 104);
            pbStatusBar.Name = "pbStatusBar";
            pbStatusBar.Size = new Size(861, 110);
            pbStatusBar.TabIndex = 0;
            pbStatusBar.TabStop = false;
            // 
            // lblTicketTitle
            // 
            lblTicketTitle.AutoSize = true;
            lblTicketTitle.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            lblTicketTitle.Location = new Point(8, 28);
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
            lblCategory.Location = new Point(12, 54);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 16);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "category here";
            // 
            // lblOpen
            // 
            lblOpen.AutoSize = true;
            lblOpen.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblOpen.Location = new Point(40, 202);
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
            lblAssigned.Location = new Point(152, 202);
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
            lblOnHold.Location = new Point(277, 202);
            lblOnHold.Name = "lblOnHold";
            lblOnHold.Size = new Size(72, 19);
            lblOnHold.TabIndex = 3;
            lblOnHold.Text = "On Hold";
            lblOnHold.TextAlign = ContentAlignment.TopCenter;
            // 
            // onHoverTrigger
            // 
            onHoverTrigger.AutoSize = true;
            onHoverTrigger.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            onHoverTrigger.Location = new Point(393, 202);
            onHoverTrigger.Name = "onHoverTrigger";
            onHoverTrigger.Size = new Size(89, 19);
            onHoverTrigger.TabIndex = 3;
            onHoverTrigger.Text = "In Progress";
            onHoverTrigger.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResolved
            // 
            lblResolved.AutoSize = true;
            lblResolved.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblResolved.Location = new Point(522, 202);
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
            lblCompleted.Location = new Point(635, 202);
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
            lblClosed.Location = new Point(780, 202);
            lblClosed.Name = "lblClosed";
            lblClosed.Size = new Size(62, 19);
            lblClosed.TabIndex = 3;
            lblClosed.Text = "Closed";
            lblClosed.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(646, 229);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lbl1AdminProgress
            // 
            lbl1AdminProgress.AutoSize = true;
            lbl1AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1AdminProgress.ForeColor = Color.Gray;
            lbl1AdminProgress.Location = new Point(393, 221);
            lbl1AdminProgress.Name = "lbl1AdminProgress";
            lbl1AdminProgress.Size = new Size(0, 17);
            lbl1AdminProgress.TabIndex = 2;
            // 
            // lbl2AdminProgress
            // 
            lbl2AdminProgress.AutoSize = true;
            lbl2AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2AdminProgress.ForeColor = Color.Gray;
            lbl2AdminProgress.Location = new Point(393, 238);
            lbl2AdminProgress.Name = "lbl2AdminProgress";
            lbl2AdminProgress.Size = new Size(0, 17);
            lbl2AdminProgress.TabIndex = 2;
            // 
            // lbl3AdminProgress
            // 
            lbl3AdminProgress.AutoSize = true;
            lbl3AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3AdminProgress.ForeColor = Color.Gray;
            lbl3AdminProgress.Location = new Point(393, 255);
            lbl3AdminProgress.Name = "lbl3AdminProgress";
            lbl3AdminProgress.Size = new Size(0, 17);
            lbl3AdminProgress.TabIndex = 2;
            // 
            // lbl4AdminProgress
            // 
            lbl4AdminProgress.AutoSize = true;
            lbl4AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl4AdminProgress.ForeColor = Color.Gray;
            lbl4AdminProgress.Location = new Point(393, 272);
            lbl4AdminProgress.Name = "lbl4AdminProgress";
            lbl4AdminProgress.Size = new Size(0, 17);
            lbl4AdminProgress.TabIndex = 2;
            // 
            // lbl5AdminProgress
            // 
            lbl5AdminProgress.AutoSize = true;
            lbl5AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl5AdminProgress.ForeColor = Color.Gray;
            lbl5AdminProgress.Location = new Point(393, 289);
            lbl5AdminProgress.Name = "lbl5AdminProgress";
            lbl5AdminProgress.Size = new Size(0, 17);
            lbl5AdminProgress.TabIndex = 2;
            // 
            // lbl6AdminProgress
            // 
            lbl6AdminProgress.AutoSize = true;
            lbl6AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl6AdminProgress.ForeColor = Color.Gray;
            lbl6AdminProgress.Location = new Point(393, 306);
            lbl6AdminProgress.Name = "lbl6AdminProgress";
            lbl6AdminProgress.Size = new Size(0, 17);
            lbl6AdminProgress.TabIndex = 2;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(13, 71);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(45, 17);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "label1";
            // 
            // userTicketStatusCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 356);
            Controls.Add(lblDesc);
            Controls.Add(btnConfirm);
            Controls.Add(lblClosed);
            Controls.Add(lblCompleted);
            Controls.Add(lblResolved);
            Controls.Add(onHoverTrigger);
            Controls.Add(lblOnHold);
            Controls.Add(lblAssigned);
            Controls.Add(lblOpen);
            Controls.Add(lbl6AdminProgress);
            Controls.Add(lbl5AdminProgress);
            Controls.Add(lbl4AdminProgress);
            Controls.Add(lbl3AdminProgress);
            Controls.Add(lbl2AdminProgress);
            Controls.Add(lbl1AdminProgress);
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
        private Label onHoverTrigger;
        private Label lblResolved;
        private Label lblCompleted;
        private Label lblClosed;
        private Button btnConfirm;
        private Label lbl1AdminProgress;
        private Label lbl2AdminProgress;
        private Label lbl3AdminProgress;
        private Label lbl4AdminProgress;
        private Label lbl5AdminProgress;
        private Label lbl6AdminProgress;
        private Label lblDesc;
    }
}