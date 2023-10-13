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
            btnBan = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserInfo.Location = new Point(188, 22);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(222, 32);
            lblUserInfo.TabIndex = 0;
            lblUserInfo.Text = "User information";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(206, 101);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(248, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblRegDate
            // 
            lblRegDate.AutoSize = true;
            lblRegDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegDate.Location = new Point(151, 200);
            lblRegDate.Name = "lblRegDate";
            lblRegDate.Size = new Size(163, 25);
            lblRegDate.TabIndex = 3;
            lblRegDate.Text = "Registration date:";
            // 
            // lblBio
            // 
            lblBio.AutoSize = true;
            lblBio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBio.Location = new Point(268, 249);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(46, 25);
            lblBio.TabIndex = 4;
            lblBio.Text = "Bio:";
            // 
            // lblBanned
            // 
            lblBanned.AutoSize = true;
            lblBanned.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanned.Location = new Point(268, 296);
            lblBanned.Name = "lblBanned";
            lblBanned.Size = new Size(0, 25);
            lblBanned.TabIndex = 5;
            // 
            // btnBan
            // 
            btnBan.BackColor = Color.OrangeRed;
            btnBan.Location = new Point(358, 339);
            btnBan.Margin = new Padding(3, 4, 3, 4);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(109, 66);
            btnBan.TabIndex = 6;
            btnBan.Text = "Ban user";
            btnBan.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Turquoise;
            btnBack.Location = new Point(151, 339);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 66);
            btnBack.TabIndex = 7;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // UserDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 441);
            Controls.Add(btnBack);
            Controls.Add(btnBan);
            Controls.Add(lblBanned);
            Controls.Add(lblBio);
            Controls.Add(lblRegDate);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblUserInfo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnBan;
        private Button btnBack;
    }
}