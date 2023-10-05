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
            listView1 = new ListView();
            columnHeaderID = new ColumnHeader();
            columnHeaderUsername = new ColumnHeader();
            columnHeaderReason = new ColumnHeader();
            columnHeaderSD = new ColumnHeader();
            columnHeaderED = new ColumnHeader();
            gbFilters = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            rbEndDate = new RadioButton();
            rbStartDate = new RadioButton();
            rbNoDate = new RadioButton();
            textBox1 = new TextBox();
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
            btnLogout.Location = new Point(885, 15);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 121);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkCyan;
            btnBack.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 15);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(213, 121);
            btnBack.TabIndex = 8;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Turquoise;
            btnUsers.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.Location = new Point(670, 15);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(213, 121);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
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
            btnGames.Location = new Point(232, 15);
            btnGames.Margin = new Padding(3, 4, 3, 4);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(213, 121);
            btnGames.TabIndex = 5;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            btnGames.Click += btnGames_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(451, 152);
            label1.Name = "label1";
            label1.Size = new Size(117, 31);
            label1.TabIndex = 10;
            label1.Text = "Bans list";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderUsername, columnHeaderReason, columnHeaderSD, columnHeaderED });
            listView1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(342, 200);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(563, 450);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // columnHeaderReason
            // 
            columnHeaderReason.Text = "Reason";
            columnHeaderReason.TextAlign = HorizontalAlignment.Center;
            columnHeaderReason.Width = 150;
            // 
            // columnHeaderSD
            // 
            columnHeaderSD.Text = "Start Date";
            columnHeaderSD.TextAlign = HorizontalAlignment.Center;
            columnHeaderSD.Width = 120;
            // 
            // columnHeaderED
            // 
            columnHeaderED.Text = "End Date";
            columnHeaderED.TextAlign = HorizontalAlignment.Center;
            columnHeaderED.Width = 120;
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(dateTimePicker1);
            gbFilters.Controls.Add(rbEndDate);
            gbFilters.Controls.Add(rbStartDate);
            gbFilters.Controls.Add(rbNoDate);
            gbFilters.Controls.Add(textBox1);
            gbFilters.Controls.Add(lblDate);
            gbFilters.Controls.Add(lblUsername);
            gbFilters.Controls.Add(btnClear);
            gbFilters.Location = new Point(12, 200);
            gbFilters.Margin = new Padding(3, 4, 3, 4);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(3, 4, 3, 4);
            gbFilters.Size = new Size(310, 334);
            gbFilters.TabIndex = 12;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filters";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(78, 98);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 26);
            dateTimePicker1.TabIndex = 8;
            // 
            // rbEndDate
            // 
            rbEndDate.AutoSize = true;
            rbEndDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbEndDate.Location = new Point(56, 202);
            rbEndDate.Margin = new Padding(3, 4, 3, 4);
            rbEndDate.Name = "rbEndDate";
            rbEndDate.Size = new Size(100, 24);
            rbEndDate.TabIndex = 7;
            rbEndDate.TabStop = true;
            rbEndDate.Text = "End Date";
            rbEndDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            rbStartDate.AutoSize = true;
            rbStartDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbStartDate.Location = new Point(56, 170);
            rbStartDate.Margin = new Padding(3, 4, 3, 4);
            rbStartDate.Name = "rbStartDate";
            rbStartDate.Size = new Size(107, 24);
            rbStartDate.TabIndex = 6;
            rbStartDate.TabStop = true;
            rbStartDate.Text = "Start Date";
            rbStartDate.UseVisualStyleBackColor = true;
            // 
            // rbNoDate
            // 
            rbNoDate.AutoSize = true;
            rbNoDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbNoDate.Location = new Point(56, 138);
            rbNoDate.Margin = new Padding(3, 4, 3, 4);
            rbNoDate.Name = "rbNoDate";
            rbNoDate.Size = new Size(88, 24);
            rbNoDate.TabIndex = 5;
            rbNoDate.TabStop = true;
            rbNoDate.Text = "No date";
            rbNoDate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(112, 52);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(22, 104);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(15, 56);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightYellow;
            btnClear.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(56, 262);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(201, 48);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear filters";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUnban
            // 
            btnUnban.BackColor = Color.Khaki;
            btnUnban.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUnban.Location = new Point(68, 541);
            btnUnban.Margin = new Padding(3, 4, 3, 4);
            btnUnban.Name = "btnUnban";
            btnUnban.Size = new Size(185, 51);
            btnUnban.TabIndex = 13;
            btnUnban.Text = "Unban selected member";
            btnUnban.UseVisualStyleBackColor = false;
            // 
            // btnBan
            // 
            btnBan.BackColor = Color.OrangeRed;
            btnBan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBan.Location = new Point(68, 600);
            btnBan.Margin = new Padding(3, 4, 3, 4);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(185, 51);
            btnBan.TabIndex = 14;
            btnBan.Text = "Ban a member";
            btnBan.UseVisualStyleBackColor = false;
            btnBan.Click += btnBan_Click;
            // 
            // BansForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 691);
            Controls.Add(btnBan);
            Controls.Add(btnUnban);
            Controls.Add(gbFilters);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(btnUsers);
            Controls.Add(btnSubmissions);
            Controls.Add(btnGames);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
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
        private ListView listView1;
        private GroupBox gbFilters;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbEndDate;
        private RadioButton rbStartDate;
        private RadioButton rbNoDate;
        private TextBox textBox1;
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