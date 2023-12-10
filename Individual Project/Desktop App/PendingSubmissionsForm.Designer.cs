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
			tbGame = new TextBox();
			tbUsername = new TextBox();
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
			gbFilters.Controls.Add(tbGame);
			gbFilters.Controls.Add(tbUsername);
			gbFilters.Controls.Add(lblGame);
			gbFilters.Controls.Add(lblUsername);
			gbFilters.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			gbFilters.Location = new Point(22, 161);
			gbFilters.Name = "gbFilters";
			gbFilters.Size = new Size(175, 232);
			gbFilters.TabIndex = 29;
			gbFilters.TabStop = false;
			gbFilters.Text = "Filters";
			// 
			// tbPlatform
			// 
			tbPlatform.Location = new Point(35, 152);
			tbPlatform.Name = "tbPlatform";
			tbPlatform.Size = new Size(108, 23);
			tbPlatform.TabIndex = 8;
			tbPlatform.TextChanged += tbPlatform_TextChanged;
			// 
			// lblPlatform
			// 
			lblPlatform.AutoSize = true;
			lblPlatform.Location = new Point(32, 130);
			lblPlatform.Name = "lblPlatform";
			lblPlatform.Size = new Size(64, 17);
			lblPlatform.TabIndex = 7;
			lblPlatform.Text = "Platform:";
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.LightYellow;
			btnClear.Location = new Point(35, 184);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(108, 32);
			btnClear.TabIndex = 6;
			btnClear.Text = "Clear filters";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// tbGame
			// 
			tbGame.Location = new Point(32, 104);
			tbGame.Name = "tbGame";
			tbGame.Size = new Size(108, 23);
			tbGame.TabIndex = 4;
			tbGame.TextChanged += tbGame_TextChanged;
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(32, 56);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(108, 23);
			tbUsername.TabIndex = 3;
			tbUsername.TextChanged += tbUsername_TextChanged;
			// 
			// lblGame
			// 
			lblGame.AutoSize = true;
			lblGame.Location = new Point(29, 82);
			lblGame.Name = "lblGame";
			lblGame.Size = new Size(50, 17);
			lblGame.TabIndex = 1;
			lblGame.Text = "Game:";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(29, 34);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(77, 17);
			lblUsername.TabIndex = 0;
			lblUsername.Text = "Username:";
			// 
			// lvSubmissions
			// 
			lvSubmissions.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderUsername, columnHeaderGame, columnHeaderPlatform, columnHeaderDate, columnHeaderTime });
			lvSubmissions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lvSubmissions.FullRowSelect = true;
			lvSubmissions.GridLines = true;
			lvSubmissions.Location = new Point(203, 161);
			lvSubmissions.Name = "lvSubmissions";
			lvSubmissions.Size = new Size(605, 280);
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
			btnReviewSubmission.Location = new Point(150, 456);
			btnReviewSubmission.Name = "btnReviewSubmission";
			btnReviewSubmission.Size = new Size(122, 52);
			btnReviewSubmission.TabIndex = 27;
			btnReviewSubmission.Text = "Review selected submission";
			btnReviewSubmission.UseVisualStyleBackColor = false;
			btnReviewSubmission.Click += btnReviewSubmission_Click;
			// 
			// btnAllSubmissions
			// 
			btnAllSubmissions.BackColor = Color.Aqua;
			btnAllSubmissions.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnAllSubmissions.Location = new Point(23, 456);
			btnAllSubmissions.Name = "btnAllSubmissions";
			btnAllSubmissions.Size = new Size(122, 52);
			btnAllSubmissions.TabIndex = 26;
			btnAllSubmissions.Text = "View all submissions";
			btnAllSubmissions.UseVisualStyleBackColor = false;
			btnAllSubmissions.Click += btnAllSubmissions_Click;
			// 
			// lblPendingSubmission
			// 
			lblPendingSubmission.AutoSize = true;
			lblPendingSubmission.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
			lblPendingSubmission.Location = new Point(389, 128);
			lblPendingSubmission.Name = "lblPendingSubmission";
			lblPendingSubmission.Size = new Size(219, 26);
			lblPendingSubmission.TabIndex = 25;
			lblPendingSubmission.Text = "Pending submissions";
			// 
			// btnLogout
			// 
			btnLogout.BackColor = Color.Tomato;
			btnLogout.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogout.Location = new Point(774, 11);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(118, 91);
			btnLogout.TabIndex = 24;
			btnLogout.Text = "Logout";
			btnLogout.UseVisualStyleBackColor = false;
			btnLogout.Click += btnLogout_Click;
			// 
			// btnBans
			// 
			btnBans.BackColor = Color.DarkCyan;
			btnBans.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnBans.Location = new Point(586, 11);
			btnBans.Name = "btnBans";
			btnBans.Size = new Size(186, 91);
			btnBans.TabIndex = 23;
			btnBans.Text = "Bans";
			btnBans.UseVisualStyleBackColor = false;
			btnBans.Click += btnBans_Click;
			// 
			// btnUsers
			// 
			btnUsers.BackColor = Color.Turquoise;
			btnUsers.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnUsers.Location = new Point(395, 11);
			btnUsers.Name = "btnUsers";
			btnUsers.Size = new Size(186, 91);
			btnUsers.TabIndex = 22;
			btnUsers.Text = "Users";
			btnUsers.UseVisualStyleBackColor = false;
			btnUsers.Click += btnUsers_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Aqua;
			btnBack.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.Location = new Point(11, 11);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(186, 91);
			btnBack.TabIndex = 21;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// btnGames
			// 
			btnGames.BackColor = Color.DeepSkyBlue;
			btnGames.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnGames.Location = new Point(203, 11);
			btnGames.Name = "btnGames";
			btnGames.Size = new Size(186, 91);
			btnGames.TabIndex = 20;
			btnGames.Text = "Games";
			btnGames.UseVisualStyleBackColor = false;
			btnGames.Click += btnGames_Click;
			// 
			// PendingSubmissionsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(903, 518);
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
        private TextBox tbGame;
        private TextBox tbUsername;
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