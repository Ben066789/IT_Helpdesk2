namespace IT_Helpdesk
{
    partial class ReassignForm
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
            btnCancel = new Button();
            btnReassign = new Button();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // comboBoxAdmins
            // 
            comboBoxAdmins.FormattingEnabled = true;
            comboBoxAdmins.Location = new Point(12, 20);
            comboBoxAdmins.Name = "comboBoxAdmins";
            comboBoxAdmins.Size = new Size(224, 23);
            comboBoxAdmins.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 171);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 33);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReassign
            // 
            btnReassign.Location = new Point(127, 171);
            btnReassign.Name = "btnReassign";
            btnReassign.Size = new Size(109, 33);
            btnReassign.TabIndex = 1;
            btnReassign.Text = "Reassign";
            btnReassign.UseVisualStyleBackColor = true;
            btnReassign.Click += reassignBtn_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 49);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Reason for reassigning...";
            txtDescription.Size = new Size(224, 116);
            txtDescription.TabIndex = 2;
            // 
            // ReassignForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 216);
            Controls.Add(txtDescription);
            Controls.Add(btnReassign);
            Controls.Add(btnCancel);
            Controls.Add(comboBoxAdmins);
            Name = "ReassignForm";
            Text = "Reassign Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAdmins;
        private Button btnCancel;
        private Button btnReassign;
        private TextBox txtDescription;
    }
}