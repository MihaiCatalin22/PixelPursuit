namespace Individual_Project
{
    partial class SubmissionForm
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
            btnLogout = new Button();
            btnBans = new Button();
            btnUsers = new Button();
            btnBack = new Button();
            btnGames = new Button();
            lblSubmission = new Label();
            btnPendingSubmissions = new Button();
            btnDelSubmission = new Button();
            lvSubmissions = new ListView();
            columnHeaderID = new ColumnHeader();
            columnHeaderUsername = new ColumnHeader();
            columnHeaderGame = new ColumnHeader();
            columnHeaderPlatform = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderTime = new ColumnHeader();
            columnHeaderRank = new ColumnHeader();
            gbFilters = new GroupBox();
            tbPlatform = new TextBox();
            lblPlatform = new Label();
            btnClear = new Button();
            tbGame = new TextBox();
            tbUsername = new TextBox();
            lblGame = new Label();
            lblUsername = new Label();
            gbFilters.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Tomato;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(885, 15);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 121);
            btnLogout.TabIndex = 14;
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
            btnBans.TabIndex = 13;
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
            btnUsers.TabIndex = 12;
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
            btnBack.TabIndex = 11;
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
            btnGames.TabIndex = 10;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            btnGames.Click += btnGames_Click;
            // 
            // lblSubmission
            // 
            lblSubmission.AutoSize = true;
            lblSubmission.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubmission.Location = new Point(445, 170);
            lblSubmission.Name = "lblSubmission";
            lblSubmission.Size = new Size(168, 31);
            lblSubmission.TabIndex = 15;
            lblSubmission.Text = "Submissions";
            // 
            // btnPendingSubmissions
            // 
            btnPendingSubmissions.BackColor = Color.Aqua;
            btnPendingSubmissions.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPendingSubmissions.Location = new Point(26, 608);
            btnPendingSubmissions.Margin = new Padding(3, 4, 3, 4);
            btnPendingSubmissions.Name = "btnPendingSubmissions";
            btnPendingSubmissions.Size = new Size(139, 69);
            btnPendingSubmissions.TabIndex = 16;
            btnPendingSubmissions.Text = "View pending submissions";
            btnPendingSubmissions.UseVisualStyleBackColor = false;
            btnPendingSubmissions.Click += btnPendingSubmissions_Click;
            // 
            // btnDelSubmission
            // 
            btnDelSubmission.BackColor = Color.Coral;
            btnDelSubmission.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelSubmission.Location = new Point(171, 608);
            btnDelSubmission.Margin = new Padding(3, 4, 3, 4);
            btnDelSubmission.Name = "btnDelSubmission";
            btnDelSubmission.Size = new Size(139, 69);
            btnDelSubmission.TabIndex = 17;
            btnDelSubmission.Text = "Delete selected submission";
            btnDelSubmission.UseVisualStyleBackColor = false;
            btnDelSubmission.Click += btnDelSubmission_Click;
            // 
            // lvSubmissions
            // 
            lvSubmissions.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderRank, columnHeaderUsername, columnHeaderGame, columnHeaderPlatform, columnHeaderDate, columnHeaderTime });
            lvSubmissions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvSubmissions.FullRowSelect = true;
            lvSubmissions.GridLines = true;
            lvSubmissions.Location = new Point(232, 228);
            lvSubmissions.Margin = new Padding(3, 4, 3, 4);
            lvSubmissions.Name = "lvSubmissions";
            lvSubmissions.Size = new Size(679, 372);
            lvSubmissions.TabIndex = 18;
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
            columnHeaderUsername.DisplayIndex = 1;
            columnHeaderUsername.Text = "Username";
            columnHeaderUsername.TextAlign = HorizontalAlignment.Center;
            columnHeaderUsername.Width = 130;
            // 
            // columnHeaderGame
            // 
            columnHeaderGame.DisplayIndex = 2;
            columnHeaderGame.Text = "Game";
            columnHeaderGame.TextAlign = HorizontalAlignment.Center;
            columnHeaderGame.Width = 150;
            // 
            // columnHeaderPlatform
            // 
            columnHeaderPlatform.DisplayIndex = 3;
            columnHeaderPlatform.Text = "Platform";
            columnHeaderPlatform.TextAlign = HorizontalAlignment.Center;
            columnHeaderPlatform.Width = 100;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.DisplayIndex = 4;
            columnHeaderDate.Text = "Date";
            columnHeaderDate.TextAlign = HorizontalAlignment.Center;
            columnHeaderDate.Width = 100;
            // 
            // columnHeaderTime
            // 
            columnHeaderTime.DisplayIndex = 5;
            columnHeaderTime.Text = "Total Time";
            columnHeaderTime.TextAlign = HorizontalAlignment.Center;
            columnHeaderTime.Width = 120;
            // 
            // columnHeaderRank
            // 
            columnHeaderRank.DisplayIndex = 6;
            columnHeaderRank.Text = "Rank";
            columnHeaderRank.TextAlign = HorizontalAlignment.Center;
            columnHeaderRank.Width = 75;
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(tbPlatform);
            gbFilters.Controls.Add(lblPlatform);
            gbFilters.Controls.Add(btnClear);
            gbFilters.Controls.Add(tbGame);
            gbFilters.Controls.Add(tbUsername);
            gbFilters.Controls.Add(lblGame);
            gbFilters.Controls.Add(lblUsername);
            gbFilters.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gbFilters.Location = new Point(26, 228);
            gbFilters.Margin = new Padding(3, 4, 3, 4);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(3, 4, 3, 4);
            gbFilters.Size = new Size(200, 322);
            gbFilters.TabIndex = 19;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filters";
            // 
            // tbPlatform
            // 
            tbPlatform.Location = new Point(37, 205);
            tbPlatform.Margin = new Padding(3, 4, 3, 4);
            tbPlatform.Name = "tbPlatform";
            tbPlatform.Size = new Size(123, 26);
            tbPlatform.TabIndex = 8;
            tbPlatform.TextChanged += tbPlatform_TextChanged;
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(37, 181);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(77, 20);
            lblPlatform.TabIndex = 7;
            lblPlatform.Text = "Platform:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightYellow;
            btnClear.Location = new Point(37, 262);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 42);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear filters";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbGame
            // 
            tbGame.Location = new Point(37, 139);
            tbGame.Margin = new Padding(3, 4, 3, 4);
            tbGame.Name = "tbGame";
            tbGame.Size = new Size(123, 26);
            tbGame.TabIndex = 4;
            tbGame.TextChanged += tbGame_TextChanged;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(37, 74);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(123, 26);
            tbUsername.TabIndex = 3;
            tbUsername.TextChanged += tbUsername_TextChanged;
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
            // SubmissionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 691);
            Controls.Add(gbFilters);
            Controls.Add(lvSubmissions);
            Controls.Add(btnDelSubmission);
            Controls.Add(btnPendingSubmissions);
            Controls.Add(lblSubmission);
            Controls.Add(btnLogout);
            Controls.Add(btnBans);
            Controls.Add(btnUsers);
            Controls.Add(btnBack);
            Controls.Add(btnGames);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SubmissionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Submissions";
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnBans;
        private Button btnUsers;
        private Button btnBack;
        private Button btnGames;
        private Label lblSubmission;
        private Button btnPendingSubmissions;
        private Button btnDelSubmission;
        private ListView lvSubmissions;
        private GroupBox gbFilters;
        private Button btnClear;
        private TextBox tbGame;
        private TextBox tbUsername;
        private Label lblGame;
        private Label lblUsername;
        private TextBox tbPlatform;
        private Label lblPlatform;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderUsername;
        private ColumnHeader columnHeaderGame;
        private ColumnHeader columnHeaderPlatform;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderTime;
        private ColumnHeader columnHeaderRank;
    }
}