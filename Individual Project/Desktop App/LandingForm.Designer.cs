namespace Individual_Project
{
    partial class LandingForm
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
            btnGames = new Button();
            btnSubmissions = new Button();
            btnUsers = new Button();
            btnBans = new Button();
            btnLogout = new Button();
            lblWelcome = new Label();
            gbSubmAnnouncement = new GroupBox();
            lblSubmAnnouncement = new Label();
            btnSubmAnnouncement = new Button();
            gbBans = new GroupBox();
            lblUsersBanned = new Label();
            btnInfoBans = new Button();
            gbSubmAnnouncement.SuspendLayout();
            gbBans.SuspendLayout();
            SuspendLayout();
            // 
            // btnGames
            // 
            btnGames.BackColor = Color.DeepSkyBlue;
            btnGames.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGames.Location = new Point(12, 15);
            btnGames.Margin = new Padding(3, 4, 3, 4);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(213, 121);
            btnGames.TabIndex = 0;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            // 
            // btnSubmissions
            // 
            btnSubmissions.BackColor = Color.Aqua;
            btnSubmissions.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmissions.Location = new Point(232, 15);
            btnSubmissions.Margin = new Padding(3, 4, 3, 4);
            btnSubmissions.Name = "btnSubmissions";
            btnSubmissions.Size = new Size(213, 121);
            btnSubmissions.TabIndex = 1;
            btnSubmissions.Text = "Submissions";
            btnSubmissions.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Turquoise;
            btnUsers.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.Location = new Point(451, 15);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(213, 121);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnBans
            // 
            btnBans.BackColor = Color.DarkCyan;
            btnBans.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBans.Location = new Point(670, 15);
            btnBans.Margin = new Padding(3, 4, 3, 4);
            btnBans.Name = "btnBans";
            btnBans.Size = new Size(213, 121);
            btnBans.TabIndex = 3;
            btnBans.Text = "Bans";
            btnBans.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Tomato;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(885, 15);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 121);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(381, 176);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(274, 32);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Welcome, ~~user~~!";
            // 
            // gbSubmAnnouncement
            // 
            gbSubmAnnouncement.Controls.Add(lblSubmAnnouncement);
            gbSubmAnnouncement.Controls.Add(btnSubmAnnouncement);
            gbSubmAnnouncement.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbSubmAnnouncement.Location = new Point(75, 356);
            gbSubmAnnouncement.Margin = new Padding(3, 4, 3, 4);
            gbSubmAnnouncement.Name = "gbSubmAnnouncement";
            gbSubmAnnouncement.Padding = new Padding(3, 4, 3, 4);
            gbSubmAnnouncement.Size = new Size(370, 200);
            gbSubmAnnouncement.TabIndex = 6;
            gbSubmAnnouncement.TabStop = false;
            gbSubmAnnouncement.Text = "New submissions";
            // 
            // lblSubmAnnouncement
            // 
            lblSubmAnnouncement.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubmAnnouncement.Location = new Point(32, 36);
            lblSubmAnnouncement.Name = "lblSubmAnnouncement";
            lblSubmAnnouncement.Size = new Size(317, 76);
            lblSubmAnnouncement.TabIndex = 1;
            lblSubmAnnouncement.Text = "Currently, there are \"\" submissions. Review them now!";
            lblSubmAnnouncement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSubmAnnouncement
            // 
            btnSubmAnnouncement.BackColor = Color.SkyBlue;
            btnSubmAnnouncement.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmAnnouncement.Location = new Point(88, 128);
            btnSubmAnnouncement.Margin = new Padding(3, 4, 3, 4);
            btnSubmAnnouncement.Name = "btnSubmAnnouncement";
            btnSubmAnnouncement.Size = new Size(212, 65);
            btnSubmAnnouncement.TabIndex = 0;
            btnSubmAnnouncement.Text = "View new submissions";
            btnSubmAnnouncement.UseVisualStyleBackColor = false;
            // 
            // gbBans
            // 
            gbBans.Controls.Add(lblUsersBanned);
            gbBans.Controls.Add(btnInfoBans);
            gbBans.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbBans.Location = new Point(565, 356);
            gbBans.Margin = new Padding(3, 4, 3, 4);
            gbBans.Name = "gbBans";
            gbBans.Padding = new Padding(3, 4, 3, 4);
            gbBans.Size = new Size(351, 200);
            gbBans.TabIndex = 7;
            gbBans.TabStop = false;
            gbBans.Text = "Ban Information";
            // 
            // lblUsersBanned
            // 
            lblUsersBanned.AutoSize = true;
            lblUsersBanned.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsersBanned.Location = new Point(21, 36);
            lblUsersBanned.Name = "lblUsersBanned";
            lblUsersBanned.Size = new Size(324, 25);
            lblUsersBanned.TabIndex = 1;
            lblUsersBanned.Text = "At the moment, \"\" users are banned.";
            // 
            // btnInfoBans
            // 
            btnInfoBans.BackColor = Color.DarkCyan;
            btnInfoBans.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfoBans.Location = new Point(70, 128);
            btnInfoBans.Margin = new Padding(3, 4, 3, 4);
            btnInfoBans.Name = "btnInfoBans";
            btnInfoBans.Size = new Size(212, 65);
            btnInfoBans.TabIndex = 0;
            btnInfoBans.Text = "Bans";
            btnInfoBans.UseVisualStyleBackColor = false;
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 691);
            Controls.Add(gbBans);
            Controls.Add(gbSubmAnnouncement);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(btnBans);
            Controls.Add(btnUsers);
            Controls.Add(btnSubmissions);
            Controls.Add(btnGames);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LandingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            gbSubmAnnouncement.ResumeLayout(false);
            gbBans.ResumeLayout(false);
            gbBans.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGames;
        private Button btnSubmissions;
        private Button btnUsers;
        private Button btnBans;
        private Button btnLogout;
        private Label lblWelcome;
        private GroupBox gbSubmAnnouncement;
        private Label lblSubmAnnouncement;
        private Button btnSubmAnnouncement;
        private GroupBox gbBans;
        private Label lblUsersBanned;
        private Button btnInfoBans;
    }
}