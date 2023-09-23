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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnSubmissions = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbEndDate = new System.Windows.Forms.RadioButton();
            this.rbStartDate = new System.Windows.Forms.RadioButton();
            this.rbNoDate = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUnban = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(213, 97);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Turquoise;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(670, 12);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(213, 97);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
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
            this.btnGames.Location = new System.Drawing.Point(232, 12);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(213, 97);
            this.btnGames.TabIndex = 5;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(451, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bans list";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderUsername,
            this.columnHeaderReason,
            this.columnHeaderSD,
            this.columnHeaderED});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(342, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 361);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.columnHeaderUsername.Width = 170;
            // 
            // columnHeaderReason
            // 
            this.columnHeaderReason.Text = "Reason";
            this.columnHeaderReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderReason.Width = 150;
            // 
            // columnHeaderSD
            // 
            this.columnHeaderSD.Text = "Start Date";
            this.columnHeaderSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSD.Width = 120;
            // 
            // columnHeaderED
            // 
            this.columnHeaderED.Text = "End Date";
            this.columnHeaderED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderED.Width = 120;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.dateTimePicker1);
            this.gbFilters.Controls.Add(this.rbEndDate);
            this.gbFilters.Controls.Add(this.rbStartDate);
            this.gbFilters.Controls.Add(this.rbNoDate);
            this.gbFilters.Controls.Add(this.textBox1);
            this.gbFilters.Controls.Add(this.lblDate);
            this.gbFilters.Controls.Add(this.lblUsername);
            this.gbFilters.Controls.Add(this.btnClear);
            this.gbFilters.Location = new System.Drawing.Point(12, 160);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(310, 267);
            this.gbFilters.TabIndex = 12;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // rbEndDate
            // 
            this.rbEndDate.AutoSize = true;
            this.rbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbEndDate.Location = new System.Drawing.Point(56, 162);
            this.rbEndDate.Name = "rbEndDate";
            this.rbEndDate.Size = new System.Drawing.Size(100, 24);
            this.rbEndDate.TabIndex = 7;
            this.rbEndDate.TabStop = true;
            this.rbEndDate.Text = "End Date";
            this.rbEndDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            this.rbStartDate.AutoSize = true;
            this.rbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbStartDate.Location = new System.Drawing.Point(56, 136);
            this.rbStartDate.Name = "rbStartDate";
            this.rbStartDate.Size = new System.Drawing.Size(107, 24);
            this.rbStartDate.TabIndex = 6;
            this.rbStartDate.TabStop = true;
            this.rbStartDate.Text = "Start Date";
            this.rbStartDate.UseVisualStyleBackColor = true;
            // 
            // rbNoDate
            // 
            this.rbNoDate.AutoSize = true;
            this.rbNoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbNoDate.Location = new System.Drawing.Point(56, 110);
            this.rbNoDate.Name = "rbNoDate";
            this.rbNoDate.Size = new System.Drawing.Size(88, 24);
            this.rbNoDate.TabIndex = 5;
            this.rbNoDate.TabStop = true;
            this.rbNoDate.Text = "No date";
            this.rbNoDate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(112, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(22, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsername.Location = new System.Drawing.Point(15, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightYellow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(56, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 38);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear filters";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUnban
            // 
            this.btnUnban.BackColor = System.Drawing.Color.Khaki;
            this.btnUnban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUnban.Location = new System.Drawing.Point(68, 433);
            this.btnUnban.Name = "btnUnban";
            this.btnUnban.Size = new System.Drawing.Size(185, 41);
            this.btnUnban.TabIndex = 13;
            this.btnUnban.Text = "Unban selected member";
            this.btnUnban.UseVisualStyleBackColor = false;
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBan.Location = new System.Drawing.Point(68, 480);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(185, 41);
            this.btnBan.TabIndex = 14;
            this.btnBan.Text = "Ban a member";
            this.btnBan.UseVisualStyleBackColor = false;
            // 
            // BansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnUnban);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnSubmissions);
            this.Controls.Add(this.btnGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bans";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSubmissions;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbEndDate;
        private System.Windows.Forms.RadioButton rbStartDate;
        private System.Windows.Forms.RadioButton rbNoDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUnban;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
        private System.Windows.Forms.ColumnHeader columnHeaderReason;
        private System.Windows.Forms.ColumnHeader columnHeaderSD;
        private System.Windows.Forms.ColumnHeader columnHeaderED;
    }
}