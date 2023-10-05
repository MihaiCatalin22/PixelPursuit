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
            lblBanUser = new Label();
            lblSelUser = new Label();
            lblReason = new Label();
            lblSelSD = new Label();
            lblSelED = new Label();
            tbReason = new TextBox();
            dtpSD = new DateTimePicker();
            dtpED = new DateTimePicker();
            cbUsers = new ComboBox();
            btnBack = new Button();
            btnBan = new Button();
            SuspendLayout();
            // 
            // lblBanUser
            // 
            lblBanUser.AutoSize = true;
            lblBanUser.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanUser.Location = new Point(288, 51);
            lblBanUser.Name = "lblBanUser";
            lblBanUser.Size = new Size(150, 32);
            lblBanUser.TabIndex = 0;
            lblBanUser.Text = "Ban a user";
            // 
            // lblSelUser
            // 
            lblSelUser.AutoSize = true;
            lblSelUser.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelUser.Location = new Point(148, 155);
            lblSelUser.Name = "lblSelUser";
            lblSelUser.Size = new Size(140, 29);
            lblSelUser.TabIndex = 1;
            lblSelUser.Text = "Select user:";
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblReason.Location = new Point(106, 216);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(182, 29);
            lblReason.TabIndex = 2;
            lblReason.Text = "Reason for ban:";
            // 
            // lblSelSD
            // 
            lblSelSD.AutoSize = true;
            lblSelSD.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelSD.Location = new Point(97, 366);
            lblSelSD.Name = "lblSelSD";
            lblSelSD.Size = new Size(191, 29);
            lblSelSD.TabIndex = 3;
            lblSelSD.Text = "Select start date:";
            // 
            // lblSelED
            // 
            lblSelED.AutoSize = true;
            lblSelED.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelED.Location = new Point(101, 431);
            lblSelED.Name = "lblSelED";
            lblSelED.Size = new Size(187, 29);
            lblSelED.TabIndex = 4;
            lblSelED.Text = "Select end date:";
            // 
            // tbReason
            // 
            tbReason.Cursor = Cursors.IBeam;
            tbReason.Location = new Point(294, 216);
            tbReason.Margin = new Padding(3, 4, 3, 4);
            tbReason.Multiline = true;
            tbReason.Name = "tbReason";
            tbReason.Size = new Size(211, 98);
            tbReason.TabIndex = 5;
            // 
            // dtpSD
            // 
            dtpSD.Location = new Point(294, 375);
            dtpSD.Margin = new Padding(3, 4, 3, 4);
            dtpSD.Name = "dtpSD";
            dtpSD.Size = new Size(226, 27);
            dtpSD.TabIndex = 6;
            // 
            // dtpED
            // 
            dtpED.Location = new Point(294, 440);
            dtpED.Margin = new Padding(3, 4, 3, 4);
            dtpED.Name = "dtpED";
            dtpED.Size = new Size(226, 27);
            dtpED.TabIndex = 7;
            // 
            // cbUsers
            // 
            cbUsers.FormattingEnabled = true;
            cbUsers.Location = new Point(294, 161);
            cbUsers.Margin = new Padding(3, 4, 3, 4);
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new Size(211, 28);
            cbUsers.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkCyan;
            btnBack.Location = new Point(12, 15);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 76);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back to ban page";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnBan
            // 
            btnBan.BackColor = Color.OrangeRed;
            btnBan.Location = new Point(300, 486);
            btnBan.Margin = new Padding(3, 4, 3, 4);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(143, 54);
            btnBan.TabIndex = 10;
            btnBan.Text = "Ban user";
            btnBan.UseVisualStyleBackColor = false;
            // 
            // BanUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 566);
            Controls.Add(btnBan);
            Controls.Add(btnBack);
            Controls.Add(cbUsers);
            Controls.Add(dtpED);
            Controls.Add(dtpSD);
            Controls.Add(tbReason);
            Controls.Add(lblSelED);
            Controls.Add(lblSelSD);
            Controls.Add(lblReason);
            Controls.Add(lblSelUser);
            Controls.Add(lblBanUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BanUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BanUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBanUser;
        private Label lblSelUser;
        private Label lblReason;
        private Label lblSelSD;
        private Label lblSelED;
        private TextBox tbReason;
        private DateTimePicker dtpSD;
        private DateTimePicker dtpED;
        private ComboBox cbUsers;
        private Button btnBack;
        private Button btnBan;
    }
}