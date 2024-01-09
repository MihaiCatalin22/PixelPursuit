namespace Individual_Project
{
	partial class SubmissionReviewForm
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
            lblReviewSubmission = new Label();
            lblUsername = new Label();
            lblGame = new Label();
            lblPlatform = new Label();
            lblDate = new Label();
            lblTime = new Label();
            lblRank = new Label();
            lblLink = new Label();
            btnBack = new Button();
            btnApprove = new Button();
            btnDeny = new Button();
            lblUsername1 = new Label();
            lblGame1 = new Label();
            lblPlatform1 = new Label();
            lblDate1 = new Label();
            lblTime1 = new Label();
            lblRank1 = new Label();
            lblLink1 = new Label();
            SuspendLayout();
            // 
            // lblReviewSubmission
            // 
            lblReviewSubmission.AutoSize = true;
            lblReviewSubmission.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblReviewSubmission.Location = new Point(198, 11);
            lblReviewSubmission.Name = "lblReviewSubmission";
            lblReviewSubmission.Size = new Size(221, 29);
            lblReviewSubmission.TabIndex = 0;
            lblReviewSubmission.Text = "Review submission";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(91, 69);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGame.Location = new Point(129, 115);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(76, 25);
            lblGame.TabIndex = 2;
            lblGame.Text = "Game:";
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlatform.Location = new Point(111, 159);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(98, 25);
            lblPlatform.TabIndex = 3;
            lblPlatform.Text = "Platform:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(141, 203);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(64, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(138, 245);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(67, 25);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time:";
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRank.Location = new Point(57, 291);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(158, 25);
            lblRank.TabIndex = 6;
            lblRank.Text = "Projected rank:";
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLink.Location = new Point(146, 336);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(59, 25);
            lblLink.TabIndex = 7;
            lblLink.Text = "Link:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Aqua;
            btnBack.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(147, 396);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 75);
            btnBack.TabIndex = 8;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Aquamarine;
            btnApprove.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnApprove.Location = new Point(266, 396);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(112, 76);
            btnApprove.TabIndex = 9;
            btnApprove.Text = "Approve this submission";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDeny
            // 
            btnDeny.BackColor = Color.Tomato;
            btnDeny.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeny.Location = new Point(385, 396);
            btnDeny.Margin = new Padding(3, 4, 3, 4);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(112, 75);
            btnDeny.TabIndex = 10;
            btnDeny.Text = "Deny this submission";
            btnDeny.UseVisualStyleBackColor = false;
            btnDeny.Click += btnDeny_Click;
            // 
            // lblUsername1
            // 
            lblUsername1.AutoSize = true;
            lblUsername1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblUsername1.Location = new Point(203, 69);
            lblUsername1.Name = "lblUsername1";
            lblUsername1.Size = new Size(62, 25);
            lblUsername1.TabIndex = 11;
            lblUsername1.Text = "label1";
            // 
            // lblGame1
            // 
            lblGame1.AutoSize = true;
            lblGame1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGame1.Location = new Point(203, 113);
            lblGame1.Name = "lblGame1";
            lblGame1.Size = new Size(62, 25);
            lblGame1.TabIndex = 12;
            lblGame1.Text = "label1";
            // 
            // lblPlatform1
            // 
            lblPlatform1.AutoSize = true;
            lblPlatform1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPlatform1.Location = new Point(203, 157);
            lblPlatform1.Name = "lblPlatform1";
            lblPlatform1.Size = new Size(62, 25);
            lblPlatform1.TabIndex = 13;
            lblPlatform1.Text = "label1";
            // 
            // lblDate1
            // 
            lblDate1.AutoSize = true;
            lblDate1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDate1.Location = new Point(203, 200);
            lblDate1.Name = "lblDate1";
            lblDate1.Size = new Size(62, 25);
            lblDate1.TabIndex = 14;
            lblDate1.Text = "label1";
            // 
            // lblTime1
            // 
            lblTime1.AutoSize = true;
            lblTime1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTime1.Location = new Point(203, 245);
            lblTime1.Name = "lblTime1";
            lblTime1.Size = new Size(62, 25);
            lblTime1.TabIndex = 15;
            lblTime1.Text = "label1";
            // 
            // lblRank1
            // 
            lblRank1.AutoSize = true;
            lblRank1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRank1.Location = new Point(203, 291);
            lblRank1.Name = "lblRank1";
            lblRank1.Size = new Size(62, 25);
            lblRank1.TabIndex = 16;
            lblRank1.Text = "label1";
            // 
            // lblLink1
            // 
            lblLink1.AutoSize = true;
            lblLink1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLink1.Location = new Point(203, 336);
            lblLink1.Name = "lblLink1";
            lblLink1.Size = new Size(62, 25);
            lblLink1.TabIndex = 17;
            lblLink1.Text = "label1";
            lblLink1.Click += lblLink1_Click;
            // 
            // SubmissionReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 504);
            Controls.Add(lblLink1);
            Controls.Add(lblRank1);
            Controls.Add(lblTime1);
            Controls.Add(lblDate1);
            Controls.Add(lblPlatform1);
            Controls.Add(lblGame1);
            Controls.Add(lblUsername1);
            Controls.Add(btnDeny);
            Controls.Add(btnApprove);
            Controls.Add(btnBack);
            Controls.Add(lblLink);
            Controls.Add(lblRank);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(lblPlatform);
            Controls.Add(lblGame);
            Controls.Add(lblUsername);
            Controls.Add(lblReviewSubmission);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SubmissionReviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Submission Review";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReviewSubmission;
		private Label lblUsername;
		private Label lblGame;
		private Label lblPlatform;
		private Label lblDate;
		private Label lblTime;
		private Label lblRank;
		private Label lblLink;
		private Button btnBack;
		private Button btnApprove;
		private Button btnDeny;
		private Label lblUsername1;
		private Label lblGame1;
		private Label lblPlatform1;
		private Label lblDate1;
		private Label lblTime1;
		private Label lblRank1;
		private Label lblLink1;
	}
}