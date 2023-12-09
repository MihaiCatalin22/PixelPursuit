namespace Individual_Project
{
    partial class UsersForm
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
			btnBack = new Button();
			btnSubmissions = new Button();
			btnGames = new Button();
			btnBan = new Button();
			btnDetails = new Button();
			gbFilters = new GroupBox();
			cbBanned = new CheckBox();
			btnClear = new Button();
			tbUsername = new TextBox();
			lblBanned = new Label();
			lblKeyword = new Label();
			lvUsers = new ListView();
			columnHeaderID = new ColumnHeader();
			columnHeaderUsername = new ColumnHeader();
			columnHeaderEmail = new ColumnHeader();
			columnHeaderRegDate = new ColumnHeader();
			columnHeaderBanStatus = new ColumnHeader();
			lblUsers = new Label();
			gbFilters.SuspendLayout();
			SuspendLayout();
			// 
			// btnLogout
			// 
			btnLogout.BackColor = Color.Tomato;
			btnLogout.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogout.Location = new Point(774, 11);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(118, 91);
			btnLogout.TabIndex = 9;
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
			btnBans.TabIndex = 8;
			btnBans.Text = "Bans";
			btnBans.UseVisualStyleBackColor = false;
			btnBans.Click += btnBans_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Turquoise;
			btnBack.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.Location = new Point(10, 11);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(186, 91);
			btnBack.TabIndex = 7;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// btnSubmissions
			// 
			btnSubmissions.BackColor = Color.Aqua;
			btnSubmissions.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnSubmissions.Location = new Point(395, 11);
			btnSubmissions.Name = "btnSubmissions";
			btnSubmissions.Size = new Size(186, 91);
			btnSubmissions.TabIndex = 6;
			btnSubmissions.Text = "Submissions";
			btnSubmissions.UseVisualStyleBackColor = false;
			btnSubmissions.Click += btnSubmissions_Click;
			// 
			// btnGames
			// 
			btnGames.BackColor = Color.DeepSkyBlue;
			btnGames.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnGames.Location = new Point(202, 11);
			btnGames.Name = "btnGames";
			btnGames.Size = new Size(186, 91);
			btnGames.TabIndex = 5;
			btnGames.Text = "Games";
			btnGames.UseVisualStyleBackColor = false;
			btnGames.Click += btnGames_Click;
			// 
			// btnBan
			// 
			btnBan.BackColor = Color.OrangeRed;
			btnBan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnBan.Location = new Point(34, 416);
			btnBan.Name = "btnBan";
			btnBan.Size = new Size(122, 49);
			btnBan.TabIndex = 10;
			btnBan.Text = "Ban selected user";
			btnBan.UseVisualStyleBackColor = false;
			btnBan.Click += btnBan_Click;
			// 
			// btnDetails
			// 
			btnDetails.BackColor = Color.Turquoise;
			btnDetails.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnDetails.Location = new Point(34, 362);
			btnDetails.Name = "btnDetails";
			btnDetails.Size = new Size(122, 49);
			btnDetails.TabIndex = 11;
			btnDetails.Text = "View details of selected user";
			btnDetails.UseVisualStyleBackColor = false;
			btnDetails.Click += btnDetails_Click;
			// 
			// gbFilters
			// 
			gbFilters.Controls.Add(cbBanned);
			gbFilters.Controls.Add(btnClear);
			gbFilters.Controls.Add(tbUsername);
			gbFilters.Controls.Add(lblBanned);
			gbFilters.Controls.Add(lblKeyword);
			gbFilters.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			gbFilters.Location = new Point(10, 161);
			gbFilters.Name = "gbFilters";
			gbFilters.Size = new Size(175, 195);
			gbFilters.TabIndex = 12;
			gbFilters.TabStop = false;
			gbFilters.Text = "Filters";
			// 
			// cbBanned
			// 
			cbBanned.AutoSize = true;
			cbBanned.Location = new Point(46, 106);
			cbBanned.Margin = new Padding(3, 2, 3, 2);
			cbBanned.Name = "cbBanned";
			cbBanned.Size = new Size(76, 21);
			cbBanned.TabIndex = 5;
			cbBanned.Text = "Banned";
			cbBanned.UseVisualStyleBackColor = true;
			cbBanned.CheckedChanged += cbBanned_CheckedChanged;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.LightYellow;
			btnClear.Location = new Point(37, 140);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(100, 34);
			btnClear.TabIndex = 4;
			btnClear.Text = "Clear filters";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(49, 42);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(88, 23);
			tbUsername.TabIndex = 3;
			tbUsername.TextChanged += tbUsername_TextChanged;
			// 
			// lblBanned
			// 
			lblBanned.AutoSize = true;
			lblBanned.Location = new Point(46, 81);
			lblBanned.Name = "lblBanned";
			lblBanned.Size = new Size(75, 17);
			lblBanned.TabIndex = 2;
			lblBanned.Text = "Ban status";
			// 
			// lblKeyword
			// 
			lblKeyword.AutoSize = true;
			lblKeyword.Location = new Point(20, 21);
			lblKeyword.Name = "lblKeyword";
			lblKeyword.Size = new Size(134, 17);
			lblKeyword.TabIndex = 0;
			lblKeyword.Text = "Keyword for search:";
			// 
			// lvUsers
			// 
			lvUsers.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderUsername, columnHeaderEmail, columnHeaderRegDate, columnHeaderBanStatus });
			lvUsers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lvUsers.FullRowSelect = true;
			lvUsers.GridLines = true;
			lvUsers.Location = new Point(202, 182);
			lvUsers.Name = "lvUsers";
			lvUsers.Size = new Size(669, 266);
			lvUsers.TabIndex = 13;
			lvUsers.UseCompatibleStateImageBehavior = false;
			lvUsers.View = View.Details;
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
			columnHeaderUsername.Width = 200;
			// 
			// columnHeaderEmail
			// 
			columnHeaderEmail.Text = "Email";
			columnHeaderEmail.TextAlign = HorizontalAlignment.Center;
			columnHeaderEmail.Width = 125;
			// 
			// columnHeaderRegDate
			// 
			columnHeaderRegDate.Text = "Registration date";
			columnHeaderRegDate.TextAlign = HorizontalAlignment.Center;
			columnHeaderRegDate.Width = 165;
			// 
			// columnHeaderBanStatus
			// 
			columnHeaderBanStatus.Text = "Current ban status";
			columnHeaderBanStatus.TextAlign = HorizontalAlignment.Center;
			columnHeaderBanStatus.Width = 175;
			// 
			// lblUsers
			// 
			lblUsers.AutoSize = true;
			lblUsers.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
			lblUsers.Location = new Point(405, 134);
			lblUsers.Name = "lblUsers";
			lblUsers.Size = new Size(69, 26);
			lblUsers.TabIndex = 14;
			lblUsers.Text = "Users";
			// 
			// UsersForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(903, 518);
			Controls.Add(lblUsers);
			Controls.Add(lvUsers);
			Controls.Add(gbFilters);
			Controls.Add(btnDetails);
			Controls.Add(btnBan);
			Controls.Add(btnLogout);
			Controls.Add(btnBans);
			Controls.Add(btnBack);
			Controls.Add(btnSubmissions);
			Controls.Add(btnGames);
			Name = "UsersForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "UsersForm";
			gbFilters.ResumeLayout(false);
			gbFilters.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogout;
        private Button btnBans;
        private Button btnBack;
        private Button btnSubmissions;
        private Button btnGames;
        private Button btnBan;
        private Button btnDetails;
        private GroupBox gbFilters;
        private Button btnClear;
        private TextBox tbUsername;
        private Label lblBanned;
        private Label lblKeyword;
        private ListView lvUsers;
        private Label lblUsers;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderUsername;
        private ColumnHeader columnHeaderEmail;
        private ColumnHeader columnHeaderRegDate;
        private ColumnHeader columnHeaderBanStatus;
        private CheckBox cbBanned;
    }
}