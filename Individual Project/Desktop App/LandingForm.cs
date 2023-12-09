using Class_Library.Controllers;
using Class_Library.DAL;
using Class_Library.Classes;
using Class_Library.Interfaces;
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
    public partial class LandingForm : Form
    {
        private SubmissionController submissionController = new(new SubmissionDAL());
        private BanController banController = new(new BanDAL());
        private User loggedInUser;
        public LandingForm(User admin)
        {
            InitializeComponent();
			if (admin == null)
			{
				throw new ArgumentNullException(nameof(admin), "Admin user cannot be null.");
			}

			loggedInUser = admin;
            lblWelcome.Text = $"Welcome, {loggedInUser.Username}!";

            UpdateSubmissionsInfo();
            UpdateBansInfo();
        }
		private void UpdateSubmissionsInfo()
		{
			try
			{
				int numberPending = submissionController.ReadPendingAdmin(1, "", "", "").Count();
				lblSubmAnnouncement.Text = numberPending > 0 ?
					$"There are {numberPending} pending submissions! \nReview them now." :
					"There are no pending submissions at the moment.";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to retrieve submission data: {ex.Message}");
			}
		}

		private void UpdateBansInfo()
		{
			try
			{
				var allBans = banController.ReadAll();
				int totalBans = allBans.Length;
				int activeBans = allBans.Count(ban => ban.IsActive && ban.EndDate > DateOnly.FromDateTime(DateTime.Now));

				lblUsersBanned.Text = activeBans > 0 ?
					$"Currently, there are {activeBans} active bans.\nThere have been {totalBans} bans in total until now." :
					$"Currently, there are no active bans.\nThere have been {totalBans} bans in total until now.";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to retrieve ban data: {ex.Message}");
			}
		}
		private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
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

        private void btnBans_Click(object sender, EventArgs e)
        {
            BansForm bansForm = new BansForm(loggedInUser);
            this.Hide();
            bansForm.ShowDialog();
            this.Close();
        }

        private void btnInfoBans_Click(object sender, EventArgs e)
        {
            BansForm bansForm = new BansForm(loggedInUser);
            this.Hide();
            bansForm.ShowDialog();
            this.Close();
        }

        private void btnSubmAnnouncement_Click(object sender, EventArgs e)
        {
            PendingSubmissionsForm PsubmissionForm = new PendingSubmissionsForm(loggedInUser);
            this.Hide();
            PsubmissionForm.ShowDialog();
            this.Close();
        }
    }
}
