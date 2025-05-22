namespace IT_Helpdesk
{
    partial class eeAccManager
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
            accountList = new DataGridView();
            createAccBtn = new Button();
            firstNameCreate = new TextBox();
            lastNameCreate = new TextBox();
            firstnameLbl = new Label();
            lastnameLbl = new Label();
            userNameCreate = new TextBox();
            usernameLbl = new Label();
            passwordCreate = new TextBox();
            passwordLbl = new Label();
            label1 = new Label();
            roleCmb = new ComboBox();
            roleLbl = new Label();
            deactivateBtn = new Button();
            reactivateBtn = new Button();
            searchBar = new TextBox();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)accountList).BeginInit();
            SuspendLayout();
            // 
            // accountList
            // 
            accountList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountList.Location = new Point(234, 51);
            accountList.Name = "accountList";
            accountList.RowHeadersVisible = false;
            accountList.ScrollBars = ScrollBars.Vertical;
            accountList.Size = new Size(579, 357);
            accountList.TabIndex = 0;
            // 
            // createAccBtn
            // 
            createAccBtn.Location = new Point(12, 329);
            createAccBtn.Name = "createAccBtn";
            createAccBtn.Size = new Size(114, 32);
            createAccBtn.TabIndex = 1;
            createAccBtn.Text = "Create";
            createAccBtn.UseVisualStyleBackColor = true;
            createAccBtn.Click += createAccBtn_Click;
            // 
            // firstNameCreate
            // 
            firstNameCreate.Location = new Point(12, 69);
            firstNameCreate.Name = "firstNameCreate";
            firstNameCreate.Size = new Size(196, 23);
            firstNameCreate.TabIndex = 2;
            // 
            // lastNameCreate
            // 
            lastNameCreate.Location = new Point(12, 123);
            lastNameCreate.Name = "lastNameCreate";
            lastNameCreate.Size = new Size(196, 23);
            lastNameCreate.TabIndex = 2;
            // 
            // firstnameLbl
            // 
            firstnameLbl.AutoSize = true;
            firstnameLbl.Location = new Point(12, 51);
            firstnameLbl.Name = "firstnameLbl";
            firstnameLbl.Size = new Size(64, 15);
            firstnameLbl.TabIndex = 3;
            firstnameLbl.Text = "First Name";
            // 
            // lastnameLbl
            // 
            lastnameLbl.AutoSize = true;
            lastnameLbl.Location = new Point(13, 105);
            lastnameLbl.Name = "lastnameLbl";
            lastnameLbl.Size = new Size(63, 15);
            lastnameLbl.TabIndex = 3;
            lastnameLbl.Text = "Last Name";
            // 
            // userNameCreate
            // 
            userNameCreate.Location = new Point(13, 180);
            userNameCreate.Name = "userNameCreate";
            userNameCreate.Size = new Size(196, 23);
            userNameCreate.TabIndex = 2;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Location = new Point(13, 162);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(60, 15);
            usernameLbl.TabIndex = 3;
            usernameLbl.Text = "Username";
            // 
            // passwordCreate
            // 
            passwordCreate.Location = new Point(13, 235);
            passwordCreate.Name = "passwordCreate";
            passwordCreate.Size = new Size(196, 23);
            passwordCreate.TabIndex = 2;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(12, 217);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(57, 15);
            passwordLbl.TabIndex = 3;
            passwordLbl.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 3;
            label1.Text = "Create an Account";
            // 
            // roleCmb
            // 
            roleCmb.FormattingEnabled = true;
            roleCmb.Items.AddRange(new object[] { "Admin", "User" });
            roleCmb.Location = new Point(13, 290);
            roleCmb.Name = "roleCmb";
            roleCmb.Size = new Size(113, 23);
            roleCmb.TabIndex = 4;
            // 
            // roleLbl
            // 
            roleLbl.AutoSize = true;
            roleLbl.Location = new Point(13, 272);
            roleLbl.Name = "roleLbl";
            roleLbl.Size = new Size(30, 15);
            roleLbl.TabIndex = 3;
            roleLbl.Text = "Role";
            // 
            // deactivateBtn
            // 
            deactivateBtn.BackColor = Color.LightCoral;
            deactivateBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            deactivateBtn.Location = new Point(13, 376);
            deactivateBtn.Name = "deactivateBtn";
            deactivateBtn.Size = new Size(90, 32);
            deactivateBtn.TabIndex = 1;
            deactivateBtn.Text = "Deactivate";
            deactivateBtn.UseVisualStyleBackColor = false;
            deactivateBtn.Click += deactivateBtn_Click;
            // 
            // reactivateBtn
            // 
            reactivateBtn.BackColor = Color.Gainsboro;
            reactivateBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            reactivateBtn.Location = new Point(118, 376);
            reactivateBtn.Name = "reactivateBtn";
            reactivateBtn.Size = new Size(90, 32);
            reactivateBtn.TabIndex = 1;
            reactivateBtn.Text = "Reactivate";
            reactivateBtn.UseVisualStyleBackColor = false;
            reactivateBtn.Click += reactivateBtn_Click;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(608, 17);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search";
            searchBar.Size = new Size(159, 23);
            searchBar.TabIndex = 5;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(773, 16);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(40, 23);
            searchBtn.TabIndex = 6;
            searchBtn.Text = "Go";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // eeAccManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IT_HelpdeskBG;
            ClientSize = new Size(825, 429);
            Controls.Add(searchBtn);
            Controls.Add(searchBar);
            Controls.Add(roleCmb);
            Controls.Add(roleLbl);
            Controls.Add(passwordLbl);
            Controls.Add(usernameLbl);
            Controls.Add(lastnameLbl);
            Controls.Add(label1);
            Controls.Add(firstnameLbl);
            Controls.Add(passwordCreate);
            Controls.Add(userNameCreate);
            Controls.Add(lastNameCreate);
            Controls.Add(firstNameCreate);
            Controls.Add(reactivateBtn);
            Controls.Add(deactivateBtn);
            Controls.Add(createAccBtn);
            Controls.Add(accountList);
            Name = "eeAccManager";
            Text = "Account Manager - IT Helpdesk";
            Load += eeAccManager_Load;
            ((System.ComponentModel.ISupportInitialize)accountList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView accountList;
        private Button createAccBtn;
        private TextBox firstNameCreate;
        private TextBox lastNameCreate;
        private Label firstnameLbl;
        private Label lastnameLbl;
        private TextBox userNameCreate;
        private Label usernameLbl;
        private TextBox passwordCreate;
        private Label passwordLbl;
        private Label label1;
        private ComboBox roleCmb;
        private Label roleLbl;
        private Button deactivateBtn;
        private Button reactivateBtn;
        private TextBox searchBar;
        private Button searchBtn;
    }
}