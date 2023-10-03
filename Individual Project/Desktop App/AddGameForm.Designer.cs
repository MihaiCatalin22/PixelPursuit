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
            this.lblAddGame = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblRelDate = new System.Windows.Forms.Label();
            this.lblTrailerLink = new System.Windows.Forms.Label();
            this.lblCoverLink = new System.Windows.Forms.Label();
            this.lblBKGCoverLink = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDeveloper = new System.Windows.Forms.TextBox();
            this.tbTrailerLink = new System.Windows.Forms.TextBox();
            this.tbCoverLink = new System.Windows.Forms.TextBox();
            this.tbBKGCoverLink = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbPlatform = new System.Windows.Forms.TextBox();
            this.clbGenre = new System.Windows.Forms.CheckedListBox();
            this.clbPlatform = new System.Windows.Forms.CheckedListBox();
            this.btnShowGenreList = new System.Windows.Forms.Button();
            this.btnShowPlatformList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddGame
            // 
            this.lblAddGame.AutoSize = true;
            this.lblAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddGame.Location = new System.Drawing.Point(265, 9);
            this.lblAddGame.Name = "lblAddGame";
            this.lblAddGame.Size = new System.Drawing.Size(118, 25);
            this.lblAddGame.TabIndex = 0;
            this.lblAddGame.Text = "Add a game";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitle.Location = new System.Drawing.Point(132, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Game title:";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDeveloper.Location = new System.Drawing.Point(133, 105);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(90, 20);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "Developer:";
            // 
            // lblRelDate
            // 
            this.lblRelDate.AutoSize = true;
            this.lblRelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRelDate.Location = new System.Drawing.Point(111, 137);
            this.lblRelDate.Name = "lblRelDate";
            this.lblRelDate.Size = new System.Drawing.Size(112, 20);
            this.lblRelDate.TabIndex = 3;
            this.lblRelDate.Text = "Release date:";
            // 
            // lblTrailerLink
            // 
            this.lblTrailerLink.AutoSize = true;
            this.lblTrailerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTrailerLink.Location = new System.Drawing.Point(131, 167);
            this.lblTrailerLink.Name = "lblTrailerLink";
            this.lblTrailerLink.Size = new System.Drawing.Size(92, 20);
            this.lblTrailerLink.TabIndex = 4;
            this.lblTrailerLink.Text = "Trailer link:";
            // 
            // lblCoverLink
            // 
            this.lblCoverLink.AutoSize = true;
            this.lblCoverLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCoverLink.Location = new System.Drawing.Point(135, 197);
            this.lblCoverLink.Name = "lblCoverLink";
            this.lblCoverLink.Size = new System.Drawing.Size(88, 20);
            this.lblCoverLink.TabIndex = 5;
            this.lblCoverLink.Text = "Cover link:";
            // 
            // lblBKGCoverLink
            // 
            this.lblBKGCoverLink.AutoSize = true;
            this.lblBKGCoverLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBKGCoverLink.Location = new System.Drawing.Point(44, 226);
            this.lblBKGCoverLink.Name = "lblBKGCoverLink";
            this.lblBKGCoverLink.Size = new System.Drawing.Size(179, 20);
            this.lblBKGCoverLink.TabIndex = 6;
            this.lblBKGCoverLink.Text = "Background cover link:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenre.Location = new System.Drawing.Point(142, 255);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(81, 20);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Genre(s):";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlatform.Location = new System.Drawing.Point(125, 285);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(98, 20);
            this.lblPlatform.TabIndex = 8;
            this.lblPlatform.Text = "Platform(s):";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.Location = new System.Drawing.Point(270, 324);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 59);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.Thistle;
            this.btnAddGame.Location = new System.Drawing.Point(398, 324);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(103, 59);
            this.btnAddGame.TabIndex = 10;
            this.btnAddGame.Text = "Add game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(270, 137);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(231, 22);
            this.dtpReleaseDate.TabIndex = 11;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(270, 73);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(231, 22);
            this.tbTitle.TabIndex = 12;
            // 
            // tbDeveloper
            // 
            this.tbDeveloper.Location = new System.Drawing.Point(270, 109);
            this.tbDeveloper.Name = "tbDeveloper";
            this.tbDeveloper.Size = new System.Drawing.Size(231, 22);
            this.tbDeveloper.TabIndex = 13;
            // 
            // tbTrailerLink
            // 
            this.tbTrailerLink.Location = new System.Drawing.Point(270, 167);
            this.tbTrailerLink.Name = "tbTrailerLink";
            this.tbTrailerLink.Size = new System.Drawing.Size(231, 22);
            this.tbTrailerLink.TabIndex = 14;
            // 
            // tbCoverLink
            // 
            this.tbCoverLink.Location = new System.Drawing.Point(270, 197);
            this.tbCoverLink.Name = "tbCoverLink";
            this.tbCoverLink.Size = new System.Drawing.Size(231, 22);
            this.tbCoverLink.TabIndex = 15;
            // 
            // tbBKGCoverLink
            // 
            this.tbBKGCoverLink.Location = new System.Drawing.Point(270, 226);
            this.tbBKGCoverLink.Name = "tbBKGCoverLink";
            this.tbBKGCoverLink.Size = new System.Drawing.Size(231, 22);
            this.tbBKGCoverLink.TabIndex = 16;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(270, 255);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(231, 22);
            this.tbGenre.TabIndex = 17;
            // 
            // tbPlatform
            // 
            this.tbPlatform.Location = new System.Drawing.Point(270, 285);
            this.tbPlatform.Name = "tbPlatform";
            this.tbPlatform.Size = new System.Drawing.Size(231, 22);
            this.tbPlatform.TabIndex = 18;
            // 
            // clbGenre
            // 
            this.clbGenre.FormattingEnabled = true;
            this.clbGenre.Location = new System.Drawing.Point(270, 255);
            this.clbGenre.Name = "clbGenre";
            this.clbGenre.Size = new System.Drawing.Size(231, 89);
            this.clbGenre.TabIndex = 20;
            // 
            // clbPlatform
            // 
            this.clbPlatform.FormattingEnabled = true;
            this.clbPlatform.Location = new System.Drawing.Point(270, 294);
            this.clbPlatform.Name = "clbPlatform";
            this.clbPlatform.Size = new System.Drawing.Size(231, 89);
            this.clbPlatform.TabIndex = 21;
            // 
            // btnShowGenreList
            // 
            this.btnShowGenreList.Location = new System.Drawing.Point(471, 254);
            this.btnShowGenreList.Name = "btnShowGenreList";
            this.btnShowGenreList.Size = new System.Drawing.Size(30, 23);
            this.btnShowGenreList.TabIndex = 22;
            this.btnShowGenreList.Text = "(..)";
            this.btnShowGenreList.UseVisualStyleBackColor = true;
            // 
            // btnShowPlatformList
            // 
            this.btnShowPlatformList.Location = new System.Drawing.Point(471, 285);
            this.btnShowPlatformList.Name = "btnShowPlatformList";
            this.btnShowPlatformList.Size = new System.Drawing.Size(30, 23);
            this.btnShowPlatformList.TabIndex = 23;
            this.btnShowPlatformList.Text = "(..)";
            this.btnShowPlatformList.UseVisualStyleBackColor = true;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 403);
            this.Controls.Add(this.btnShowPlatformList);
            this.Controls.Add(this.btnShowGenreList);
            this.Controls.Add(this.tbPlatform);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbBKGCoverLink);
            this.Controls.Add(this.tbCoverLink);
            this.Controls.Add(this.tbTrailerLink);
            this.Controls.Add(this.tbDeveloper);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblBKGCoverLink);
            this.Controls.Add(this.lblCoverLink);
            this.Controls.Add(this.lblTrailerLink);
            this.Controls.Add(this.lblRelDate);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAddGame);
            this.Controls.Add(this.clbGenre);
            this.Controls.Add(this.clbPlatform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddGame;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblRelDate;
        private System.Windows.Forms.Label lblTrailerLink;
        private System.Windows.Forms.Label lblCoverLink;
        private System.Windows.Forms.Label lblBKGCoverLink;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDeveloper;
        private System.Windows.Forms.TextBox tbTrailerLink;
        private System.Windows.Forms.TextBox tbCoverLink;
        private System.Windows.Forms.TextBox tbBKGCoverLink;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbPlatform;
        private System.Windows.Forms.CheckedListBox clbGenre;
        private System.Windows.Forms.CheckedListBox clbPlatform;
        private System.Windows.Forms.Button btnShowGenreList;
        private System.Windows.Forms.Button btnShowPlatformList;
    }
}