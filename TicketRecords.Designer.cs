namespace IT_Helpdesk
{
    partial class TicketRecords
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
            allTicketRecords = new DataGridView();
            ticketRecordLbl = new Label();
            searchBar = new TextBox();
            searchBtn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)allTicketRecords).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // allTicketRecords
            // 
            allTicketRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allTicketRecords.Location = new Point(12, 72);
            allTicketRecords.Name = "allTicketRecords";
            allTicketRecords.RowHeadersVisible = false;
            allTicketRecords.Size = new Size(1093, 366);
            allTicketRecords.TabIndex = 0;
            // 
            // ticketRecordLbl
            // 
            ticketRecordLbl.AutoSize = true;
            ticketRecordLbl.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            ticketRecordLbl.Location = new Point(12, 19);
            ticketRecordLbl.Name = "ticketRecordLbl";
            ticketRecordLbl.Size = new Size(194, 37);
            ticketRecordLbl.TabIndex = 1;
            ticketRecordLbl.Text = "Ticket Records";
            // 
            // searchBar
            // 
            searchBar.Location = new Point(846, 33);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(213, 23);
            searchBar.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(1065, 33);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(40, 23);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Go";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click_1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(searchBar);
            panel1.Controls.Add(ticketRecordLbl);
            panel1.Controls.Add(allTicketRecords);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 450);
            panel1.TabIndex = 4;
            // 
            // TicketRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 450);
            Controls.Add(panel1);
            Name = "TicketRecords";
            Text = "TicketRecords";
            ((System.ComponentModel.ISupportInitialize)allTicketRecords).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView allTicketRecords;
        private Label ticketRecordLbl;
        private TextBox searchBar;
        private Button searchBtn;
        private Panel panel1;
    }
}