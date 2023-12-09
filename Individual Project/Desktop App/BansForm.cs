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
    public partial class BansForm : Form
    {
        private readonly User loggedInUser;
        private readonly BanController banController;
        private readonly UserController userController;
        private readonly List<Ban> bans;
        public BansForm(User user)
        {
            InitializeComponent();
			loggedInUser = user ?? throw new ArgumentNullException(nameof(user), "Logged in user cannot be null.");

            banController = new(new BanDAL());
            userController = new(new UserDAL());
            bans = new List<Ban>();

			rbNoDate.Checked = true;

            LoadAllBans();
        }
		private void LoadAllBans()
		{
			try
			{
				foreach (Ban ban in banController.ReadAll())
				{
					LoadBan(ban);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to load bans: {ex.Message}");
			}
		}
		private void btnBack_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm(loggedInUser);
            this.Hide();
            landingForm.ShowDialog();
            this.Close();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            GamesForm gamesForm = new GamesForm(loggedInUser);
            this.Hide();
            gamesForm.ShowDialog();
            this.Close();
        }

        private void btnSubmissions_Click(object sender, EventArgs e)
        {
            SubmissionForm submissionForm = new SubmissionForm(loggedInUser);
            this.Hide();
            submissionForm.ShowDialog();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(loggedInUser);
            this.Hide();
            usersForm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            BanUserForm banUserForm = new(new User(), loggedInUser);
            this.Hide();
            banUserForm.ShowDialog();
            this.Close();
        }
        private void LoadBan(Ban ban)
        {
            ListViewItem item = new ListViewItem(ban.Id.ToString());
            item.SubItems.Add(ban.User.Username);
            item.SubItems.Add(ban.StartDate.ToShortDateString());
            item.SubItems.Add(ban.EndDate.ToShortDateString());
            item.SubItems.Add(ban.Reason);
            lvBans.Items.Add(item);
        }
        private void Search()
        {
			try
			{
				string search = tbUsername.Text.Trim();
				DateOnly date = DateOnly.FromDateTime(dateTimePickerDate.Value);
				bool startDateSearch = rbStartDate.Checked;
				bool noDateSearch = rbNoDate.Checked;

				lvBans.Items.Clear();
				bans.Clear();

				var filteredBans = banController.ReadAllSearch(search).ToList();

				if (!noDateSearch)
				{
					filteredBans = filteredBans.Where(ban => (startDateSearch ? ban.StartDate : ban.EndDate) == date).ToList();
				}

				foreach (Ban ban in filteredBans)
				{
					LoadBan(ban);
				}

				if (!filteredBans.Any())
				{
					MessageBox.Show("No matching bans found.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to search bans: {ex.Message}");
			}
		}
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvBans.Items.Clear();
            tbUsername.Clear();
            dateTimePickerDate.Value = DateTime.Today;
            rbNoDate.Checked = true;
            rbStartDate.Checked = false;
            rbEndDate.Checked = false;
            foreach (Ban ban in banController.ReadAll())
            {
                LoadBan(ban);
            }
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            if (lvBans.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a banned user.");
                return;
            }

            string username = lvBans.SelectedItems[0].SubItems[1].Text;
			var confirmResult = MessageBox.Show($"Are you sure you want to unban '{username}'?",
										"Confirm Unban",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Question);

			if (confirmResult == DialogResult.Yes)
			{
				UnbanUser(username);
                lvBans.Items.Clear();
                Search();
			}
		}
		private void UnbanUser(string username)
		{
			try
			{
				User user = userController.GetUserFromUsername(username);

				if (user == null)
				{
					MessageBox.Show("User not found.");
					return;
				}

				if (banController.UnbanUser(user))
				{
					MessageBox.Show("User has been unbanned successfully.");
					LoadAllBans();
				}
				else
				{
					MessageBox.Show("Unable to unban the user. Please try again later.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error unbanning user: {ex.Message}");
			}
		}
	}
}
