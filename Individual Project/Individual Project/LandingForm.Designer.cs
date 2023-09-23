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
            this.btnGames = new System.Windows.Forms.Button();
            this.btnSubmissions = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBans = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbSubmAnnouncement = new System.Windows.Forms.GroupBox();
            this.lblSubmAnnouncement = new System.Windows.Forms.Label();
            this.btnSubmAnnouncement = new System.Windows.Forms.Button();
            this.gbBans = new System.Windows.Forms.GroupBox();
            this.lblUsersBanned = new System.Windows.Forms.Label();
            this.btnInfoBans = new System.Windows.Forms.Button();
            this.gbSubmAnnouncement.SuspendLayout();
            this.gbBans.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.Location = new System.Drawing.Point(12, 12);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(213, 97);
            this.btnGames.TabIndex = 0;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = false;
            // 
            // btnSubmissions
            // 
            this.btnSubmissions.BackColor = System.Drawing.Color.Aqua;
            this.btnSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmissions.Location = new System.Drawing.Point(232, 12);
            this.btnSubmissions.Name = "btnSubmissions";
            this.btnSubmissions.Size = new System.Drawing.Size(213, 97);
            this.btnSubmissions.TabIndex = 1;
            this.btnSubmissions.Text = "Submissions";
            this.btnSubmissions.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Turquoise;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(451, 12);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(213, 97);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnBans
            // 
            this.btnBans.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBans.Location = new System.Drawing.Point(670, 12);
            this.btnBans.Name = "btnBans";
            this.btnBans.Size = new System.Drawing.Size(213, 97);
            this.btnBans.TabIndex = 3;
            this.btnBans.Text = "Bans";
            this.btnBans.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Tomato;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(885, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 97);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(381, 141);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(274, 32);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome, ~~user~~!";
            // 
            // gbSubmAnnouncement
            // 
            this.gbSubmAnnouncement.Controls.Add(this.lblSubmAnnouncement);
            this.gbSubmAnnouncement.Controls.Add(this.btnSubmAnnouncement);
            this.gbSubmAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubmAnnouncement.Location = new System.Drawing.Point(75, 285);
            this.gbSubmAnnouncement.Name = "gbSubmAnnouncement";
            this.gbSubmAnnouncement.Size = new System.Drawing.Size(370, 160);
            this.gbSubmAnnouncement.TabIndex = 6;
            this.gbSubmAnnouncement.TabStop = false;
            this.gbSubmAnnouncement.Text = "New submissions";
            // 
            // lblSubmAnnouncement
            // 
            this.lblSubmAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmAnnouncement.Location = new System.Drawing.Point(32, 29);
            this.lblSubmAnnouncement.Name = "lblSubmAnnouncement";
            this.lblSubmAnnouncement.Size = new System.Drawing.Size(317, 61);
            this.lblSubmAnnouncement.TabIndex = 1;
            this.lblSubmAnnouncement.Text = "Currently, there are \"\" submissions. Review them now!";
            this.lblSubmAnnouncement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmAnnouncement
            // 
            this.btnSubmAnnouncement.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSubmAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmAnnouncement.Location = new System.Drawing.Point(88, 102);
            this.btnSubmAnnouncement.Name = "btnSubmAnnouncement";
            this.btnSubmAnnouncement.Size = new System.Drawing.Size(212, 52);
            this.btnSubmAnnouncement.TabIndex = 0;
            this.btnSubmAnnouncement.Text = "View new submissions";
            this.btnSubmAnnouncement.UseVisualStyleBackColor = false;
            // 
            // gbBans
            // 
            this.gbBans.Controls.Add(this.lblUsersBanned);
            this.gbBans.Controls.Add(this.btnInfoBans);
            this.gbBans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBans.Location = new System.Drawing.Point(565, 285);
            this.gbBans.Name = "gbBans";
            this.gbBans.Size = new System.Drawing.Size(351, 160);
            this.gbBans.TabIndex = 7;
            this.gbBans.TabStop = false;
            this.gbBans.Text = "Ban Information";
            // 
            // lblUsersBanned
            // 
            this.lblUsersBanned.AutoSize = true;
            this.lblUsersBanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersBanned.Location = new System.Drawing.Point(21, 29);
            this.lblUsersBanned.Name = "lblUsersBanned";
            this.lblUsersBanned.Size = new System.Drawing.Size(324, 25);
            this.lblUsersBanned.TabIndex = 1;
            this.lblUsersBanned.Text = "At the moment, \"\" users are banned.";
            // 
            // btnInfoBans
            // 
            this.btnInfoBans.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInfoBans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoBans.Location = new System.Drawing.Point(70, 102);
            this.btnInfoBans.Name = "btnInfoBans";
            this.btnInfoBans.Size = new System.Drawing.Size(212, 52);
            this.btnInfoBans.TabIndex = 0;
            this.btnInfoBans.Text = "Bans";
            this.btnInfoBans.UseVisualStyleBackColor = false;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.gbBans);
            this.Controls.Add(this.gbSubmAnnouncement);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBans);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnSubmissions);
            this.Controls.Add(this.btnGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.gbSubmAnnouncement.ResumeLayout(false);
            this.gbBans.ResumeLayout(false);
            this.gbBans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnSubmissions;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnBans;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gbSubmAnnouncement;
        private System.Windows.Forms.Label lblSubmAnnouncement;
        private System.Windows.Forms.Button btnSubmAnnouncement;
        private System.Windows.Forms.GroupBox gbBans;
        private System.Windows.Forms.Label lblUsersBanned;
        private System.Windows.Forms.Button btnInfoBans;
    }
}