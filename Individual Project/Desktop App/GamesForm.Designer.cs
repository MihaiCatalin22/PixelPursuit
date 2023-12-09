namespace Individual_Project
{
    partial class GamesForm
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
			btnSubmissions = new Button();
			btnBack = new Button();
			lblGames = new Label();
			gbFilters = new GroupBox();
			btnReset = new Button();
			tbDeveloper = new TextBox();
			tbGame = new TextBox();
			lblDeveloper = new Label();
			lblGame = new Label();
			btnDeleteGame = new Button();
			btnAddGame = new Button();
			btnUpdateGame = new Button();
			lvGames = new ListView();
			columnHeaderEmpty = new ColumnHeader();
			columnHeaderDeveloper = new ColumnHeader();
			columnHeaderGame = new ColumnHeader();
			gbFilters.SuspendLayout();
			SuspendLayout();
			// 
			// btnLogout
			// 
			btnLogout.BackColor = Color.Tomato;
			btnLogout.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogout.Location = new Point(773, 11);
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
			btnBans.Location = new Point(584, 11);
			btnBans.Name = "btnBans";
			btnBans.Size = new Size(186, 91);
			btnBans.TabIndex = 8;
			btnBans.Text = "Bans";
			btnBans.UseVisualStyleBackColor = false;
			btnBans.Click += btnBans_Click;
			// 
			// btnUsers
			// 
			btnUsers.BackColor = Color.Turquoise;
			btnUsers.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnUsers.Location = new Point(393, 11);
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
			btnSubmissions.Location = new Point(201, 11);
			btnSubmissions.Name = "btnSubmissions";
			btnSubmissions.Size = new Size(186, 91);
			btnSubmissions.TabIndex = 6;
			btnSubmissions.Text = "Submissions";
			btnSubmissions.UseVisualStyleBackColor = false;
			btnSubmissions.Click += btnSubmissions_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.DeepSkyBlue;
			btnBack.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.Location = new Point(9, 11);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(186, 91);
			btnBack.TabIndex = 5;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// lblGames
			// 
			lblGames.AutoSize = true;
			lblGames.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			lblGames.Location = new Point(388, 126);
			lblGames.Name = "lblGames";
			lblGames.Size = new Size(116, 26);
			lblGames.TabIndex = 10;
			lblGames.Text = "Games list";
			// 
			// gbFilters
			// 
			gbFilters.Controls.Add(btnReset);
			gbFilters.Controls.Add(tbDeveloper);
			gbFilters.Controls.Add(tbGame);
			gbFilters.Controls.Add(lblDeveloper);
			gbFilters.Controls.Add(lblGame);
			gbFilters.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			gbFilters.Location = new Point(20, 153);
			gbFilters.Name = "gbFilters";
			gbFilters.Size = new Size(175, 177);
			gbFilters.TabIndex = 11;
			gbFilters.TabStop = false;
			gbFilters.Text = "Filters";
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.LightYellow;
			btnReset.Location = new Point(46, 118);
			btnReset.Margin = new Padding(3, 2, 3, 2);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(88, 48);
			btnReset.TabIndex = 4;
			btnReset.Text = "Reset filters";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += btnReset_Click;
			// 
			// tbDeveloper
			// 
			tbDeveloper.Location = new Point(46, 90);
			tbDeveloper.Name = "tbDeveloper";
			tbDeveloper.Size = new Size(88, 23);
			tbDeveloper.TabIndex = 3;
			tbDeveloper.TextChanged += tbDeveloper_TextChanged;
			// 
			// tbGame
			// 
			tbGame.Location = new Point(46, 40);
			tbGame.Name = "tbGame";
			tbGame.Size = new Size(88, 23);
			tbGame.TabIndex = 2;
			tbGame.TextChanged += tbGame_TextChanged;
			// 
			// lblDeveloper
			// 
			lblDeveloper.AutoSize = true;
			lblDeveloper.Location = new Point(46, 72);
			lblDeveloper.Name = "lblDeveloper";
			lblDeveloper.Size = new Size(73, 17);
			lblDeveloper.TabIndex = 1;
			lblDeveloper.Text = "Developer";
			// 
			// lblGame
			// 
			lblGame.AutoSize = true;
			lblGame.Location = new Point(60, 22);
			lblGame.Name = "lblGame";
			lblGame.Size = new Size(46, 17);
			lblGame.TabIndex = 0;
			lblGame.Text = "Game";
			// 
			// btnDeleteGame
			// 
			btnDeleteGame.BackColor = Color.LightSalmon;
			btnDeleteGame.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnDeleteGame.Location = new Point(35, 434);
			btnDeleteGame.Name = "btnDeleteGame";
			btnDeleteGame.Size = new Size(130, 44);
			btnDeleteGame.TabIndex = 12;
			btnDeleteGame.Text = "Delete selected game";
			btnDeleteGame.UseVisualStyleBackColor = false;
			btnDeleteGame.Click += btnDeleteGame_Click;
			// 
			// btnAddGame
			// 
			btnAddGame.BackColor = Color.Aquamarine;
			btnAddGame.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddGame.Location = new Point(35, 336);
			btnAddGame.Name = "btnAddGame";
			btnAddGame.Size = new Size(130, 44);
			btnAddGame.TabIndex = 13;
			btnAddGame.Text = "Add new game";
			btnAddGame.UseVisualStyleBackColor = false;
			btnAddGame.Click += btnAddGame_Click;
			// 
			// btnUpdateGame
			// 
			btnUpdateGame.BackColor = Color.Khaki;
			btnUpdateGame.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnUpdateGame.Location = new Point(35, 384);
			btnUpdateGame.Name = "btnUpdateGame";
			btnUpdateGame.Size = new Size(130, 44);
			btnUpdateGame.TabIndex = 14;
			btnUpdateGame.Text = "Update selected game";
			btnUpdateGame.UseVisualStyleBackColor = false;
			btnUpdateGame.Click += btnUpdateGame_Click;
			// 
			// lvGames
			// 
			lvGames.Columns.AddRange(new ColumnHeader[] { columnHeaderEmpty, columnHeaderDeveloper, columnHeaderGame });
			lvGames.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lvGames.FullRowSelect = true;
			lvGames.GridLines = true;
			lvGames.Location = new Point(201, 172);
			lvGames.Name = "lvGames";
			lvGames.Size = new Size(528, 305);
			lvGames.TabIndex = 15;
			lvGames.UseCompatibleStateImageBehavior = false;
			lvGames.View = View.Details;
			// 
			// columnHeaderEmpty
			// 
			columnHeaderEmpty.DisplayIndex = 2;
			columnHeaderEmpty.Text = "";
			columnHeaderEmpty.Width = 0;
			// 
			// columnHeaderDeveloper
			// 
			columnHeaderDeveloper.DisplayIndex = 0;
			columnHeaderDeveloper.Text = "Developer";
			columnHeaderDeveloper.TextAlign = HorizontalAlignment.Center;
			columnHeaderDeveloper.Width = 300;
			// 
			// columnHeaderGame
			// 
			columnHeaderGame.DisplayIndex = 1;
			columnHeaderGame.Text = "Game";
			columnHeaderGame.TextAlign = HorizontalAlignment.Center;
			columnHeaderGame.Width = 300;
			// 
			// GamesForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(903, 518);
			Controls.Add(lvGames);
			Controls.Add(btnUpdateGame);
			Controls.Add(btnAddGame);
			Controls.Add(btnDeleteGame);
			Controls.Add(gbFilters);
			Controls.Add(lblGames);
			Controls.Add(btnLogout);
			Controls.Add(btnBans);
			Controls.Add(btnUsers);
			Controls.Add(btnSubmissions);
			Controls.Add(btnBack);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "GamesForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Games";
			gbFilters.ResumeLayout(false);
			gbFilters.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogout;
        private Button btnBans;
        private Button btnUsers;
        private Button btnSubmissions;
        private Button btnBack;
        private Label lblGames;
        private GroupBox gbFilters;
        private Button btnDeleteGame;
        private Button btnAddGame;
        private Button btnUpdateGame;
        private ListView lvGames;
        private ColumnHeader columnHeaderEmpty;
        private ColumnHeader columnHeaderDeveloper;
        private ColumnHeader columnHeaderGame;
        private TextBox tbDeveloper;
        private TextBox tbGame;
        private Label lblDeveloper;
        private Label lblGame;
        private Button btnReset;
    }
}