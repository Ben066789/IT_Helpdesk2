namespace IT_Helpdesk
{
    partial class CreateTicketForm
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
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbCategory = new ComboBox();
            label3 = new Label();
            cmbPriority = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            cmbDepartment = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 371);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(267, 150);
            txtDescription.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Technical Issue", "Software Request", "Hardware Issue", "Network Problem", "Access Request", "Account/Password Issue", "Maintenance Request", "Facility Issue", "General Inquiry" });
            cmbCategory.Location = new Point(12, 141);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(171, 23);
            cmbCategory.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 258);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Normal", "High", "Urgent" });
            cmbPriority.Location = new Point(12, 276);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(171, 23);
            cmbPriority.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 353);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 1;
            label4.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(108, 546);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 546);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Human Resources", "Finance", "Administration", "Operations", "Customer Service", "Maintenance" });
            cmbDepartment.Location = new Point(12, 206);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(171, 23);
            cmbDepartment.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 1;
            label5.Text = "Department";
            // 
            // CreateTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 602);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cmbDepartment);
            Controls.Add(cmbPriority);
            Controls.Add(cmbCategory);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(txtDescription);
            Name = "CreateTicketForm";
            Load += CreateTicketForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private ComboBox cmbCategory;
        private Label label3;
        private ComboBox cmbPriority;
        private Label label4;
        private TextBox textBox1;
        private Button btnSubmit;
        private Button btnCancel;
        private ComboBox cmbDepartment;
        private Label label5;
    }
}