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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBans = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnSubmissions = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGames = new System.Windows.Forms.Label();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.tbDeveloper = new System.Windows.Forms.TextBox();
            this.tbGame = new System.Windows.Forms.TextBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnUpdateGame = new System.Windows.Forms.Button();
            this.lvGames = new System.Windows.Forms.ListView();
            this.columnHeaderEmpty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeveloper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Tomato;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(883, 12);
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
            this.btnBans.Location = new System.Drawing.Point(668, 12);
            this.btnBans.Name = "btnBans";
            this.btnBans.Size = new System.Drawing.Size(213, 97);
            this.btnBans.TabIndex = 8;
            this.btnBans.Text = "Bans";
            this.btnBans.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Turquoise;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(449, 12);
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
            this.btnSubmissions.Location = new System.Drawing.Point(230, 12);
            this.btnSubmissions.Name = "btnSubmissions";
            this.btnSubmissions.Size = new System.Drawing.Size(213, 97);
            this.btnSubmissions.TabIndex = 6;
            this.btnSubmissions.Text = "Submissions";
            this.btnSubmissions.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(10, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(213, 97);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(443, 134);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(148, 32);
            this.lblGames.TabIndex = 10;
            this.lblGames.Text = "Games list";
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.tbDeveloper);
            this.gbFilters.Controls.Add(this.tbGame);
            this.gbFilters.Controls.Add(this.lblDeveloper);
            this.gbFilters.Controls.Add(this.lblGame);
            this.gbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilters.Location = new System.Drawing.Point(23, 163);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(200, 189);
            this.gbFilters.TabIndex = 11;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // tbDeveloper
            // 
            this.tbDeveloper.Location = new System.Drawing.Point(53, 130);
            this.tbDeveloper.Name = "tbDeveloper";
            this.tbDeveloper.Size = new System.Drawing.Size(100, 27);
            this.tbDeveloper.TabIndex = 3;
            // 
            // tbGame
            // 
            this.tbGame.Location = new System.Drawing.Point(53, 58);
            this.tbGame.Name = "tbGame";
            this.tbGame.Size = new System.Drawing.Size(100, 27);
            this.tbGame.TabIndex = 2;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(55, 98);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(85, 20);
            this.lblDeveloper.TabIndex = 1;
            this.lblDeveloper.Text = "Developer";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(68, 23);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(54, 20);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "Game";
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.Location = new System.Drawing.Point(40, 462);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(149, 46);
            this.btnDeleteGame.TabIndex = 12;
            this.btnDeleteGame.Text = "Delete selected game";
            this.btnDeleteGame.UseVisualStyleBackColor = false;
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGame.Location = new System.Drawing.Point(40, 358);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(149, 46);
            this.btnAddGame.TabIndex = 13;
            this.btnAddGame.Text = "Add new game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            // 
            // btnUpdateGame
            // 
            this.btnUpdateGame.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGame.Location = new System.Drawing.Point(40, 410);
            this.btnUpdateGame.Name = "btnUpdateGame";
            this.btnUpdateGame.Size = new System.Drawing.Size(149, 46);
            this.btnUpdateGame.TabIndex = 14;
            this.btnUpdateGame.Text = "Update selected game";
            this.btnUpdateGame.UseVisualStyleBackColor = false;
            // 
            // lvGames
            // 
            this.lvGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEmpty,
            this.columnHeaderDeveloper,
            this.columnHeaderGame});
            this.lvGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGames.FullRowSelect = true;
            this.lvGames.GridLines = true;
            this.lvGames.HideSelection = false;
            this.lvGames.Location = new System.Drawing.Point(230, 183);
            this.lvGames.Name = "lvGames";
            this.lvGames.Size = new System.Drawing.Size(603, 325);
            this.lvGames.TabIndex = 15;
            this.lvGames.UseCompatibleStateImageBehavior = false;
            this.lvGames.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderEmpty
            // 
            this.columnHeaderEmpty.DisplayIndex = 2;
            this.columnHeaderEmpty.Text = "";
            this.columnHeaderEmpty.Width = 0;
            // 
            // columnHeaderDeveloper
            // 
            this.columnHeaderDeveloper.DisplayIndex = 0;
            this.columnHeaderDeveloper.Text = "Developer";
            this.columnHeaderDeveloper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDeveloper.Width = 300;
            // 
            // columnHeaderGame
            // 
            this.columnHeaderGame.DisplayIndex = 1;
            this.columnHeaderGame.Text = "Game";
            this.columnHeaderGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderGame.Width = 300;
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.lvGames);
            this.Controls.Add(this.btnUpdateGame);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBans);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnSubmissions);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBans;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSubmissions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnUpdateGame;
        private System.Windows.Forms.ListView lvGames;
        private System.Windows.Forms.ColumnHeader columnHeaderEmpty;
        private System.Windows.Forms.ColumnHeader columnHeaderDeveloper;
        private System.Windows.Forms.ColumnHeader columnHeaderGame;
        private System.Windows.Forms.TextBox tbDeveloper;
        private System.Windows.Forms.TextBox tbGame;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblGame;
    }
}