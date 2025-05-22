namespace IT_Helpdesk
{
    partial class History
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
            historyDataGrid = new DataGridView();
            label1 = new Label();
            backBtn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)historyDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // historyDataGrid
            // 
            historyDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDataGrid.Cursor = Cursors.No;
            historyDataGrid.Location = new Point(177, 50);
            historyDataGrid.Name = "historyDataGrid";
            historyDataGrid.ReadOnly = true;
            historyDataGrid.RowHeadersVisible = false;
            historyDataGrid.Size = new Size(1269, 243);
            historyDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 1;
            label1.Text = "History";
            // 
            // backBtn
            // 
            backBtn.ForeColor = SystemColors.ControlText;
            backBtn.Location = new Point(12, 50);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(159, 33);
            backBtn.TabIndex = 2;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackgroundImage = Properties.Resources.IT_HelpdeskBG;
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(historyDataGrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1456, 324);
            panel1.TabIndex = 3;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 324);
            Controls.Add(panel1);
            Name = "History";
            Text = "History";
            Load += History_Load_1;
            ((System.ComponentModel.ISupportInitialize)historyDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView historyDataGrid;
        private Label label1;
        private Button backBtn;
        private Panel panel1;
    }
}