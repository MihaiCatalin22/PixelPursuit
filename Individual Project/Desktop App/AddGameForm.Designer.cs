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
            lblAddGame.Location = new Point(265, 11);
            lblAddGame.Name = "lblAddGame";
            lblAddGame.Size = new Size(118, 25);
            lblAddGame.TabIndex = 0;
            lblAddGame.Text = "Add a game";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(132, 91);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(91, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Game title:";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeveloper.Location = new Point(133, 131);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(90, 20);
            lblDeveloper.TabIndex = 2;
            lblDeveloper.Text = "Developer:";
            // 
            // lblRelDate
            // 
            lblRelDate.AutoSize = true;
            lblRelDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRelDate.Location = new Point(111, 171);
            lblRelDate.Name = "lblRelDate";
            lblRelDate.Size = new Size(112, 20);
            lblRelDate.TabIndex = 3;
            lblRelDate.Text = "Release date:";
            // 
            // lblTrailerLink
            // 
            lblTrailerLink.AutoSize = true;
            lblTrailerLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrailerLink.Location = new Point(131, 209);
            lblTrailerLink.Name = "lblTrailerLink";
            lblTrailerLink.Size = new Size(92, 20);
            lblTrailerLink.TabIndex = 4;
            lblTrailerLink.Text = "Trailer link:";
            // 
            // lblCoverLink
            // 
            lblCoverLink.AutoSize = true;
            lblCoverLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoverLink.Location = new Point(135, 246);
            lblCoverLink.Name = "lblCoverLink";
            lblCoverLink.Size = new Size(88, 20);
            lblCoverLink.TabIndex = 5;
            lblCoverLink.Text = "Cover link:";
            // 
            // lblBKGCoverLink
            // 
            lblBKGCoverLink.AutoSize = true;
            lblBKGCoverLink.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBKGCoverLink.Location = new Point(44, 282);
            lblBKGCoverLink.Name = "lblBKGCoverLink";
            lblBKGCoverLink.Size = new Size(179, 20);
            lblBKGCoverLink.TabIndex = 6;
            lblBKGCoverLink.Text = "Background cover link:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenre.Location = new Point(142, 319);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(81, 20);
            lblGenre.TabIndex = 7;
            lblGenre.Text = "Genre(s):";
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlatform.Location = new Point(125, 356);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(98, 20);
            lblPlatform.TabIndex = 8;
            lblPlatform.Text = "Platform(s):";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DeepSkyBlue;
            btnBack.Location = new Point(270, 405);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 74);
            btnBack.TabIndex = 9;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddGame
            // 
            btnAddGame.BackColor = Color.Thistle;
            btnAddGame.Location = new Point(398, 405);
            btnAddGame.Margin = new Padding(3, 4, 3, 4);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(103, 74);
            btnAddGame.TabIndex = 10;
            btnAddGame.Text = "Add game";
            btnAddGame.UseVisualStyleBackColor = false;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(270, 171);
            dtpReleaseDate.Margin = new Padding(3, 4, 3, 4);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(231, 27);
            dtpReleaseDate.TabIndex = 11;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(270, 91);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(231, 27);
            tbTitle.TabIndex = 12;
            // 
            // tbDeveloper
            // 
            tbDeveloper.Location = new Point(270, 136);
            tbDeveloper.Margin = new Padding(3, 4, 3, 4);
            tbDeveloper.Name = "tbDeveloper";
            tbDeveloper.Size = new Size(231, 27);
            tbDeveloper.TabIndex = 13;
            // 
            // tbTrailerLink
            // 
            tbTrailerLink.Location = new Point(270, 209);
            tbTrailerLink.Margin = new Padding(3, 4, 3, 4);
            tbTrailerLink.Name = "tbTrailerLink";
            tbTrailerLink.Size = new Size(231, 27);
            tbTrailerLink.TabIndex = 14;
            // 
            // tbCoverLink
            // 
            tbCoverLink.Location = new Point(270, 246);
            tbCoverLink.Margin = new Padding(3, 4, 3, 4);
            tbCoverLink.Name = "tbCoverLink";
            tbCoverLink.Size = new Size(231, 27);
            tbCoverLink.TabIndex = 15;
            // 
            // tbBKGCoverLink
            // 
            tbBKGCoverLink.Location = new Point(270, 282);
            tbBKGCoverLink.Margin = new Padding(3, 4, 3, 4);
            tbBKGCoverLink.Name = "tbBKGCoverLink";
            tbBKGCoverLink.Size = new Size(231, 27);
            tbBKGCoverLink.TabIndex = 16;
            // 
            // tbGenre
            // 
            tbGenre.Location = new Point(270, 319);
            tbGenre.Margin = new Padding(3, 4, 3, 4);
            tbGenre.Name = "tbGenre";
            tbGenre.Size = new Size(231, 27);
            tbGenre.TabIndex = 17;
            // 
            // tbPlatform
            // 
            tbPlatform.Location = new Point(270, 356);
            tbPlatform.Margin = new Padding(3, 4, 3, 4);
            tbPlatform.Name = "tbPlatform";
            tbPlatform.Size = new Size(231, 27);
            tbPlatform.TabIndex = 18;
            // 
            // clbGenre
            // 
            clbGenre.FormattingEnabled = true;
            clbGenre.Location = new Point(270, 319);
            clbGenre.Margin = new Padding(3, 4, 3, 4);
            clbGenre.Name = "clbGenre";
            clbGenre.Size = new Size(231, 92);
            clbGenre.TabIndex = 20;
            // 
            // clbPlatform
            // 
            clbPlatform.FormattingEnabled = true;
            clbPlatform.Location = new Point(270, 368);
            clbPlatform.Margin = new Padding(3, 4, 3, 4);
            clbPlatform.Name = "clbPlatform";
            clbPlatform.Size = new Size(231, 92);
            clbPlatform.TabIndex = 21;
            // 
            // btnShowGenreList
            // 
            btnShowGenreList.Location = new Point(471, 318);
            btnShowGenreList.Margin = new Padding(3, 4, 3, 4);
            btnShowGenreList.Name = "btnShowGenreList";
            btnShowGenreList.Size = new Size(30, 29);
            btnShowGenreList.TabIndex = 22;
            btnShowGenreList.Text = "(..)";
            btnShowGenreList.UseVisualStyleBackColor = true;
            // 
            // btnShowPlatformList
            // 
            btnShowPlatformList.Location = new Point(471, 356);
            btnShowPlatformList.Margin = new Padding(3, 4, 3, 4);
            btnShowPlatformList.Name = "btnShowPlatformList";
            btnShowPlatformList.Size = new Size(30, 29);
            btnShowPlatformList.TabIndex = 23;
            btnShowPlatformList.Text = "(..)";
            btnShowPlatformList.UseVisualStyleBackColor = true;
            // 
            // AddGameForm
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
            Margin = new Padding(3, 4, 3, 4);
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