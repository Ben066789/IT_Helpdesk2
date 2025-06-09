namespace IT_Helpdesk
{
    partial class onHoverOnHoldRemarks
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
            txtBoxOnHoldRemarks = new TextBox();
            label = new Label();
            lblOnHoldUntil = new Label();
            SuspendLayout();
            // 
            // txtBoxOnHoldRemarks
            // 
            txtBoxOnHoldRemarks.AcceptsTab = true;
            txtBoxOnHoldRemarks.Font = new Font("Segoe UI", 11F);
            txtBoxOnHoldRemarks.Location = new Point(12, 52);
            txtBoxOnHoldRemarks.Multiline = true;
            txtBoxOnHoldRemarks.Name = "txtBoxOnHoldRemarks";
            txtBoxOnHoldRemarks.ReadOnly = true;
            txtBoxOnHoldRemarks.Size = new Size(311, 111);
            txtBoxOnHoldRemarks.TabIndex = 0;
            txtBoxOnHoldRemarks.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(8, 9);
            label.Name = "label";
            label.Size = new Size(168, 25);
            label.TabIndex = 1;
            label.Text = "On Hold Remarks";
            // 
            // lblOnHoldUntil
            // 
            lblOnHoldUntil.AutoSize = true;
            lblOnHoldUntil.Location = new Point(12, 34);
            lblOnHoldUntil.Name = "lblOnHoldUntil";
            lblOnHoldUntil.Size = new Size(38, 15);
            lblOnHoldUntil.TabIndex = 2;
            lblOnHoldUntil.Text = "label2";
            // 
            // onHoverOnHoldRemarks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(335, 186);
            Controls.Add(lblOnHoldUntil);
            Controls.Add(label);
            Controls.Add(txtBoxOnHoldRemarks);
            Name = "onHoverOnHoldRemarks";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxOnHoldRemarks;
        private Label label;
        private Label lblOnHoldUntil;
    }
}