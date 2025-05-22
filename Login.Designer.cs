namespace IT_Helpdesk
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(12, 307);
            username.Name = "username";
            username.Size = new Size(170, 23);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(12, 360);
            password.Name = "password";
            password.Size = new Size(170, 23);
            password.TabIndex = 0;
            password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 289);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 342);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(12, 398);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.Click += loginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.itHelpdeskLogo;
            pictureBox1.Location = new Point(12, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 327);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IT_HelpdeskBG;
            ClientSize = new Size(432, 450);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login - IT Helpdesk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Button loginButton;
        private PictureBox pictureBox1;
    }
}
