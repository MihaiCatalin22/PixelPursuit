namespace Individual_Project
{
    partial class UserDetailsForm
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
			lblUserInfo = new Label();
			lblUsername = new Label();
			lblEmail = new Label();
			lblRegDate = new Label();
			lblBio = new Label();
			lblBanned = new Label();
			btnBack = new Button();
			SuspendLayout();
			// 
			// lblUserInfo
			// 
			lblUserInfo.AutoSize = true;
			lblUserInfo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			lblUserInfo.Location = new Point(164, 16);
			lblUserInfo.Name = "lblUserInfo";
			lblUserInfo.Size = new Size(172, 26);
			lblUserInfo.TabIndex = 0;
			lblUserInfo.Text = "User information";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblUsername.Location = new Point(132, 61);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(111, 24);
			lblUsername.TabIndex = 1;
			lblUsername.Text = "Username:";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblEmail.Location = new Point(175, 96);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(68, 24);
			lblEmail.TabIndex = 2;
			lblEmail.Text = "Email:";
			// 
			// lblRegDate
			// 
			lblRegDate.AutoSize = true;
			lblRegDate.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblRegDate.Location = new Point(71, 130);
			lblRegDate.Name = "lblRegDate";
			lblRegDate.Size = new Size(172, 24);
			lblRegDate.TabIndex = 3;
			lblRegDate.Text = "Registration date:";
			// 
			// lblBio
			// 
			lblBio.AutoSize = true;
			lblBio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblBio.Location = new Point(197, 165);
			lblBio.Name = "lblBio";
			lblBio.Size = new Size(46, 24);
			lblBio.TabIndex = 4;
			lblBio.Text = "Bio:";
			// 
			// lblBanned
			// 
			lblBanned.AutoSize = true;
			lblBanned.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblBanned.Location = new Point(232, 210);
			lblBanned.Name = "lblBanned";
			lblBanned.Size = new Size(0, 24);
			lblBanned.TabIndex = 5;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Turquoise;
			btnBack.Location = new Point(197, 255);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(95, 50);
			btnBack.TabIndex = 7;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// UserDetailsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(553, 331);
			Controls.Add(btnBack);
			Controls.Add(lblBanned);
			Controls.Add(lblBio);
			Controls.Add(lblRegDate);
			Controls.Add(lblEmail);
			Controls.Add(lblUsername);
			Controls.Add(lblUserInfo);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "UserDetailsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "User Details";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblUserInfo;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblRegDate;
        private Label lblBio;
        private Label lblBanned;
        private Button btnBack;
	}
}