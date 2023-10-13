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
            cbBanned = new CheckBox();
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
            btnLogout.TabIndex = 9;
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
            btnBans.TabIndex = 8;
            btnBans.Text = "Bans";
            btnBans.UseVisualStyleBackColor = false;
            btnBans.Click += btnBans_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Turquoise;
            btnBack.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 15);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(213, 121);
            btnBack.TabIndex = 7;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmissions
            // 
            btnSubmissions.BackColor = Color.Aqua;
            btnSubmissions.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmissions.Location = new Point(451, 15);
            btnSubmissions.Margin = new Padding(3, 4, 3, 4);
            btnSubmissions.Name = "btnSubmissions";
            btnSubmissions.Size = new Size(213, 121);
            btnSubmissions.TabIndex = 6;
            btnSubmissions.Text = "Submissions";
            btnSubmissions.UseVisualStyleBackColor = false;
            btnSubmissions.Click += btnSubmissions_Click;
            // 
            // btnGames
            // 
            btnGames.BackColor = Color.DeepSkyBlue;
            btnGames.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGames.Location = new Point(231, 15);
            btnGames.Margin = new Padding(3, 4, 3, 4);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(213, 121);
            btnGames.TabIndex = 5;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            btnGames.Click += btnGames_Click;
            // 
            // btnBan
            // 
            btnBan.BackColor = Color.OrangeRed;
            btnBan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBan.Location = new Point(39, 555);
            btnBan.Margin = new Padding(3, 4, 3, 4);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(139, 65);
            btnBan.TabIndex = 10;
            btnBan.Text = "Ban selected user";
            btnBan.UseVisualStyleBackColor = false;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.Turquoise;
            btnDetails.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetails.Location = new Point(39, 482);
            btnDetails.Margin = new Padding(3, 4, 3, 4);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(139, 65);
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
            gbFilters.Location = new Point(12, 215);
            gbFilters.Margin = new Padding(3, 4, 3, 4);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(3, 4, 3, 4);
            gbFilters.Size = new Size(200, 260);
            gbFilters.TabIndex = 12;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filters";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightYellow;
            btnClear.Location = new Point(42, 186);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 46);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear filters";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(56, 56);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(100, 26);
            tbUsername.TabIndex = 3;
            // 
            // lblBanned
            // 
            lblBanned.AutoSize = true;
            lblBanned.Location = new Point(53, 108);
            lblBanned.Name = "lblBanned";
            lblBanned.Size = new Size(90, 20);
            lblBanned.TabIndex = 2;
            lblBanned.Text = "Ban status";
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(23, 28);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(159, 20);
            lblKeyword.TabIndex = 0;
            lblKeyword.Text = "Keyword for search:";
            // 
            // lvUsers
            // 
            lvUsers.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderUsername, columnHeaderEmail, columnHeaderRegDate, columnHeaderBanStatus });
            lvUsers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvUsers.FullRowSelect = true;
            lvUsers.GridLines = true;
            lvUsers.Location = new Point(231, 242);
            lvUsers.Margin = new Padding(3, 4, 3, 4);
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(667, 353);
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
            lblUsers.Location = new Point(463, 179);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(86, 31);
            lblUsers.TabIndex = 14;
            lblUsers.Text = "Users";
            // 
            // cbBanned
            // 
            cbBanned.AutoSize = true;
            cbBanned.Location = new Point(53, 141);
            cbBanned.Name = "cbBanned";
            cbBanned.Size = new Size(88, 24);
            cbBanned.TabIndex = 5;
            cbBanned.Text = "Banned";
            cbBanned.UseVisualStyleBackColor = true;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 691);
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
            Margin = new Padding(3, 4, 3, 4);
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