namespace Individual_Project
{
    partial class PendingSubmissionsForm
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
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.tbPlatform = new System.Windows.Forms.TextBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbGame = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lvSubmissions = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReviewSubmission = new System.Windows.Forms.Button();
            this.btnAllSubmissions = new System.Windows.Forms.Button();
            this.lblPendingSubmission = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBans = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.tbPlatform);
            this.gbFilters.Controls.Add(this.lblPlatform);
            this.gbFilters.Controls.Add(this.btnClear);
            this.gbFilters.Controls.Add(this.tbGenre);
            this.gbFilters.Controls.Add(this.tbGame);
            this.gbFilters.Controls.Add(this.tbUsername);
            this.gbFilters.Controls.Add(this.lblGenre);
            this.gbFilters.Controls.Add(this.lblGame);
            this.gbFilters.Controls.Add(this.lblUsername);
            this.gbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbFilters.Location = new System.Drawing.Point(26, 136);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(200, 300);
            this.gbFilters.TabIndex = 29;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // tbPlatform
            // 
            this.tbPlatform.Location = new System.Drawing.Point(37, 215);
            this.tbPlatform.Name = "tbPlatform";
            this.tbPlatform.Size = new System.Drawing.Size(123, 26);
            this.tbPlatform.TabIndex = 8;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(33, 192);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(77, 20);
            this.lblPlatform.TabIndex = 7;
            this.lblPlatform.Text = "Platform:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightYellow;
            this.btnClear.Location = new System.Drawing.Point(37, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear filters";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(37, 163);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(123, 26);
            this.tbGenre.TabIndex = 5;
            // 
            // tbGame
            // 
            this.tbGame.Location = new System.Drawing.Point(37, 111);
            this.tbGame.Name = "tbGame";
            this.tbGame.Size = new System.Drawing.Size(123, 26);
            this.tbGame.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(37, 59);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(123, 26);
            this.tbUsername.TabIndex = 3;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(33, 140);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(60, 20);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre:";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(33, 88);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(59, 20);
            this.lblGame.TabIndex = 1;
            this.lblGame.Text = "Game:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(33, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lvSubmissions
            // 
            this.lvSubmissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderUsername,
            this.columnHeaderGame,
            this.columnHeaderPlatform,
            this.columnHeaderDate,
            this.columnHeaderTime});
            this.lvSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvSubmissions.FullRowSelect = true;
            this.lvSubmissions.GridLines = true;
            this.lvSubmissions.HideSelection = false;
            this.lvSubmissions.Location = new System.Drawing.Point(280, 172);
            this.lvSubmissions.Name = "lvSubmissions";
            this.lvSubmissions.Size = new System.Drawing.Size(603, 298);
            this.lvSubmissions.TabIndex = 28;
            this.lvSubmissions.UseCompatibleStateImageBehavior = false;
            this.lvSubmissions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "";
            this.columnHeaderID.Width = 0;
            // 
            // columnHeaderUsername
            // 
            this.columnHeaderUsername.Text = "Username";
            this.columnHeaderUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderUsername.Width = 130;
            // 
            // columnHeaderGame
            // 
            this.columnHeaderGame.Text = "Game";
            this.columnHeaderGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderGame.Width = 150;
            // 
            // columnHeaderPlatform
            // 
            this.columnHeaderPlatform.Text = "Platform";
            this.columnHeaderPlatform.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPlatform.Width = 100;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDate.Width = 100;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Total Time";
            this.columnHeaderTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTime.Width = 120;
            // 
            // btnReviewSubmission
            // 
            this.btnReviewSubmission.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReviewSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReviewSubmission.Location = new System.Drawing.Point(171, 486);
            this.btnReviewSubmission.Name = "btnReviewSubmission";
            this.btnReviewSubmission.Size = new System.Drawing.Size(139, 55);
            this.btnReviewSubmission.TabIndex = 27;
            this.btnReviewSubmission.Text = "Review selected submission";
            this.btnReviewSubmission.UseVisualStyleBackColor = false;
            // 
            // btnAllSubmissions
            // 
            this.btnAllSubmissions.BackColor = System.Drawing.Color.Aqua;
            this.btnAllSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAllSubmissions.Location = new System.Drawing.Point(26, 486);
            this.btnAllSubmissions.Name = "btnAllSubmissions";
            this.btnAllSubmissions.Size = new System.Drawing.Size(139, 55);
            this.btnAllSubmissions.TabIndex = 26;
            this.btnAllSubmissions.Text = "View all submissions";
            this.btnAllSubmissions.UseVisualStyleBackColor = false;
            // 
            // lblPendingSubmission
            // 
            this.lblPendingSubmission.AutoSize = true;
            this.lblPendingSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPendingSubmission.Location = new System.Drawing.Point(445, 136);
            this.lblPendingSubmission.Name = "lblPendingSubmission";
            this.lblPendingSubmission.Size = new System.Drawing.Size(270, 31);
            this.lblPendingSubmission.TabIndex = 25;
            this.lblPendingSubmission.Text = "Pending submissions";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Tomato;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(885, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 97);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnBans
            // 
            this.btnBans.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBans.Location = new System.Drawing.Point(670, 12);
            this.btnBans.Name = "btnBans";
            this.btnBans.Size = new System.Drawing.Size(213, 97);
            this.btnBans.TabIndex = 23;
            this.btnBans.Text = "Bans";
            this.btnBans.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Turquoise;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(451, 12);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(213, 97);
            this.btnUsers.TabIndex = 22;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Aqua;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(213, 97);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.Location = new System.Drawing.Point(232, 12);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(213, 97);
            this.btnGames.TabIndex = 20;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = false;
            // 
            // PendingSubmissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.lvSubmissions);
            this.Controls.Add(this.btnReviewSubmission);
            this.Controls.Add(this.btnAllSubmissions);
            this.Controls.Add(this.lblPendingSubmission);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBans);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PendingSubmissionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending submissions";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.TextBox tbPlatform;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbGame;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ListView lvSubmissions;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
        private System.Windows.Forms.ColumnHeader columnHeaderGame;
        private System.Windows.Forms.ColumnHeader columnHeaderPlatform;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.Button btnReviewSubmission;
        private System.Windows.Forms.Button btnAllSubmissions;
        private System.Windows.Forms.Label lblPendingSubmission;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBans;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGames;
    }
}