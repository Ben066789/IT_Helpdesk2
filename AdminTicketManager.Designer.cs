﻿namespace IT_Helpdesk
// No direct type usage for userId is typical in designer files.
// If you have any event handler or instantiation that passes userId, ensure the parameter is now string instead of int.
// For example, if you see:
// this.someButton.Click += new System.EventHandler(this.SomeHandler);
// And SomeHandler expects (int userId), change it to (string userId).
// Otherwise, no changes are needed here.
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
            btnShowHideResolved = new Button();
            btnProgRemarkPost = new Button();
            cmbStatus = new ComboBox();
            txtResolveRemarks = new TextBox();
            txtProgRemarks = new TextBox();
            label3 = new Label();
            lblStatus = new Label();
            label2 = new Label();
            label4 = new Label();
            pnlProgressRemarksPrev = new Panel();
            btnClear = new Button();
            label1 = new Label();
            lbInProgRemarksPrev = new Label();
            timeDate6 = new Label();
            timeDate5 = new Label();
            timeDate4 = new Label();
            timeDate3 = new Label();
            timeDate2 = new Label();
            timeDate1 = new Label();
            txtRemark6 = new TextBox();
            txtRemark5 = new TextBox();
            txtRemark4 = new TextBox();
            txtRemark3 = new TextBox();
            txtRemark2 = new TextBox();
            txtRemark1 = new TextBox();
            pnlResolvedRemarksPrev = new Panel();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            pngExtraRemarks = new Panel();
            txtExtraRemarks = new TextBox();
            label7 = new Label();
            pnlOnHold = new Panel();
            dateTimeUntilOnHold = new DateTimePicker();
            btnPostOnHold = new Button();
            label9 = new Label();
            label8 = new Label();
            txtBoxOnHold = new TextBox();
            pnlReassignBG.SuspendLayout();
            pnlTicketInfo.SuspendLayout();
            pnlProgressUpdater.SuspendLayout();
            pnlProgressRemarksPrev.SuspendLayout();
            pnlResolvedRemarksPrev.SuspendLayout();
            pngExtraRemarks.SuspendLayout();
            pnlOnHold.SuspendLayout();
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
            pnlReassignBG.Location = new Point(12, 11);
            pnlReassignBG.Name = "pnlReassignBG";
            pnlReassignBG.Size = new Size(265, 224);
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
            lblPriorityLbl.Location = new Point(197, 37);
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
            lblPriority.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblPriority.Location = new Point(195, 18);
            lblPriority.Name = "lblPriority";
            lblPriority.RightToLeft = RightToLeft.Yes;
            lblPriority.Size = new Size(59, 19);
            lblPriority.TabIndex = 0;
            lblPriority.Text = "Priority";
            lblPriority.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTicketTitle
            // 
            lblTicketTitle.AutoSize = true;
            lblTicketTitle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTicketTitle.Location = new Point(10, 18);
            lblTicketTitle.Name = "lblTicketTitle";
            lblTicketTitle.Size = new Size(86, 19);
            lblTicketTitle.TabIndex = 0;
            lblTicketTitle.Text = "Ticket Title";
            // 
            // pnlProgressUpdater
            // 
            pnlProgressUpdater.BackColor = Color.AliceBlue;
            pnlProgressUpdater.Controls.Add(btnResolvePost);
            pnlProgressUpdater.Controls.Add(btnShowHideResolved);
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
            btnResolvePost.Click += btnResolvePost_Click;
            // 
            // btnShowHideResolved
            // 
            btnShowHideResolved.BackColor = Color.Gainsboro;
            btnShowHideResolved.Location = new Point(176, 269);
            btnShowHideResolved.Name = "btnShowHideResolved";
            btnShowHideResolved.Size = new Size(81, 23);
            btnShowHideResolved.TabIndex = 1;
            btnShowHideResolved.Text = "---";
            btnShowHideResolved.UseVisualStyleBackColor = false;
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
            cmbStatus.Items.AddRange(new object[] { "On Hold", "In Progress", "Resolved" });
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
            // pnlProgressRemarksPrev
            // 
            pnlProgressRemarksPrev.BackColor = Color.LightSteelBlue;
            pnlProgressRemarksPrev.Controls.Add(btnClear);
            pnlProgressRemarksPrev.Controls.Add(label1);
            pnlProgressRemarksPrev.Controls.Add(lbInProgRemarksPrev);
            pnlProgressRemarksPrev.Controls.Add(timeDate6);
            pnlProgressRemarksPrev.Controls.Add(timeDate5);
            pnlProgressRemarksPrev.Controls.Add(timeDate4);
            pnlProgressRemarksPrev.Controls.Add(timeDate3);
            pnlProgressRemarksPrev.Controls.Add(timeDate2);
            pnlProgressRemarksPrev.Controls.Add(timeDate1);
            pnlProgressRemarksPrev.Controls.Add(txtRemark6);
            pnlProgressRemarksPrev.Controls.Add(txtRemark5);
            pnlProgressRemarksPrev.Controls.Add(txtRemark4);
            pnlProgressRemarksPrev.Controls.Add(txtRemark3);
            pnlProgressRemarksPrev.Controls.Add(txtRemark2);
            pnlProgressRemarksPrev.Controls.Add(txtRemark1);
            pnlProgressRemarksPrev.Location = new Point(561, 12);
            pnlProgressRemarksPrev.Name = "pnlProgressRemarksPrev";
            pnlProgressRemarksPrev.Size = new Size(232, 438);
            pnlProgressRemarksPrev.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(14, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "Preview";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // lbInProgRemarksPrev
            // 
            lbInProgRemarksPrev.AutoSize = true;
            lbInProgRemarksPrev.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            lbInProgRemarksPrev.Location = new Point(13, 9);
            lbInProgRemarksPrev.Name = "lbInProgRemarksPrev";
            lbInProgRemarksPrev.RightToLeft = RightToLeft.Yes;
            lbInProgRemarksPrev.Size = new Size(152, 18);
            lbInProgRemarksPrev.TabIndex = 0;
            lbInProgRemarksPrev.Text = "In Progress Remarks";
            lbInProgRemarksPrev.TextAlign = ContentAlignment.TopRight;
            // 
            // timeDate6
            // 
            timeDate6.AutoSize = true;
            timeDate6.BackColor = Color.Transparent;
            timeDate6.ForeColor = Color.DimGray;
            timeDate6.Location = new Point(110, 390);
            timeDate6.Name = "timeDate6";
            timeDate6.Size = new Size(38, 15);
            timeDate6.TabIndex = 8;
            timeDate6.Text = "label1";
            // 
            // timeDate5
            // 
            timeDate5.AutoSize = true;
            timeDate5.BackColor = Color.Transparent;
            timeDate5.ForeColor = Color.DimGray;
            timeDate5.Location = new Point(110, 328);
            timeDate5.Name = "timeDate5";
            timeDate5.Size = new Size(38, 15);
            timeDate5.TabIndex = 9;
            timeDate5.Text = "label1";
            // 
            // timeDate4
            // 
            timeDate4.AutoSize = true;
            timeDate4.BackColor = Color.Transparent;
            timeDate4.ForeColor = Color.DimGray;
            timeDate4.Location = new Point(110, 268);
            timeDate4.Name = "timeDate4";
            timeDate4.Size = new Size(38, 15);
            timeDate4.TabIndex = 10;
            timeDate4.Text = "label1";
            // 
            // timeDate3
            // 
            timeDate3.AutoSize = true;
            timeDate3.BackColor = Color.Transparent;
            timeDate3.ForeColor = Color.DimGray;
            timeDate3.Location = new Point(110, 208);
            timeDate3.Name = "timeDate3";
            timeDate3.Size = new Size(38, 15);
            timeDate3.TabIndex = 11;
            timeDate3.Text = "label1";
            // 
            // timeDate2
            // 
            timeDate2.AutoSize = true;
            timeDate2.BackColor = Color.Transparent;
            timeDate2.ForeColor = Color.DimGray;
            timeDate2.Location = new Point(110, 148);
            timeDate2.Name = "timeDate2";
            timeDate2.Size = new Size(38, 15);
            timeDate2.TabIndex = 12;
            timeDate2.Text = "label1";
            // 
            // timeDate1
            // 
            timeDate1.AutoSize = true;
            timeDate1.BackColor = Color.Transparent;
            timeDate1.ForeColor = Color.DimGray;
            timeDate1.Location = new Point(110, 87);
            timeDate1.Name = "timeDate1";
            timeDate1.Size = new Size(38, 15);
            timeDate1.TabIndex = 13;
            timeDate1.Text = "label1";
            // 
            // txtRemark6
            // 
            txtRemark6.BackColor = SystemColors.Control;
            txtRemark6.BorderStyle = BorderStyle.None;
            txtRemark6.Font = new Font("Segoe UI", 12F);
            txtRemark6.Location = new Point(14, 348);
            txtRemark6.Multiline = true;
            txtRemark6.Name = "txtRemark6";
            txtRemark6.ReadOnly = true;
            txtRemark6.Size = new Size(202, 39);
            txtRemark6.TabIndex = 2;
            txtRemark6.TabStop = false;
            // 
            // txtRemark5
            // 
            txtRemark5.BackColor = SystemColors.Control;
            txtRemark5.BorderStyle = BorderStyle.None;
            txtRemark5.Font = new Font("Segoe UI", 12F);
            txtRemark5.Location = new Point(14, 286);
            txtRemark5.Multiline = true;
            txtRemark5.Name = "txtRemark5";
            txtRemark5.ReadOnly = true;
            txtRemark5.Size = new Size(202, 39);
            txtRemark5.TabIndex = 3;
            txtRemark5.TabStop = false;
            // 
            // txtRemark4
            // 
            txtRemark4.BackColor = SystemColors.Control;
            txtRemark4.BorderStyle = BorderStyle.None;
            txtRemark4.Font = new Font("Segoe UI", 12F);
            txtRemark4.Location = new Point(14, 226);
            txtRemark4.Multiline = true;
            txtRemark4.Name = "txtRemark4";
            txtRemark4.ReadOnly = true;
            txtRemark4.Size = new Size(202, 39);
            txtRemark4.TabIndex = 4;
            txtRemark4.TabStop = false;
            // 
            // txtRemark3
            // 
            txtRemark3.BackColor = SystemColors.Control;
            txtRemark3.BorderStyle = BorderStyle.None;
            txtRemark3.Font = new Font("Segoe UI", 12F);
            txtRemark3.Location = new Point(14, 167);
            txtRemark3.Multiline = true;
            txtRemark3.Name = "txtRemark3";
            txtRemark3.ReadOnly = true;
            txtRemark3.Size = new Size(202, 39);
            txtRemark3.TabIndex = 5;
            txtRemark3.TabStop = false;
            // 
            // txtRemark2
            // 
            txtRemark2.BackColor = SystemColors.Control;
            txtRemark2.BorderStyle = BorderStyle.None;
            txtRemark2.Font = new Font("Segoe UI", 12F);
            txtRemark2.Location = new Point(14, 106);
            txtRemark2.Multiline = true;
            txtRemark2.Name = "txtRemark2";
            txtRemark2.ReadOnly = true;
            txtRemark2.Size = new Size(202, 39);
            txtRemark2.TabIndex = 6;
            txtRemark2.TabStop = false;
            // 
            // txtRemark1
            // 
            txtRemark1.BackColor = SystemColors.Control;
            txtRemark1.BorderStyle = BorderStyle.None;
            txtRemark1.Font = new Font("Segoe UI", 12F);
            txtRemark1.Location = new Point(14, 45);
            txtRemark1.Multiline = true;
            txtRemark1.Name = "txtRemark1";
            txtRemark1.ReadOnly = true;
            txtRemark1.Size = new Size(202, 39);
            txtRemark1.TabIndex = 7;
            txtRemark1.TabStop = false;
            // 
            // pnlResolvedRemarksPrev
            // 
            pnlResolvedRemarksPrev.Controls.Add(label6);
            pnlResolvedRemarksPrev.Controls.Add(textBox1);
            pnlResolvedRemarksPrev.Controls.Add(label5);
            pnlResolvedRemarksPrev.Location = new Point(561, 250);
            pnlResolvedRemarksPrev.Name = "pnlResolvedRemarksPrev";
            pnlResolvedRemarksPrev.Size = new Size(232, 200);
            pnlResolvedRemarksPrev.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(9, 27);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(56, 17);
            label6.TabIndex = 0;
            label6.Text = "Preview";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(214, 139);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label5.Location = new Point(8, 11);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(142, 18);
            label5.TabIndex = 0;
            label5.Text = "Resolved Remarks";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // pngExtraRemarks
            // 
            pngExtraRemarks.BackColor = Color.AliceBlue;
            pngExtraRemarks.Controls.Add(txtExtraRemarks);
            pngExtraRemarks.Controls.Add(label7);
            pngExtraRemarks.Location = new Point(12, 243);
            pngExtraRemarks.Name = "pngExtraRemarks";
            pngExtraRemarks.Size = new Size(265, 207);
            pngExtraRemarks.TabIndex = 8;
            // 
            // txtExtraRemarks
            // 
            txtExtraRemarks.BorderStyle = BorderStyle.None;
            txtExtraRemarks.Location = new Point(11, 34);
            txtExtraRemarks.Multiline = true;
            txtExtraRemarks.Name = "txtExtraRemarks";
            txtExtraRemarks.Size = new Size(243, 158);
            txtExtraRemarks.TabIndex = 1;
            txtExtraRemarks.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(8, 7);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(116, 19);
            label7.TabIndex = 0;
            label7.Text = "Extra Remarks";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlOnHold
            // 
            pnlOnHold.BackColor = SystemColors.GradientActiveCaption;
            pnlOnHold.Controls.Add(dateTimeUntilOnHold);
            pnlOnHold.Controls.Add(btnPostOnHold);
            pnlOnHold.Controls.Add(label9);
            pnlOnHold.Controls.Add(label8);
            pnlOnHold.Controls.Add(txtBoxOnHold);
            pnlOnHold.Location = new Point(561, 12);
            pnlOnHold.Name = "pnlOnHold";
            pnlOnHold.Size = new Size(232, 246);
            pnlOnHold.TabIndex = 15;
            // 
            // dateTimeUntilOnHold
            // 
            dateTimeUntilOnHold.Location = new Point(10, 166);
            dateTimeUntilOnHold.Name = "dateTimeUntilOnHold";
            dateTimeUntilOnHold.Size = new Size(213, 23);
            dateTimeUntilOnHold.TabIndex = 3;
            // 
            // btnPostOnHold
            // 
            btnPostOnHold.Location = new Point(148, 209);
            btnPostOnHold.Name = "btnPostOnHold";
            btnPostOnHold.Size = new Size(75, 23);
            btnPostOnHold.TabIndex = 2;
            btnPostOnHold.Text = "Post";
            btnPostOnHold.UseVisualStyleBackColor = true;
            btnPostOnHold.Click += btnPostOnHold_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label9.Location = new Point(7, 146);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(0, 18);
            label9.TabIndex = 0;
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label8.Location = new Point(7, 10);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(135, 18);
            label8.TabIndex = 0;
            label8.Text = "On Hold Remarks";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBoxOnHold
            // 
            txtBoxOnHold.AcceptsTab = true;
            txtBoxOnHold.Location = new Point(9, 37);
            txtBoxOnHold.Multiline = true;
            txtBoxOnHold.Name = "txtBoxOnHold";
            txtBoxOnHold.Size = new Size(214, 123);
            txtBoxOnHold.TabIndex = 1;
            txtBoxOnHold.TabStop = false;
            // 
            // AdminTicketManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IT_HelpdeskBG1;
            ClientSize = new Size(806, 463);
            Controls.Add(pnlOnHold);
            Controls.Add(pngExtraRemarks);
            Controls.Add(pnlResolvedRemarksPrev);
            Controls.Add(pnlProgressRemarksPrev);
            Controls.Add(pnlReassignBG);
            Controls.Add(pnlProgressUpdater);
            Controls.Add(pnlTicketInfo);
            Name = "AdminTicketManager";
            Text = "Ticket Manager";
            pnlReassignBG.ResumeLayout(false);
            pnlReassignBG.PerformLayout();
            pnlTicketInfo.ResumeLayout(false);
            pnlTicketInfo.PerformLayout();
            pnlProgressUpdater.ResumeLayout(false);
            pnlProgressUpdater.PerformLayout();
            pnlProgressRemarksPrev.ResumeLayout(false);
            pnlProgressRemarksPrev.PerformLayout();
            pnlResolvedRemarksPrev.ResumeLayout(false);
            pnlResolvedRemarksPrev.PerformLayout();
            pngExtraRemarks.ResumeLayout(false);
            pngExtraRemarks.PerformLayout();
            pnlOnHold.ResumeLayout(false);
            pnlOnHold.PerformLayout();
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
        private Panel pnlProgressRemarksPrev;
        private Label lbInProgRemarksPrev;
        private Label timeDate6;
        private Label timeDate5;
        private Label timeDate4;
        private Label timeDate3;
        private Label timeDate2;
        private Label timeDate1;
        private TextBox txtRemark6;
        private TextBox txtRemark5;
        private TextBox txtRemark4;
        private TextBox txtRemark3;
        private TextBox txtRemark2;
        private TextBox txtRemark1;
        private Label label1;
        private Button btnShowHideResolved;
        private Panel pnlResolvedRemarksPrev;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Panel pngExtraRemarks;
        private Label label7;
        private TextBox txtExtraRemarks;
        private Button btnClear;
        private Panel pnlOnHold;
        private Label label8;
        private Button btnPostOnHold;
        private TextBox txtBoxOnHold;
        private DateTimePicker dateTimeUntilOnHold;
        private Label label9;
    }
}