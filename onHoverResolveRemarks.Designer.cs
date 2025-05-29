namespace IT_Helpdesk
{
    partial class onHoverResolveRemarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onHoverResolveRemarks));
            txtResolveRemarks = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResolveRemarks
            // 
            txtResolveRemarks.BorderStyle = BorderStyle.None;
            txtResolveRemarks.Font = new Font("Segoe UI", 10F);
            txtResolveRemarks.Location = new Point(12, 42);
            txtResolveRemarks.Multiline = true;
            txtResolveRemarks.Name = "txtResolveRemarks";
            txtResolveRemarks.ReadOnly = true;
            txtResolveRemarks.Size = new Size(323, 270);
            txtResolveRemarks.TabIndex = 0;
            txtResolveRemarks.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 1;
            label1.Text = "Resolve Remarks";
            // 
            // onHoverResolveRemarks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(347, 324);
            Controls.Add(label1);
            Controls.Add(txtResolveRemarks);
            Name = "onHoverResolveRemarks";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResolveRemarks;
        private Label label1;
    }
}