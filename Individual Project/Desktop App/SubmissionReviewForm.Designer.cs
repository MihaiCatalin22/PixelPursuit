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
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(92, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGame.Location = new Point(129, 114);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(71, 25);
            lblGame.TabIndex = 2;
            lblGame.Text = "Game:";
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlatform.Location = new Point(111, 159);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(89, 25);
            lblPlatform.TabIndex = 3;
            lblPlatform.Text = "Platform:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(141, 202);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(138, 245);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(62, 25);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time:";
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRank.Location = new Point(57, 291);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(143, 25);
            lblRank.TabIndex = 6;
            lblRank.Text = "Projected rank:";
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLink.Location = new Point(146, 336);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(54, 25);
            lblLink.TabIndex = 7;
            lblLink.Text = "Link:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Aqua;
            btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(156, 396);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 58);
            btnBack.TabIndex = 8;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Aquamarine;
            btnApprove.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnApprove.Location = new Point(266, 395);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(104, 58);
            btnApprove.TabIndex = 9;
            btnApprove.Text = "Approve this submission";
            btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnDeny
            // 
            btnDeny.BackColor = Color.Tomato;
            btnDeny.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeny.Location = new Point(376, 396);
            btnDeny.Margin = new Padding(3, 4, 3, 4);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(104, 58);
            btnDeny.TabIndex = 10;
            btnDeny.Text = "Deny this submission";
            btnDeny.UseVisualStyleBackColor = false;
            // 
            // SubmissionReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 504);
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
    }
}