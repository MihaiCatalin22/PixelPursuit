namespace Individual_Project
{
    partial class AddGameForm
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
			lblAddGame = new Label();
			lblTitle = new Label();
			lblDeveloper = new Label();
			lblRelDate = new Label();
			lblTrailerLink = new Label();
			lblCoverLink = new Label();
			lblBKGCoverLink = new Label();
			lblGenre = new Label();
			lblPlatform = new Label();
			btnBack = new Button();
			btnAddGame = new Button();
			dtpReleaseDate = new DateTimePicker();
			tbTitle = new TextBox();
			tbDeveloper = new TextBox();
			tbTrailerLink = new TextBox();
			tbCoverLink = new TextBox();
			tbBKGCoverLink = new TextBox();
			tbGenre = new TextBox();
			tbPlatform = new TextBox();
			clbGenre = new CheckedListBox();
			clbPlatform = new CheckedListBox();
			btnShowGenreList = new Button();
			btnShowPlatformList = new Button();
			SuspendLayout();
			// 
			// lblAddGame
			// 
			lblAddGame.AutoSize = true;
			lblAddGame.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblAddGame.Location = new Point(232, 8);
			lblAddGame.Name = "lblAddGame";
			lblAddGame.Size = new Size(95, 20);
			lblAddGame.TabIndex = 0;
			lblAddGame.Text = "Add a game";
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.Location = new Point(116, 68);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(76, 17);
			lblTitle.TabIndex = 1;
			lblTitle.Text = "Game title:";
			// 
			// lblDeveloper
			// 
			lblDeveloper.AutoSize = true;
			lblDeveloper.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblDeveloper.Location = new Point(116, 98);
			lblDeveloper.Name = "lblDeveloper";
			lblDeveloper.Size = new Size(77, 17);
			lblDeveloper.TabIndex = 2;
			lblDeveloper.Text = "Developer:";
			// 
			// lblRelDate
			// 
			lblRelDate.AutoSize = true;
			lblRelDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblRelDate.Location = new Point(97, 128);
			lblRelDate.Name = "lblRelDate";
			lblRelDate.Size = new Size(96, 17);
			lblRelDate.TabIndex = 3;
			lblRelDate.Text = "Release date:";
			// 
			// lblTrailerLink
			// 
			lblTrailerLink.AutoSize = true;
			lblTrailerLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblTrailerLink.Location = new Point(115, 157);
			lblTrailerLink.Name = "lblTrailerLink";
			lblTrailerLink.Size = new Size(78, 17);
			lblTrailerLink.TabIndex = 4;
			lblTrailerLink.Text = "Trailer link:";
			// 
			// lblCoverLink
			// 
			lblCoverLink.AutoSize = true;
			lblCoverLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblCoverLink.Location = new Point(118, 184);
			lblCoverLink.Name = "lblCoverLink";
			lblCoverLink.Size = new Size(74, 17);
			lblCoverLink.TabIndex = 5;
			lblCoverLink.Text = "Cover link:";
			// 
			// lblBKGCoverLink
			// 
			lblBKGCoverLink.AutoSize = true;
			lblBKGCoverLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblBKGCoverLink.Location = new Point(38, 212);
			lblBKGCoverLink.Name = "lblBKGCoverLink";
			lblBKGCoverLink.Size = new Size(152, 17);
			lblBKGCoverLink.TabIndex = 6;
			lblBKGCoverLink.Text = "Background cover link:";
			// 
			// lblGenre
			// 
			lblGenre.AutoSize = true;
			lblGenre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblGenre.Location = new Point(124, 239);
			lblGenre.Name = "lblGenre";
			lblGenre.Size = new Size(69, 17);
			lblGenre.TabIndex = 7;
			lblGenre.Text = "Genre(s):";
			// 
			// lblPlatform
			// 
			lblPlatform.AutoSize = true;
			lblPlatform.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblPlatform.Location = new Point(109, 267);
			lblPlatform.Name = "lblPlatform";
			lblPlatform.Size = new Size(81, 17);
			lblPlatform.TabIndex = 8;
			lblPlatform.Text = "Platform(s):";
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.DeepSkyBlue;
			btnBack.Location = new Point(105, 304);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(90, 56);
			btnBack.TabIndex = 9;
			btnBack.Text = "Go back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// btnAddGame
			// 
			btnAddGame.BackColor = Color.Thistle;
			btnAddGame.Location = new Point(445, 304);
			btnAddGame.Name = "btnAddGame";
			btnAddGame.Size = new Size(90, 56);
			btnAddGame.TabIndex = 10;
			btnAddGame.Text = "Add game";
			btnAddGame.UseVisualStyleBackColor = false;
			btnAddGame.Click += btnAddGame_Click;
			// 
			// dtpReleaseDate
			// 
			dtpReleaseDate.Location = new Point(236, 128);
			dtpReleaseDate.Name = "dtpReleaseDate";
			dtpReleaseDate.Size = new Size(203, 23);
			dtpReleaseDate.TabIndex = 11;
			// 
			// tbTitle
			// 
			tbTitle.Location = new Point(236, 68);
			tbTitle.Name = "tbTitle";
			tbTitle.Size = new Size(203, 23);
			tbTitle.TabIndex = 12;
			// 
			// tbDeveloper
			// 
			tbDeveloper.Location = new Point(236, 102);
			tbDeveloper.Name = "tbDeveloper";
			tbDeveloper.Size = new Size(203, 23);
			tbDeveloper.TabIndex = 13;
			// 
			// tbTrailerLink
			// 
			tbTrailerLink.Location = new Point(236, 157);
			tbTrailerLink.Name = "tbTrailerLink";
			tbTrailerLink.Size = new Size(203, 23);
			tbTrailerLink.TabIndex = 14;
			// 
			// tbCoverLink
			// 
			tbCoverLink.Location = new Point(236, 184);
			tbCoverLink.Name = "tbCoverLink";
			tbCoverLink.Size = new Size(203, 23);
			tbCoverLink.TabIndex = 15;
			// 
			// tbBKGCoverLink
			// 
			tbBKGCoverLink.Location = new Point(236, 212);
			tbBKGCoverLink.Name = "tbBKGCoverLink";
			tbBKGCoverLink.Size = new Size(203, 23);
			tbBKGCoverLink.TabIndex = 16;
			// 
			// tbGenre
			// 
			tbGenre.Location = new Point(236, 239);
			tbGenre.Name = "tbGenre";
			tbGenre.Size = new Size(203, 23);
			tbGenre.TabIndex = 17;
			// 
			// tbPlatform
			// 
			tbPlatform.Location = new Point(236, 267);
			tbPlatform.Name = "tbPlatform";
			tbPlatform.Size = new Size(203, 23);
			tbPlatform.TabIndex = 18;
			// 
			// clbGenre
			// 
			clbGenre.FormattingEnabled = true;
			clbGenre.Location = new Point(236, 239);
			clbGenre.Name = "clbGenre";
			clbGenre.Size = new Size(203, 58);
			clbGenre.TabIndex = 20;
			clbGenre.SelectedIndexChanged += clbGenre_SelectedIndexChanged;
			// 
			// clbPlatform
			// 
			clbPlatform.FormattingEnabled = true;
			clbPlatform.Location = new Point(236, 283);
			clbPlatform.Name = "clbPlatform";
			clbPlatform.Size = new Size(203, 40);
			clbPlatform.TabIndex = 21;
			clbPlatform.SelectedIndexChanged += clbPlatform_SelectedIndexChanged;
			// 
			// btnShowGenreList
			// 
			btnShowGenreList.Location = new Point(402, 238);
			btnShowGenreList.Name = "btnShowGenreList";
			btnShowGenreList.Size = new Size(36, 22);
			btnShowGenreList.TabIndex = 22;
			btnShowGenreList.Text = "(..)";
			btnShowGenreList.UseVisualStyleBackColor = true;
			btnShowGenreList.Click += btnShowGenreList_Click;
			// 
			// btnShowPlatformList
			// 
			btnShowPlatformList.Location = new Point(402, 267);
			btnShowPlatformList.Name = "btnShowPlatformList";
			btnShowPlatformList.Size = new Size(36, 22);
			btnShowPlatformList.TabIndex = 23;
			btnShowPlatformList.Text = "(..)";
			btnShowPlatformList.UseVisualStyleBackColor = true;
			btnShowPlatformList.Click += btnShowPlatformList_Click;
			// 
			// AddGameForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(562, 378);
			Controls.Add(btnShowPlatformList);
			Controls.Add(btnShowGenreList);
			Controls.Add(tbPlatform);
			Controls.Add(tbGenre);
			Controls.Add(tbBKGCoverLink);
			Controls.Add(tbCoverLink);
			Controls.Add(tbTrailerLink);
			Controls.Add(tbDeveloper);
			Controls.Add(tbTitle);
			Controls.Add(dtpReleaseDate);
			Controls.Add(btnAddGame);
			Controls.Add(btnBack);
			Controls.Add(lblPlatform);
			Controls.Add(lblGenre);
			Controls.Add(lblBKGCoverLink);
			Controls.Add(lblCoverLink);
			Controls.Add(lblTrailerLink);
			Controls.Add(lblRelDate);
			Controls.Add(lblDeveloper);
			Controls.Add(lblTitle);
			Controls.Add(lblAddGame);
			Controls.Add(clbGenre);
			Controls.Add(clbPlatform);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "AddGameForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add a game";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblAddGame;
        private Label lblTitle;
        private Label lblDeveloper;
        private Label lblRelDate;
        private Label lblTrailerLink;
        private Label lblCoverLink;
        private Label lblBKGCoverLink;
        private Label lblGenre;
        private Label lblPlatform;
        private Button btnBack;
        private Button btnAddGame;
        private DateTimePicker dtpReleaseDate;
        private TextBox tbTitle;
        private TextBox tbDeveloper;
        private TextBox tbTrailerLink;
        private TextBox tbCoverLink;
        private TextBox tbBKGCoverLink;
        private TextBox tbGenre;
        private TextBox tbPlatform;
        private CheckedListBox clbGenre;
        private CheckedListBox clbPlatform;
        private Button btnShowGenreList;
        private Button btnShowPlatformList;
    }
}