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
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(42, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(41, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "admin";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWelcome);
            Name = "AdminDashboard";
            Text = "Form2";
            Load += AdminDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
            //form closed
            //this.FormClosed += Form1_FormClosed;
        }

        #endregion

        private Label lblWelcome;
    }
}