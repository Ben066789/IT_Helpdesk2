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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userTicketStatusCheck));
            pbStatusBar = new PictureBox();
            lblTicketTitle = new Label();
            lblCategory = new Label();
            lblOpen = new Label();
            lblAssigned = new Label();
            lblOnHold = new Label();
            onHoverTrigger = new Label();
            lblResolved = new Label();
            lblCompleted = new Label();
            btnConfirm = new Button();
            lbl1AdminProgress = new Label();
            lbl2AdminProgress = new Label();
            lbl3AdminProgress = new Label();
            lbl4AdminProgress = new Label();
            lbl5AdminProgress = new Label();
            lbl6AdminProgress = new Label();
            lblDesc = new Label();
            txtLiveRemarks = new TextBox();
            lblAdminName = new Label();
            label1 = new Label();
            btnPost = new Button();
            txtLiveRemarksPrev = new TextBox();
            label2 = new Label();
            pnlStats = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbStatusBar).BeginInit();
            pnlStats.SuspendLayout();
            SuspendLayout();
            // 
            // pbStatusBar
            // 
            pbStatusBar.BackColor = Color.Transparent;
            pbStatusBar.Location = new Point(0, 0);
            pbStatusBar.Name = "pbStatusBar";
            pbStatusBar.Size = new Size(691, 75);
            pbStatusBar.TabIndex = 0;
            pbStatusBar.TabStop = false;
            // 
            // lblTicketTitle
            // 
            lblTicketTitle.AutoSize = true;
            lblTicketTitle.BackColor = Color.Transparent;
            lblTicketTitle.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            lblTicketTitle.Location = new Point(15, 22);
            lblTicketTitle.Name = "lblTicketTitle";
            lblTicketTitle.Size = new Size(183, 28);
            lblTicketTitle.TabIndex = 2;
            lblTicketTitle.Text = "ticket title here";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Gray;
            lblCategory.Location = new Point(15, 50);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(137, 22);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "category here";
            // 
            // lblOpen
            // 
            lblOpen.AutoSize = true;
            lblOpen.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblOpen.Location = new Point(13, 78);
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
            lblAssigned.Location = new Point(125, 78);
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
            lblOnHold.Location = new Point(247, 78);
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
            onHoverTrigger.Location = new Point(363, 78);
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
            lblResolved.Location = new Point(490, 78);
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
            lblCompleted.Location = new Point(600, 78);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(97, 19);
            lblCompleted.TabIndex = 3;
            lblCompleted.Text = "Completed";
            lblCompleted.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(612, 100);
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
            lbl1AdminProgress.Location = new Point(396, 221);
            lbl1AdminProgress.Name = "lbl1AdminProgress";
            lbl1AdminProgress.Size = new Size(0, 17);
            lbl1AdminProgress.TabIndex = 2;
            // 
            // lbl2AdminProgress
            // 
            lbl2AdminProgress.AutoSize = true;
            lbl2AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2AdminProgress.ForeColor = Color.Gray;
            lbl2AdminProgress.Location = new Point(396, 238);
            lbl2AdminProgress.Name = "lbl2AdminProgress";
            lbl2AdminProgress.Size = new Size(0, 17);
            lbl2AdminProgress.TabIndex = 2;
            // 
            // lbl3AdminProgress
            // 
            lbl3AdminProgress.AutoSize = true;
            lbl3AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3AdminProgress.ForeColor = Color.Gray;
            lbl3AdminProgress.Location = new Point(312, 217);
            lbl3AdminProgress.Name = "lbl3AdminProgress";
            lbl3AdminProgress.Size = new Size(0, 17);
            lbl3AdminProgress.TabIndex = 2;
            // 
            // lbl4AdminProgress
            // 
            lbl4AdminProgress.AutoSize = true;
            lbl4AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl4AdminProgress.ForeColor = Color.Gray;
            lbl4AdminProgress.Location = new Point(312, 234);
            lbl4AdminProgress.Name = "lbl4AdminProgress";
            lbl4AdminProgress.Size = new Size(0, 17);
            lbl4AdminProgress.TabIndex = 2;
            // 
            // lbl5AdminProgress
            // 
            lbl5AdminProgress.AutoSize = true;
            lbl5AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl5AdminProgress.ForeColor = Color.Gray;
            lbl5AdminProgress.Location = new Point(312, 251);
            lbl5AdminProgress.Name = "lbl5AdminProgress";
            lbl5AdminProgress.Size = new Size(0, 17);
            lbl5AdminProgress.TabIndex = 2;
            // 
            // lbl6AdminProgress
            // 
            lbl6AdminProgress.AutoSize = true;
            lbl6AdminProgress.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl6AdminProgress.ForeColor = Color.Gray;
            lbl6AdminProgress.Location = new Point(312, 268);
            lbl6AdminProgress.Name = "lbl6AdminProgress";
            lbl6AdminProgress.Size = new Size(0, 17);
            lbl6AdminProgress.TabIndex = 2;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Font = new Font("Century Gothic", 10F);
            lblDesc.Location = new Point(16, 71);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(52, 19);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "label1";
            // 
            // txtLiveRemarks
            // 
            txtLiveRemarks.BorderStyle = BorderStyle.None;
            txtLiveRemarks.Font = new Font("Segoe UI", 10F);
            txtLiveRemarks.Location = new Point(28, 233);
            txtLiveRemarks.Multiline = true;
            txtLiveRemarks.Name = "txtLiveRemarks";
            txtLiveRemarks.Size = new Size(230, 68);
            txtLiveRemarks.TabIndex = 6;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(145, 97);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(38, 15);
            lblAdminName.TabIndex = 7;
            lblAdminName.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 306);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 8;
            label1.Text = "Extra Remarks";
            // 
            // btnPost
            // 
            btnPost.Location = new Point(183, 305);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(75, 23);
            btnPost.TabIndex = 4;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtLiveRemarksPrev
            // 
            txtLiveRemarksPrev.BorderStyle = BorderStyle.None;
            txtLiveRemarksPrev.Font = new Font("Segoe UI", 10F);
            txtLiveRemarksPrev.Location = new Point(264, 233);
            txtLiveRemarksPrev.Multiline = true;
            txtLiveRemarksPrev.Name = "txtLiveRemarksPrev";
            txtLiveRemarksPrev.ReadOnly = true;
            txtLiveRemarksPrev.Size = new Size(230, 68);
            txtLiveRemarksPrev.TabIndex = 6;
            txtLiveRemarksPrev.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 304);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 8;
            label2.Text = "Preview";
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.Transparent;
            pnlStats.Controls.Add(lblOnHold);
            pnlStats.Controls.Add(lblOpen);
            pnlStats.Controls.Add(lblAssigned);
            pnlStats.Controls.Add(onHoverTrigger);
            pnlStats.Controls.Add(lblAdminName);
            pnlStats.Controls.Add(lblResolved);
            pnlStats.Controls.Add(lblCompleted);
            pnlStats.Controls.Add(btnConfirm);
            pnlStats.Controls.Add(pbStatusBar);
            pnlStats.Location = new Point(15, 104);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(699, 148);
            pnlStats.TabIndex = 9;
            // 
            // userTicketStatusCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(721, 346);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLiveRemarksPrev);
            Controls.Add(txtLiveRemarks);
            Controls.Add(lblDesc);
            Controls.Add(btnPost);
            Controls.Add(lbl6AdminProgress);
            Controls.Add(lbl5AdminProgress);
            Controls.Add(lbl4AdminProgress);
            Controls.Add(lbl3AdminProgress);
            Controls.Add(lbl2AdminProgress);
            Controls.Add(lbl1AdminProgress);
            Controls.Add(lblCategory);
            Controls.Add(lblTicketTitle);
            Controls.Add(pnlStats);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(64, 64, 64);
            Name = "userTicketStatusCheck";
            Text = "Ticket Status";
            ((System.ComponentModel.ISupportInitialize)pbStatusBar).EndInit();
            pnlStats.ResumeLayout(false);
            pnlStats.PerformLayout();
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
        private Button btnConfirm;
        private Label lbl1AdminProgress;
        private Label lbl2AdminProgress;
        private Label lbl3AdminProgress;
        private Label lbl4AdminProgress;
        private Label lbl5AdminProgress;
        private Label lbl6AdminProgress;
        private Label lblDesc;
        private TextBox txtLiveRemarks;
        private Label lblAdminName;
        private Label label1;
        private Button btnPost;
        private TextBox txtLiveRemarksPrev;
        private Label label2;
        private Panel pnlStats;
    }
}