namespace IT_Helpdesk
{
    partial class AdminTicketManager
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
            comboBoxAdmins = new ComboBox();
            btnReassign = new Button();
            txtDescription = new TextBox();
            pnlReassignBG = new Panel();
            btnCancelReassign = new Button();
            lblReassign = new Label();
            pnlTicketInfo = new Panel();
            txtbxDescription = new TextBox();
            btnShowReassign = new Button();
            btnAcceptTicket = new Button();
            lblPriorityLbl = new Label();
            lblDateCreated = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblPriority = new Label();
            lblTicketTitle = new Label();
            pnlProgressUpdater = new Panel();
            btnResolvePost = new Button();
            btnProgRemarkPost = new Button();
            cmbStatus = new ComboBox();
            txtResolveRemarks = new TextBox();
            txtProgRemarks = new TextBox();
            label3 = new Label();
            lblStatus = new Label();
            label2 = new Label();
            label4 = new Label();
            pnlReassignBG.SuspendLayout();
            pnlTicketInfo.SuspendLayout();
            pnlProgressUpdater.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxAdmins
            // 
            comboBoxAdmins.FormattingEnabled = true;
            comboBoxAdmins.Location = new Point(12, 51);
            comboBoxAdmins.Name = "comboBoxAdmins";
            comboBoxAdmins.Size = new Size(224, 23);
            comboBoxAdmins.TabIndex = 0;
            // 
            // btnReassign
            // 
            btnReassign.Location = new Point(82, 180);
            btnReassign.Name = "btnReassign";
            btnReassign.Size = new Size(81, 23);
            btnReassign.TabIndex = 1;
            btnReassign.Text = "Reassign";
            btnReassign.UseVisualStyleBackColor = true;
            btnReassign.Click += reassignBtn_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(11, 80);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Reason for reassigning...";
            txtDescription.Size = new Size(243, 94);
            txtDescription.TabIndex = 2;
            // 
            // pnlReassignBG
            // 
            pnlReassignBG.BackColor = Color.LightSteelBlue;
            pnlReassignBG.Controls.Add(txtDescription);
            pnlReassignBG.Controls.Add(btnCancelReassign);
            pnlReassignBG.Controls.Add(btnReassign);
            pnlReassignBG.Controls.Add(lblReassign);
            pnlReassignBG.Controls.Add(comboBoxAdmins);
            pnlReassignBG.Location = new Point(12, 12);
            pnlReassignBG.Name = "pnlReassignBG";
            pnlReassignBG.Size = new Size(265, 220);
            pnlReassignBG.TabIndex = 3;
            // 
            // btnCancelReassign
            // 
            btnCancelReassign.Location = new Point(175, 180);
            btnCancelReassign.Name = "btnCancelReassign";
            btnCancelReassign.Size = new Size(81, 23);
            btnCancelReassign.TabIndex = 1;
            btnCancelReassign.Text = "Cancel";
            btnCancelReassign.UseVisualStyleBackColor = true;
            // 
            // lblReassign
            // 
            lblReassign.AutoSize = true;
            lblReassign.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReassign.Location = new Point(8, 18);
            lblReassign.Name = "lblReassign";
            lblReassign.Size = new Size(159, 23);
            lblReassign.TabIndex = 0;
            lblReassign.Text = "Reassign Ticket";
            // 
            // pnlTicketInfo
            // 
            pnlTicketInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlTicketInfo.BackColor = Color.AliceBlue;
            pnlTicketInfo.Controls.Add(txtbxDescription);
            pnlTicketInfo.Controls.Add(btnShowReassign);
            pnlTicketInfo.Controls.Add(btnAcceptTicket);
            pnlTicketInfo.Controls.Add(lblPriorityLbl);
            pnlTicketInfo.Controls.Add(lblDateCreated);
            pnlTicketInfo.Controls.Add(lblDescription);
            pnlTicketInfo.Controls.Add(lblCategory);
            pnlTicketInfo.Controls.Add(lblPriority);
            pnlTicketInfo.Controls.Add(lblTicketTitle);
            pnlTicketInfo.Location = new Point(12, 12);
            pnlTicketInfo.Name = "pnlTicketInfo";
            pnlTicketInfo.Size = new Size(265, 220);
            pnlTicketInfo.TabIndex = 4;
            // 
            // txtbxDescription
            // 
            txtbxDescription.Location = new Point(11, 79);
            txtbxDescription.Multiline = true;
            txtbxDescription.Name = "txtbxDescription";
            txtbxDescription.ReadOnly = true;
            txtbxDescription.ScrollBars = ScrollBars.Vertical;
            txtbxDescription.Size = new Size(243, 94);
            txtbxDescription.TabIndex = 5;
            // 
            // btnShowReassign
            // 
            btnShowReassign.BackColor = Color.Gainsboro;
            btnShowReassign.Location = new Point(82, 179);
            btnShowReassign.Name = "btnShowReassign";
            btnShowReassign.Size = new Size(81, 23);
            btnShowReassign.TabIndex = 1;
            btnShowReassign.Text = "Reassign";
            btnShowReassign.UseVisualStyleBackColor = false;
            // 
            // btnAcceptTicket
            // 
            btnAcceptTicket.BackColor = Color.Gainsboro;
            btnAcceptTicket.Location = new Point(175, 179);
            btnAcceptTicket.Name = "btnAcceptTicket";
            btnAcceptTicket.Size = new Size(81, 23);
            btnAcceptTicket.TabIndex = 1;
            btnAcceptTicket.Text = "Accept";
            btnAcceptTicket.UseVisualStyleBackColor = false;
            // 
            // lblPriorityLbl
            // 
            lblPriorityLbl.AutoSize = true;
            lblPriorityLbl.BackColor = Color.Transparent;
            lblPriorityLbl.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriorityLbl.ForeColor = SystemColors.ControlDarkDark;
            lblPriorityLbl.Location = new Point(197, 45);
            lblPriorityLbl.Name = "lblPriorityLbl";
            lblPriorityLbl.Size = new Size(57, 20);
            lblPriorityLbl.TabIndex = 0;
            lblPriorityLbl.Text = "Priority";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateCreated.ForeColor = SystemColors.ControlDarkDark;
            lblDateCreated.Location = new Point(11, 61);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(38, 17);
            lblDateCreated.TabIndex = 0;
            lblDateCreated.Text = "Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(10, 86);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(91, 18);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ControlDarkDark;
            lblCategory.Location = new Point(9, 40);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(179, 18);
            lblPriority.Name = "lblPriority";
            lblPriority.RightToLeft = RightToLeft.Yes;
            lblPriority.Size = new Size(74, 23);
            lblPriority.TabIndex = 0;
            lblPriority.Text = "Priority";
            lblPriority.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTicketTitle
            // 
            lblTicketTitle.AutoSize = true;
            lblTicketTitle.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicketTitle.Location = new Point(10, 18);
            lblTicketTitle.Name = "lblTicketTitle";
            lblTicketTitle.Size = new Size(110, 23);
            lblTicketTitle.TabIndex = 0;
            lblTicketTitle.Text = "Ticket Title";
            // 
            // pnlProgressUpdater
            // 
            pnlProgressUpdater.BackColor = Color.AliceBlue;
            pnlProgressUpdater.Controls.Add(btnResolvePost);
            pnlProgressUpdater.Controls.Add(btnProgRemarkPost);
            pnlProgressUpdater.Controls.Add(cmbStatus);
            pnlProgressUpdater.Controls.Add(txtResolveRemarks);
            pnlProgressUpdater.Controls.Add(txtProgRemarks);
            pnlProgressUpdater.Controls.Add(label3);
            pnlProgressUpdater.Controls.Add(lblStatus);
            pnlProgressUpdater.Controls.Add(label2);
            pnlProgressUpdater.Controls.Add(label4);
            pnlProgressUpdater.Location = new Point(283, 12);
            pnlProgressUpdater.Name = "pnlProgressUpdater";
            pnlProgressUpdater.Size = new Size(272, 438);
            pnlProgressUpdater.TabIndex = 5;
            // 
            // btnResolvePost
            // 
            btnResolvePost.BackColor = Color.Gainsboro;
            btnResolvePost.Location = new Point(176, 396);
            btnResolvePost.Name = "btnResolvePost";
            btnResolvePost.Size = new Size(81, 23);
            btnResolvePost.TabIndex = 1;
            btnResolvePost.Text = "Post";
            btnResolvePost.UseVisualStyleBackColor = false;
            // 
            // btnProgRemarkPost
            // 
            btnProgRemarkPost.BackColor = Color.Gainsboro;
            btnProgRemarkPost.Location = new Point(176, 231);
            btnProgRemarkPost.Name = "btnProgRemarkPost";
            btnProgRemarkPost.Size = new Size(81, 23);
            btnProgRemarkPost.TabIndex = 1;
            btnProgRemarkPost.Text = "Post";
            btnProgRemarkPost.UseVisualStyleBackColor = false;
            btnProgRemarkPost.Click += btnProgRemarkPost_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "In Progress", "Resolved" });
            cmbStatus.Location = new Point(14, 79);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(112, 23);
            cmbStatus.TabIndex = 2;
            // 
            // txtResolveRemarks
            // 
            txtResolveRemarks.Location = new Point(14, 296);
            txtResolveRemarks.Multiline = true;
            txtResolveRemarks.Name = "txtResolveRemarks";
            txtResolveRemarks.Size = new Size(243, 94);
            txtResolveRemarks.TabIndex = 1;
            // 
            // txtProgRemarks
            // 
            txtProgRemarks.Location = new Point(14, 131);
            txtProgRemarks.Multiline = true;
            txtProgRemarks.Name = "txtProgRemarks";
            txtProgRemarks.Size = new Size(243, 94);
            txtProgRemarks.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(149, 23);
            label3.TabIndex = 0;
            label3.Text = "Status Updater";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(14, 42);
            lblStatus.Name = "lblStatus";
            lblStatus.RightToLeft = RightToLeft.Yes;
            lblStatus.Size = new Size(52, 19);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(14, 271);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 0;
            label2.Text = "Resolved Remarks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(134, 19);
            label4.TabIndex = 0;
            label4.Text = "In Progress Remarks";
            // 
            // AdminTicketManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 560);
            Controls.Add(pnlReassignBG);
            Controls.Add(pnlProgressUpdater);
            Controls.Add(pnlTicketInfo);
            Name = "AdminTicketManager";
            Text = "Reassign Form";
            pnlReassignBG.ResumeLayout(false);
            pnlReassignBG.PerformLayout();
            pnlTicketInfo.ResumeLayout(false);
            pnlTicketInfo.PerformLayout();
            pnlProgressUpdater.ResumeLayout(false);
            pnlProgressUpdater.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxAdmins;
        private Button btnReassign;
        private TextBox txtDescription;
        private Panel pnlReassignBG;
        private Label lblReassign;
        private Panel pnlTicketInfo;
        private Label lblTicketTitle;
        private Label lblPriorityLbl;
        private Label lblCategory;
        private Label lblPriority;
        private Button btnAcceptTicket;
        private Label lblDateCreated;
        private TextBox txtbxDescription;
        private Label lblDescription;
        private Panel pnlProgressUpdater;
        private Label lblStatus;
        private TextBox txtProgRemarks;
        private Label label3;
        private Label label4;
        private Button btnProgRemarkPost;
        private ComboBox cmbStatus;
        private Button btnCancelReassign;
        private Button btnShowReassign;
        private Button btnResolvePost;
        private TextBox txtResolveRemarks;
        private Label label2;
    }
}