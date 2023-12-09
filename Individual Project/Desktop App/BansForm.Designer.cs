namespace Individual_Project
{
    partial class BansForm
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
			btnBack = new Button();
			btnUsers = new Button();
			btnSubmissions = new Button();
			btnGames = new Button();
			label1 = new Label();
			lvBans = new ListView();
			columnHeaderID = new ColumnHeader();
			columnHeaderUsername = new ColumnHeader();
			columnHeaderSD = new ColumnHeader();
			columnHeaderED = new ColumnHeader();
			columnHeaderReason = new ColumnHeader();
			gbFilters = new GroupBox();
			dateTimePickerDate = new DateTimePicker();
			rbEndDate = new RadioButton();
			rbStartDate = new RadioButton();
			rbNoDate = new RadioButton();
			tbUsername = new TextBox();
			lblDate = new Label();
			lblUsername = new Label();
			btnClear = new Button();
			btnUnban = new Button();
			btnBan = new Button();
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
			// btnBack
			// 
			btnBack.BackColor = Color.DarkCyan;
			btnBack.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.Location = new Point(10, 11);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(186, 91);
			btnBack.TabIndex = 8;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// btnUsers
			// 
			btnUsers.BackColor = Color.Turquoise;
			btnUsers.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnUsers.Location = new Point(586, 11);
			btnUsers.Name = "btnUsers";
			btnUsers.Size = new Size(186, 91);
			btnUsers.TabIndex = 7;
			btnUsers.Text = "Users";
			btnUsers.UseVisualStyleBackColor = false;
			btnUsers.Click += btnUsers_Click;
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
			btnGames.Location = new Point(203, 11);
			btnGames.Name = "btnGames";
			btnGames.Size = new Size(186, 91);
			btnGames.TabIndex = 5;
			btnGames.Text = "Games";
			btnGames.UseVisualStyleBackColor = false;
			btnGames.Click += btnGames_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(395, 114);
			label1.Name = "label1";
			label1.Size = new Size(95, 26);
			label1.TabIndex = 10;
			label1.Text = "Bans list";
			// 
			// lvBans
			// 
			lvBans.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderUsername, columnHeaderSD, columnHeaderED, columnHeaderReason });
			lvBans.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lvBans.FullRowSelect = true;
			lvBans.GridLines = true;
			lvBans.Location = new Point(299, 150);
			lvBans.Name = "lvBans";
			lvBans.Size = new Size(563, 338);
			lvBans.TabIndex = 11;
			lvBans.UseCompatibleStateImageBehavior = false;
			lvBans.View = View.Details;
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
			columnHeaderUsername.Width = 170;
			// 
			// columnHeaderSD
			// 
			columnHeaderSD.DisplayIndex = 3;
			columnHeaderSD.Text = "Start Date";
			columnHeaderSD.TextAlign = HorizontalAlignment.Center;
			columnHeaderSD.Width = 120;
			// 
			// columnHeaderED
			// 
			columnHeaderED.DisplayIndex = 4;
			columnHeaderED.Text = "End Date";
			columnHeaderED.TextAlign = HorizontalAlignment.Center;
			columnHeaderED.Width = 120;
			// 
			// columnHeaderReason
			// 
			columnHeaderReason.DisplayIndex = 2;
			columnHeaderReason.Text = "Reason";
			columnHeaderReason.TextAlign = HorizontalAlignment.Center;
			columnHeaderReason.Width = 150;
			// 
			// gbFilters
			// 
			gbFilters.Controls.Add(dateTimePickerDate);
			gbFilters.Controls.Add(rbEndDate);
			gbFilters.Controls.Add(rbStartDate);
			gbFilters.Controls.Add(rbNoDate);
			gbFilters.Controls.Add(tbUsername);
			gbFilters.Controls.Add(lblDate);
			gbFilters.Controls.Add(lblUsername);
			gbFilters.Controls.Add(btnClear);
			gbFilters.Location = new Point(10, 150);
			gbFilters.Name = "gbFilters";
			gbFilters.Size = new Size(271, 250);
			gbFilters.TabIndex = 12;
			gbFilters.TabStop = false;
			gbFilters.Text = "Filters";
			// 
			// dateTimePickerDate
			// 
			dateTimePickerDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePickerDate.Location = new Point(68, 74);
			dateTimePickerDate.Name = "dateTimePickerDate";
			dateTimePickerDate.Size = new Size(198, 23);
			dateTimePickerDate.TabIndex = 8;
			dateTimePickerDate.ValueChanged += dateTimePickerDate_ValueChanged;
			// 
			// rbEndDate
			// 
			rbEndDate.AutoSize = true;
			rbEndDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			rbEndDate.Location = new Point(49, 152);
			rbEndDate.Name = "rbEndDate";
			rbEndDate.Size = new Size(85, 21);
			rbEndDate.TabIndex = 7;
			rbEndDate.TabStop = true;
			rbEndDate.Text = "End Date";
			rbEndDate.UseVisualStyleBackColor = true;
			// 
			// rbStartDate
			// 
			rbStartDate.AutoSize = true;
			rbStartDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			rbStartDate.Location = new Point(49, 128);
			rbStartDate.Name = "rbStartDate";
			rbStartDate.Size = new Size(90, 21);
			rbStartDate.TabIndex = 6;
			rbStartDate.TabStop = true;
			rbStartDate.Text = "Start Date";
			rbStartDate.UseVisualStyleBackColor = true;
			// 
			// rbNoDate
			// 
			rbNoDate.AutoSize = true;
			rbNoDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			rbNoDate.Location = new Point(49, 104);
			rbNoDate.Name = "rbNoDate";
			rbNoDate.Size = new Size(76, 21);
			rbNoDate.TabIndex = 5;
			rbNoDate.TabStop = true;
			rbNoDate.Text = "No date";
			rbNoDate.UseVisualStyleBackColor = true;
			// 
			// tbUsername
			// 
			tbUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			tbUsername.Location = new Point(98, 39);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(88, 23);
			tbUsername.TabIndex = 3;
			tbUsername.TextChanged += tbUsername_TextChanged;
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblDate.Location = new Point(19, 78);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(42, 17);
			lblDate.TabIndex = 2;
			lblDate.Text = "Date:";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblUsername.Location = new Point(13, 42);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(77, 17);
			lblUsername.TabIndex = 1;
			lblUsername.Text = "Username:";
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.LightYellow;
			btnClear.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnClear.Location = new Point(49, 196);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(176, 36);
			btnClear.TabIndex = 0;
			btnClear.Text = "Clear filters";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// btnUnban
			// 
			btnUnban.BackColor = Color.Khaki;
			btnUnban.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnUnban.Location = new Point(60, 406);
			btnUnban.Name = "btnUnban";
			btnUnban.Size = new Size(162, 38);
			btnUnban.TabIndex = 13;
			btnUnban.Text = "Unban selected member";
			btnUnban.UseVisualStyleBackColor = false;
			btnUnban.Click += btnUnban_Click;
			// 
			// btnBan
			// 
			btnBan.BackColor = Color.OrangeRed;
			btnBan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnBan.Location = new Point(60, 450);
			btnBan.Name = "btnBan";
			btnBan.Size = new Size(162, 38);
			btnBan.TabIndex = 14;
			btnBan.Text = "Ban a member";
			btnBan.UseVisualStyleBackColor = false;
			btnBan.Click += btnBan_Click;
			// 
			// BansForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(903, 518);
			Controls.Add(btnBan);
			Controls.Add(btnUnban);
			Controls.Add(gbFilters);
			Controls.Add(lvBans);
			Controls.Add(label1);
			Controls.Add(btnLogout);
			Controls.Add(btnBack);
			Controls.Add(btnUsers);
			Controls.Add(btnSubmissions);
			Controls.Add(btnGames);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "BansForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Bans";
			gbFilters.ResumeLayout(false);
			gbFilters.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogout;
        private Button btnBack;
        private Button btnUsers;
        private Button btnSubmissions;
        private Button btnGames;
        private Label label1;
        private ListView lvBans;
        private GroupBox gbFilters;
        private DateTimePicker dateTimePickerDate;
        private RadioButton rbEndDate;
        private RadioButton rbStartDate;
        private RadioButton rbNoDate;
        private TextBox tbUsername;
        private Label lblDate;
        private Label lblUsername;
        private Button btnClear;
        private Button btnUnban;
        private Button btnBan;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderUsername;
        private ColumnHeader columnHeaderReason;
        private ColumnHeader columnHeaderSD;
        private ColumnHeader columnHeaderED;
    }
}