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
            label1 = new Label();
            createButton = new Button();
            dataGridView1 = new DataGridView();
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "user";
            // 
            // createButton
            // 
            createButton.Location = new Point(27, 79);
            createButton.Name = "createButton";
            createButton.Size = new Size(119, 45);
            createButton.TabIndex = 1;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(900, 214);
            dataGridView1.TabIndex = 2;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Gainsboro;
            logoutBtn.Location = new Point(968, 24);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(119, 30);
            logoutBtn.TabIndex = 1;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 686);
            Controls.Add(dataGridView1);
            Controls.Add(logoutBtn);
            Controls.Add(createButton);
            Controls.Add(label1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button createButton;
        private DataGridView dataGridView1;
        private Button logoutBtn;
    }
}