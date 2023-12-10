namespace Individual_Project
{
    partial class LoginForm
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
			lblLogin = new Label();
			lblUsername = new Label();
			lblPassword = new Label();
			tBUsername = new TextBox();
			tBPassword = new TextBox();
			btnLogin = new Button();
			SuspendLayout();
			// 
			// lblLogin
			// 
			lblLogin.AutoSize = true;
			lblLogin.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			lblLogin.Location = new Point(206, 27);
			lblLogin.Name = "lblLogin";
			lblLogin.Size = new Size(65, 26);
			lblLogin.TabIndex = 0;
			lblLogin.Text = "Login";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
			lblUsername.Location = new Point(68, 127);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(119, 26);
			lblUsername.TabIndex = 1;
			lblUsername.Text = "Username:";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
			lblPassword.Location = new Point(73, 162);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(114, 26);
			lblPassword.TabIndex = 2;
			lblPassword.Text = "Password:";
			// 
			// tBUsername
			// 
			tBUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			tBUsername.Location = new Point(193, 127);
			tBUsername.Name = "tBUsername";
			tBUsername.Size = new Size(141, 29);
			tBUsername.TabIndex = 3;
			// 
			// tBPassword
			// 
			tBPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			tBPassword.Location = new Point(193, 160);
			tBPassword.Name = "tBPassword";
			tBPassword.PasswordChar = '◉';
			tBPassword.Size = new Size(141, 29);
			tBPassword.TabIndex = 4;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.YellowGreen;
			btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogin.Location = new Point(162, 269);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(138, 47);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// LoginForm
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(486, 415);
			Controls.Add(btnLogin);
			Controls.Add(tBPassword);
			Controls.Add(tBUsername);
			Controls.Add(lblPassword);
			Controls.Add(lblUsername);
			Controls.Add(lblLogin);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tBUsername;
        private TextBox tBPassword;
        private Button btnLogin;
    }
}

