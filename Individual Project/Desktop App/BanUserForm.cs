using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class BanUserForm : Form
    {
        private UserController userController = new(new UserDAL());
        private BanController banController = new(new BanDAL());
        private User loggedInUser;
        private User user1;
        public BanUserForm(User user, User admin)
        {
            InitializeComponent();
            loggedInUser = admin;
            user1 = user;

            foreach (User u in userController.ReadAllUsers())
            {
				if (!u.Banned.HasValue || !u.Banned.Value && u.Id != loggedInUser.Id)
				{
                    cbUsers.Items.Add(u.Username);
                }
            }

			UpdateFormDisplay();
			dtpSD.Value = DateTime.Today;
            dtpED.Value = DateTime.Today;
            tbReason.Text = string.Empty;
        }
		private void UpdateFormDisplay()
		{
			if (user1.Username == null)
			{
				lblSelUser.Text = "Select a user:";
				cbUsers.SelectedIndex = -1;
			}
			else
			{
				lblSelUser.Text = "Selected user:";
				cbUsers.Enabled = false;
				cbUsers.SelectedItem = user1.Username;
			}
		}
		private void btnBack_Click(object sender, EventArgs e)
        {
            BansForm bansForm = new BansForm(loggedInUser);
            this.Hide();
            bansForm.ShowDialog();
            this.Close();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
			try
			{
				ValidateInputs();
				BanUser();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void ValidateInputs()
		{
			if (cbUsers.SelectedIndex == -1)
				throw new InvalidOperationException("Please select a user to ban.");

			if (dtpSD.Value.Date < DateTime.Today)
				throw new InvalidOperationException("Start date cannot be in the past.");

			if (dtpED.Value.Date <= dtpSD.Value.Date)
				throw new InvalidOperationException("End date must be after the start date.");

			if (string.IsNullOrWhiteSpace(tbReason.Text))
				throw new InvalidOperationException("Please provide a reason for the ban.");
		}

		private void BanUser()
		{
			User userToBan = userController.GetUserFromUsername(cbUsers.SelectedItem.ToString());
			if (userToBan.Id == loggedInUser.Id)
				throw new InvalidOperationException("You cannot ban yourself.");

			DateOnly startDate = DateOnly.FromDateTime(dtpSD.Value);
			DateOnly endDate = DateOnly.FromDateTime(dtpED.Value);
			string reason = tbReason.Text;

			Ban ban = new Ban(startDate, endDate, reason, userToBan, loggedInUser, true);
			if (banController.Create(ban))
			{
				MessageBox.Show("User was successfully banned.");
				btnBack_Click(null, null);
			}
			else
			{
				MessageBox.Show("Failed to ban the user. Please try again.");
			}
		}
	}
}
