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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBans = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmissions = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.rbBanned = new System.Windows.Forms.RadioButton();
            this.lblBanned = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRegDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBanStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Tomato;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(885, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 97);
            this.btnLogout.TabIndex = 9;
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
            this.btnBans.TabIndex = 8;
            this.btnBans.Text = "Bans";
            this.btnBans.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Turquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(213, 97);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSubmissions
            // 
            this.btnSubmissions.BackColor = System.Drawing.Color.Aqua;
            this.btnSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmissions.Location = new System.Drawing.Point(451, 12);
            this.btnSubmissions.Name = "btnSubmissions";
            this.btnSubmissions.Size = new System.Drawing.Size(213, 97);
            this.btnSubmissions.TabIndex = 6;
            this.btnSubmissions.Text = "Submissions";
            this.btnSubmissions.UseVisualStyleBackColor = false;
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.Location = new System.Drawing.Point(231, 12);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(213, 97);
            this.btnGames.TabIndex = 5;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = false;
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBan.Location = new System.Drawing.Point(39, 444);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(139, 52);
            this.btnBan.TabIndex = 10;
            this.btnBan.Text = "Ban selected user";
            this.btnBan.UseVisualStyleBackColor = false;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Turquoise;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDetails.Location = new System.Drawing.Point(39, 386);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(139, 52);
            this.btnDetails.TabIndex = 11;
            this.btnDetails.Text = "View details of selected user";
            this.btnDetails.UseVisualStyleBackColor = false;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnClear);
            this.gbFilters.Controls.Add(this.textBox1);
            this.gbFilters.Controls.Add(this.lblBanned);
            this.gbFilters.Controls.Add(this.rbBanned);
            this.gbFilters.Controls.Add(this.lblKeyword);
            this.gbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbFilters.Location = new System.Drawing.Point(12, 172);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(200, 208);
            this.gbFilters.TabIndex = 12;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderUsername,
            this.columnHeaderEmail,
            this.columnHeaderRegDate,
            this.columnHeaderBanStatus});
            this.lvUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.GridLines = true;
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(231, 194);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(667, 283);
            this.lvUsers.TabIndex = 13;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblUsers.Location = new System.Drawing.Point(463, 143);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(86, 31);
            this.lblUsers.TabIndex = 14;
            this.lblUsers.Text = "Users";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(23, 22);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(159, 20);
            this.lblKeyword.TabIndex = 0;
            this.lblKeyword.Text = "Keyword for search:";
            // 
            // rbBanned
            // 
            this.rbBanned.AutoSize = true;
            this.rbBanned.Location = new System.Drawing.Point(56, 109);
            this.rbBanned.Name = "rbBanned";
            this.rbBanned.Size = new System.Drawing.Size(87, 24);
            this.rbBanned.TabIndex = 1;
            this.rbBanned.TabStop = true;
            this.rbBanned.Text = "Banned";
            this.rbBanned.UseVisualStyleBackColor = true;
            // 
            // lblBanned
            // 
            this.lblBanned.AutoSize = true;
            this.lblBanned.Location = new System.Drawing.Point(53, 86);
            this.lblBanned.Name = "lblBanned";
            this.lblBanned.Size = new System.Drawing.Size(90, 20);
            this.lblBanned.TabIndex = 2;
            this.lblBanned.Text = "Ban status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightYellow;
            this.btnClear.Location = new System.Drawing.Point(42, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear filters";
            this.btnClear.UseVisualStyleBackColor = false;
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
            this.columnHeaderUsername.Width = 200;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderEmail.Width = 125;
            // 
            // columnHeaderRegDate
            // 
            this.columnHeaderRegDate.Text = "Registration date";
            this.columnHeaderRegDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderRegDate.Width = 165;
            // 
            // columnHeaderBanStatus
            // 
            this.columnHeaderBanStatus.Text = "Current ban status";
            this.columnHeaderBanStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBanStatus.Width = 175;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBans);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmissions);
            this.Controls.Add(this.btnGames);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBans;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmissions;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBanned;
        private System.Windows.Forms.RadioButton rbBanned;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderRegDate;
        private System.Windows.Forms.ColumnHeader columnHeaderBanStatus;
    }
}