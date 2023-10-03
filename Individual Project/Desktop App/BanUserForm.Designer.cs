namespace Individual_Project
{
    partial class BanUserForm
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
            this.lblBanUser = new System.Windows.Forms.Label();
            this.lblSelUser = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblSelSD = new System.Windows.Forms.Label();
            this.lblSelED = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.dtpSD = new System.Windows.Forms.DateTimePicker();
            this.dtpED = new System.Windows.Forms.DateTimePicker();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBanUser
            // 
            this.lblBanUser.AutoSize = true;
            this.lblBanUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanUser.Location = new System.Drawing.Point(288, 41);
            this.lblBanUser.Name = "lblBanUser";
            this.lblBanUser.Size = new System.Drawing.Size(150, 32);
            this.lblBanUser.TabIndex = 0;
            this.lblBanUser.Text = "Ban a user";
            // 
            // lblSelUser
            // 
            this.lblSelUser.AutoSize = true;
            this.lblSelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelUser.Location = new System.Drawing.Point(148, 124);
            this.lblSelUser.Name = "lblSelUser";
            this.lblSelUser.Size = new System.Drawing.Size(140, 29);
            this.lblSelUser.TabIndex = 1;
            this.lblSelUser.Text = "Select user:";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(106, 173);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(182, 29);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Reason for ban:";
            // 
            // lblSelSD
            // 
            this.lblSelSD.AutoSize = true;
            this.lblSelSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelSD.Location = new System.Drawing.Point(97, 293);
            this.lblSelSD.Name = "lblSelSD";
            this.lblSelSD.Size = new System.Drawing.Size(191, 29);
            this.lblSelSD.TabIndex = 3;
            this.lblSelSD.Text = "Select start date:";
            // 
            // lblSelED
            // 
            this.lblSelED.AutoSize = true;
            this.lblSelED.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelED.Location = new System.Drawing.Point(101, 345);
            this.lblSelED.Name = "lblSelED";
            this.lblSelED.Size = new System.Drawing.Size(187, 29);
            this.lblSelED.TabIndex = 4;
            this.lblSelED.Text = "Select end date:";
            // 
            // tbReason
            // 
            this.tbReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbReason.Location = new System.Drawing.Point(294, 173);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(211, 79);
            this.tbReason.TabIndex = 5;
            // 
            // dtpSD
            // 
            this.dtpSD.Location = new System.Drawing.Point(294, 300);
            this.dtpSD.Name = "dtpSD";
            this.dtpSD.Size = new System.Drawing.Size(226, 22);
            this.dtpSD.TabIndex = 6;
            // 
            // dtpED
            // 
            this.dtpED.Location = new System.Drawing.Point(294, 352);
            this.dtpED.Name = "dtpED";
            this.dtpED.Size = new System.Drawing.Size(226, 22);
            this.dtpED.TabIndex = 7;
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(294, 129);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(211, 24);
            this.cbUsers.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 61);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back to ban page";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBan.Location = new System.Drawing.Point(300, 389);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(143, 43);
            this.btnBan.TabIndex = 10;
            this.btnBan.Text = "Ban user";
            this.btnBan.UseVisualStyleBackColor = false;
            // 
            // BanUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.dtpED);
            this.Controls.Add(this.dtpSD);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.lblSelED);
            this.Controls.Add(this.lblSelSD);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblSelUser);
            this.Controls.Add(this.lblBanUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BanUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanUser;
        private System.Windows.Forms.Label lblSelUser;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblSelSD;
        private System.Windows.Forms.Label lblSelED;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.DateTimePicker dtpSD;
        private System.Windows.Forms.DateTimePicker dtpED;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBan;
    }
}