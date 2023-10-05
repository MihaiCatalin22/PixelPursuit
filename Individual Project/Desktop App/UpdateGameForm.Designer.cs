namespace Individual_Project
{
    partial class UpdateGameForm
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
            btnShowPlatformList = new Button();
            btnShowGenreList = new Button();
            tbPlatform = new TextBox();
            tbGenre = new TextBox();
            tbBKGCoverLink = new TextBox();
            tbCoverLink = new TextBox();
            tbTrailerLink = new TextBox();
            tbDeveloper = new TextBox();
            tbTitle = new TextBox();
            dtpReleaseDate = new DateTimePicker();
            btnUpdateGame = new Button();
            btnBack = new Button();
            lblPlatform = new Label();
            lblGenre = new Label();
            lblBKGCoverLink = new Label();
            lblCoverLink = new Label();
            lblTrailerLink = new Label();
            lblRelDate = new Label();
            lblDeveloper = new Label();
            lblTitle = new Label();
            lblUpdateGame = new Label();
            clbGenre = new CheckedListBox();
            clbPlatform = new CheckedListBox();
            SuspendLayout();
            // 
            // btnShowPlatformList
            // 
            btnShowPlatformList.Location = new Point(466, 356);
            btnShowPlatformList.Margin = new Padding(3, 4, 3, 4);
            btnShowPlatformList.Name = "btnShowPlatformList";
            btnShowPlatformList.Size = new Size(30, 29);
            btnShowPlatformList.TabIndex = 46;
            btnShowPlatformList.Text = "(..)";
            btnShowPlatformList.UseVisualStyleBackColor = true;
            // 
            // btnShowGenreList
            // 
            btnShowGenreList.Location = new Point(466, 318);
            btnShowGenreList.Margin = new Padding(3, 4, 3, 4);
            btnShowGenreList.Name = "btnShowGenreList";
            btnShowGenreList.Size = new Size(30, 29);
            btnShowGenreList.TabIndex = 45;
            btnShowGenreList.Text = "(..)";
            btnShowGenreList.UseVisualStyleBackColor = true;
            // 
            // tbPlatform
            // 
            tbPlatform.Location = new Point(265, 356);
            tbPlatform.Margin = new Padding(3, 4, 3, 4);
            tbPlatform.Name = "tbPlatform";
            tbPlatform.Size = new Size(231, 27);
            tbPlatform.TabIndex = 42;
            // 
            // tbGenre
            // 
            tbGenre.Location = new Point(265, 319);
            tbGenre.Margin = new Padding(3, 4, 3, 4);
            tbGenre.Name = "tbGenre";
            tbGenre.Size = new Size(231, 27);
            tbGenre.TabIndex = 41;
            // 
            // tbBKGCoverLink
            // 
            tbBKGCoverLink.Location = new Point(265, 282);
            tbBKGCoverLink.Margin = new Padding(3, 4, 3, 4);
            tbBKGCoverLink.Name = "tbBKGCoverLink";
            tbBKGCoverLink.Size = new Size(231, 27);
            tbBKGCoverLink.TabIndex = 40;
            // 
            // tbCoverLink
            // 
            tbCoverLink.Location = new Point(265, 246);
            tbCoverLink.Margin = new Padding(3, 4, 3, 4);
            tbCoverLink.Name = "tbCoverLink";
            tbCoverLink.Size = new Size(231, 27);
            tbCoverLink.TabIndex = 39;
            // 
            // tbTrailerLink
            // 
            tbTrailerLink.Location = new Point(265, 209);
            tbTrailerLink.Margin = new Padding(3, 4, 3, 4);
            tbTrailerLink.Name = "tbTrailerLink";
            tbTrailerLink.Size = new Size(231, 27);
            tbTrailerLink.TabIndex = 38;
            // 
            // tbDeveloper
            // 
            tbDeveloper.Location = new Point(265, 136);
            tbDeveloper.Margin = new Padding(3, 4, 3, 4);
            tbDeveloper.Name = "tbDeveloper";
            tbDeveloper.Size = new Size(231, 27);
            tbDeveloper.TabIndex = 37;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(265, 91);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(231, 27);
            tbTitle.TabIndex = 36;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(265, 171);
            dtpReleaseDate.Margin = new Padding(3, 4, 3, 4);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(231, 27);
            dtpReleaseDate.TabIndex = 35;
            // 
            // btnUpdateGame
            // 
            btnUpdateGame.BackColor = Color.Thistle;
            btnUpdateGame.Location = new Point(393, 405);
            btnUpdateGame.Margin = new Padding(3, 4, 3, 4);
            btnUpdateGame.Name = "btnUpdateGame";
            btnUpdateGame.Size = new Size(103, 74);
            btnUpdateGame.TabIndex = 34;
            btnUpdateGame.Text = "Add game";
            btnUpdateGame.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DeepSkyBlue;
            btnBack.Location = new Point(265, 405);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 74);
            btnBack.TabIndex = 33;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlatform.Location = new Point(120, 356);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(98, 20);
            lblPlatform.TabIndex = 32;
            lblPlatform.Text = "Platform(s):";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenre.Location = new Point(137, 319);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(81, 20);
            lblGenre.TabIndex = 31;
            lblGenre.Text = "Genre(s):";
            // 
            // lblBKGCoverLink
            // 
            lblBKGCoverLink.AutoSize = true;
            lblBKGCoverLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBKGCoverLink.Location = new Point(39, 282);
            lblBKGCoverLink.Name = "lblBKGCoverLink";
            lblBKGCoverLink.Size = new Size(179, 20);
            lblBKGCoverLink.TabIndex = 30;
            lblBKGCoverLink.Text = "Background cover link:";
            // 
            // lblCoverLink
            // 
            lblCoverLink.AutoSize = true;
            lblCoverLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoverLink.Location = new Point(130, 246);
            lblCoverLink.Name = "lblCoverLink";
            lblCoverLink.Size = new Size(88, 20);
            lblCoverLink.TabIndex = 29;
            lblCoverLink.Text = "Cover link:";
            // 
            // lblTrailerLink
            // 
            lblTrailerLink.AutoSize = true;
            lblTrailerLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrailerLink.Location = new Point(126, 209);
            lblTrailerLink.Name = "lblTrailerLink";
            lblTrailerLink.Size = new Size(92, 20);
            lblTrailerLink.TabIndex = 28;
            lblTrailerLink.Text = "Trailer link:";
            // 
            // lblRelDate
            // 
            lblRelDate.AutoSize = true;
            lblRelDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRelDate.Location = new Point(106, 171);
            lblRelDate.Name = "lblRelDate";
            lblRelDate.Size = new Size(112, 20);
            lblRelDate.TabIndex = 27;
            lblRelDate.Text = "Release date:";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeveloper.Location = new Point(128, 131);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(90, 20);
            lblDeveloper.TabIndex = 26;
            lblDeveloper.Text = "Developer:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(127, 91);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(91, 20);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Game title:";
            // 
            // lblUpdateGame
            // 
            lblUpdateGame.AutoSize = true;
            lblUpdateGame.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUpdateGame.Location = new Point(260, 11);
            lblUpdateGame.Name = "lblUpdateGame";
            lblUpdateGame.Size = new Size(145, 25);
            lblUpdateGame.TabIndex = 24;
            lblUpdateGame.Text = "Update a game";
            // 
            // clbGenre
            // 
            clbGenre.FormattingEnabled = true;
            clbGenre.Location = new Point(265, 319);
            clbGenre.Margin = new Padding(3, 4, 3, 4);
            clbGenre.Name = "clbGenre";
            clbGenre.Size = new Size(231, 92);
            clbGenre.TabIndex = 43;
            // 
            // clbPlatform
            // 
            clbPlatform.FormattingEnabled = true;
            clbPlatform.Location = new Point(265, 368);
            clbPlatform.Margin = new Padding(3, 4, 3, 4);
            clbPlatform.Name = "clbPlatform";
            clbPlatform.Size = new Size(231, 92);
            clbPlatform.TabIndex = 44;
            // 
            // UpdateGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 504);
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
            Controls.Add(btnUpdateGame);
            Controls.Add(btnBack);
            Controls.Add(lblPlatform);
            Controls.Add(lblGenre);
            Controls.Add(lblBKGCoverLink);
            Controls.Add(lblCoverLink);
            Controls.Add(lblTrailerLink);
            Controls.Add(lblRelDate);
            Controls.Add(lblDeveloper);
            Controls.Add(lblTitle);
            Controls.Add(lblUpdateGame);
            Controls.Add(clbGenre);
            Controls.Add(clbPlatform);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update a game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowPlatformList;
        private Button btnShowGenreList;
        private TextBox tbPlatform;
        private TextBox tbGenre;
        private TextBox tbBKGCoverLink;
        private TextBox tbCoverLink;
        private TextBox tbTrailerLink;
        private TextBox tbDeveloper;
        private TextBox tbTitle;
        private DateTimePicker dtpReleaseDate;
        private Button btnUpdateGame;
        private Button btnBack;
        private Label lblPlatform;
        private Label lblGenre;
        private Label lblBKGCoverLink;
        private Label lblCoverLink;
        private Label lblTrailerLink;
        private Label lblRelDate;
        private Label lblDeveloper;
        private Label lblTitle;
        private Label lblUpdateGame;
        private CheckedListBox clbGenre;
        private CheckedListBox clbPlatform;
    }
}