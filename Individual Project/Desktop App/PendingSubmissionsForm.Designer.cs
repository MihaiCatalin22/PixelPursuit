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
            gbFilters = new GroupBox();
            tbPlatform = new TextBox();
            lblPlatform = new Label();
            btnClear = new Button();
            tbGenre = new TextBox();
            tbGame = new TextBox();
            tbUsername = new TextBox();
            lblGenre = new Label();
            lblGame = new Label();
            lblUsername = new Label();
            lvSubmissions = new ListView();
            columnHeaderID = new ColumnHeader();
            columnHeaderUsername = new ColumnHeader();
            columnHeaderGame = new ColumnHeader();
            columnHeaderPlatform = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderTime = new ColumnHeader();
            btnReviewSubmission = new Button();
            btnAllSubmissions = new Button();
            lblPendingSubmission = new Label();
            btnLogout = new Button();
            btnBans = new Button();
            btnUsers = new Button();
            btnBack = new Button();
            btnGames = new Button();
            gbFilters.SuspendLayout();
            SuspendLayout();
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(tbPlatform);
            gbFilters.Controls.Add(lblPlatform);
            gbFilters.Controls.Add(btnClear);
            gbFilters.Controls.Add(tbGenre);
            gbFilters.Controls.Add(tbGame);
            gbFilters.Controls.Add(tbUsername);
            gbFilters.Controls.Add(lblGenre);
            gbFilters.Controls.Add(lblGame);
            gbFilters.Controls.Add(lblUsername);
            gbFilters.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gbFilters.Location = new Point(26, 170);
            gbFilters.Margin = new Padding(3, 4, 3, 4);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(3, 4, 3, 4);
            gbFilters.Size = new Size(200, 375);
            gbFilters.TabIndex = 29;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filters";
            // 
            // tbPlatform
            // 
            tbPlatform.Location = new Point(37, 269);
            tbPlatform.Margin = new Padding(3, 4, 3, 4);
            tbPlatform.Name = "tbPlatform";
            tbPlatform.Size = new Size(123, 26);
            tbPlatform.TabIndex = 8;
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(33, 240);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(77, 20);
            lblPlatform.TabIndex = 7;
            lblPlatform.Text = "Platform:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightYellow;
            btnClear.Location = new Point(37, 312);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 42);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear filters";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // tbGenre
            // 
            tbGenre.Location = new Point(37, 204);
            tbGenre.Margin = new Padding(3, 4, 3, 4);
            tbGenre.Name = "tbGenre";
            tbGenre.Size = new Size(123, 26);
            tbGenre.TabIndex = 5;
            // 
            // tbGame
            // 
            tbGame.Location = new Point(37, 139);
            tbGame.Margin = new Padding(3, 4, 3, 4);
            tbGame.Name = "tbGame";
            tbGame.Size = new Size(123, 26);
            tbGame.TabIndex = 4;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(37, 74);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(123, 26);
            tbUsername.TabIndex = 3;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(33, 175);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(60, 20);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "Genre:";
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Location = new Point(33, 110);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(59, 20);
            lblGame.TabIndex = 1;
            lblGame.Text = "Game:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(33, 45);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lvSubmissions
            // 
            lvSubmissions.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderUsername, columnHeaderGame, columnHeaderPlatform, columnHeaderDate, columnHeaderTime });
            lvSubmissions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvSubmissions.FullRowSelect = true;
            lvSubmissions.GridLines = true;
            lvSubmissions.Location = new Point(280, 215);
            lvSubmissions.Margin = new Padding(3, 4, 3, 4);
            lvSubmissions.Name = "lvSubmissions";
            lvSubmissions.Size = new Size(603, 372);
            lvSubmissions.TabIndex = 28;
            lvSubmissions.UseCompatibleStateImageBehavior = false;
            lvSubmissions.View = View.Details;
            // 
            // columnHeaderID
            // 
            columnHeaderID.Text = "";
            columnHeaderID.Width = 0;
            // 
            // columnHeaderUsername
            // 
            columnHeaderUsername.Text = "Username";
            columnHeaderUsername.TextAlign = HorizontalAlignment.Center;
            columnHeaderUsername.Width = 130;
            // 
            // columnHeaderGame
            // 
            columnHeaderGame.Text = "Game";
            columnHeaderGame.TextAlign = HorizontalAlignment.Center;
            columnHeaderGame.Width = 150;
            // 
            // columnHeaderPlatform
            // 
            columnHeaderPlatform.Text = "Platform";
            columnHeaderPlatform.TextAlign = HorizontalAlignment.Center;
            columnHeaderPlatform.Width = 100;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date";
            columnHeaderDate.TextAlign = HorizontalAlignment.Center;
            columnHeaderDate.Width = 100;
            // 
            // columnHeaderTime
            // 
            columnHeaderTime.Text = "Total Time";
            columnHeaderTime.TextAlign = HorizontalAlignment.Center;
            columnHeaderTime.Width = 120;
            // 
            // btnReviewSubmission
            // 
            btnReviewSubmission.BackColor = Color.DarkSeaGreen;
            btnReviewSubmission.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReviewSubmission.Location = new Point(171, 608);
            btnReviewSubmission.Margin = new Padding(3, 4, 3, 4);
            btnReviewSubmission.Name = "btnReviewSubmission";
            btnReviewSubmission.Size = new Size(139, 69);
            btnReviewSubmission.TabIndex = 27;
            btnReviewSubmission.Text = "Review selected submission";
            btnReviewSubmission.UseVisualStyleBackColor = false;
            // 
            // btnAllSubmissions
            // 
            btnAllSubmissions.BackColor = Color.Aqua;
            btnAllSubmissions.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAllSubmissions.Location = new Point(26, 608);
            btnAllSubmissions.Margin = new Padding(3, 4, 3, 4);
            btnAllSubmissions.Name = "btnAllSubmissions";
            btnAllSubmissions.Size = new Size(139, 69);
            btnAllSubmissions.TabIndex = 26;
            btnAllSubmissions.Text = "View all submissions";
            btnAllSubmissions.UseVisualStyleBackColor = false;
            btnAllSubmissions.Click += btnAllSubmissions_Click;
            // 
            // lblPendingSubmission
            // 
            lblPendingSubmission.AutoSize = true;
            lblPendingSubmission.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPendingSubmission.Location = new Point(445, 170);
            lblPendingSubmission.Name = "lblPendingSubmission";
            lblPendingSubmission.Size = new Size(270, 31);
            lblPendingSubmission.TabIndex = 25;
            lblPendingSubmission.Text = "Pending submissions";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Tomato;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(885, 15);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 121);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBans
            // 
            btnBans.BackColor = Color.DarkCyan;
            btnBans.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBans.Location = new Point(670, 15);
            btnBans.Margin = new Padding(3, 4, 3, 4);
            btnBans.Name = "btnBans";
            btnBans.Size = new Size(213, 121);
            btnBans.TabIndex = 23;
            btnBans.Text = "Bans";
            btnBans.UseVisualStyleBackColor = false;
            btnBans.Click += btnBans_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Turquoise;
            btnUsers.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.Location = new Point(451, 15);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(213, 121);
            btnUsers.TabIndex = 22;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Aqua;
            btnBack.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(13, 15);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(213, 121);
            btnBack.TabIndex = 21;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnGames
            // 
            btnGames.BackColor = Color.DeepSkyBlue;
            btnGames.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGames.Location = new Point(232, 15);
            btnGames.Margin = new Padding(3, 4, 3, 4);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(213, 121);
            btnGames.TabIndex = 20;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            btnGames.Click += btnGames_Click;
            // 
            // PendingSubmissionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 691);
            Controls.Add(gbFilters);
            Controls.Add(lvSubmissions);
            Controls.Add(btnReviewSubmission);
            Controls.Add(btnAllSubmissions);
            Controls.Add(lblPendingSubmission);
            Controls.Add(btnLogout);
            Controls.Add(btnBans);
            Controls.Add(btnUsers);
            Controls.Add(btnBack);
            Controls.Add(btnGames);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PendingSubmissionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pending submissions";
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbFilters;
        private TextBox tbPlatform;
        private Label lblPlatform;
        private Button btnClear;
        private TextBox tbGenre;
        private TextBox tbGame;
        private TextBox tbUsername;
        private Label lblGenre;
        private Label lblGame;
        private Label lblUsername;
        private ListView lvSubmissions;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderUsername;
        private ColumnHeader columnHeaderGame;
        private ColumnHeader columnHeaderPlatform;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderTime;
        private Button btnReviewSubmission;
        private Button btnAllSubmissions;
        private Label lblPendingSubmission;
        private Button btnLogout;
        private Button btnBans;
        private Button btnUsers;
        private Button btnBack;
        private Button btnGames;
    }
}