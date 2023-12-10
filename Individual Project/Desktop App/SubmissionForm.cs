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
    public partial class SubmissionForm : Form
    {
        private User loggedInUser;
        private SubmissionController submissionController = new(new SubmissionDAL());
        private List<RankedSubmission> submissions = new();
        public SubmissionForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;

            foreach (RankedSubmission submission in submissionController.ReadApprovedAdmin(1, "", "", ""))
            {
                LoadSubmission(submission);
            }
        }
        private void LoadSubmission(RankedSubmission submission)
        {
			try
			{
				ListViewItem item = new ListViewItem(submission.Id.ToString());
				item.SubItems.Add(submission.Rank.ToString());
				item.SubItems.Add(submission.User.Username);
				item.SubItems.Add(submission.Game.Name);
				item.SubItems.Add(submission.Platform.ToString());
				item.SubItems.Add(submission.Date.ToShortDateString());
				item.SubItems.Add(submission.TotalTime.ToString());
				lvSubmissions.Items.Add(item);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading submission: {ex.Message}");
			}
		}
        private void btnPendingSubmissions_Click(object sender, EventArgs e)
        {
            PendingSubmissionsForm pendingSubmissionsForm = new PendingSubmissionsForm(loggedInUser);
            this.Hide();
            pendingSubmissionsForm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnBans_Click(object sender, EventArgs e)
        {
            BansForm bansForm = new BansForm(loggedInUser);
            this.Hide();
            bansForm.ShowDialog();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(loggedInUser);
            this.Hide();
            usersForm.ShowDialog();
            this.Close();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            GamesForm gamesForm = new GamesForm(loggedInUser);
            this.Hide();
            gamesForm.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm(loggedInUser);
            this.Hide();
            landingForm.ShowDialog();
            this.Close();
        }

        private void btnDelSubmission_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					int index = Convert.ToInt32(lvSubmissions.SelectedItems[0].SubItems[0].Text);
					RankedSubmission submission = submissionController.ReadRanked(index);

					if (submissionController.Delete(submission))
					{
						MessageBox.Show("The submission was deleted successfully.");
						RefreshSubmissionsList();
					}
					else
					{
						MessageBox.Show("There was an error deleting the submission.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error deleting submission: {ex.Message}");
				}
			}
			else
			{
				MessageBox.Show("No submission was selected.");
			}
		}
		private void RefreshSubmissionsList()
		{
			lvSubmissions.Items.Clear();
			foreach (RankedSubmission submission in submissionController.ReadApprovedAdmin(1, "", "", ""))
			{
				LoadSubmission(submission);
			}
		}
		private void btnClear_Click(object sender, EventArgs e)
        {
			ClearSearchAndReload();
		}
		private void ClearSearchAndReload()
		{
			tbGame.Clear();
			tbPlatform.Clear();
			tbUsername.Clear();
			RefreshSubmissionsList();
		}
		private void Search()
        {
			try
			{
				string username = tbUsername.Text;
				string platform = tbPlatform.Text;
				string game = tbGame.Text;

				submissions = submissionController.ReadApprovedAdmin(1, username, game, platform).ToList();
				if (submissions.Count == 0)
				{
					MessageBox.Show("No submissions found matching the search criteria.");
					tbUsername.Clear();
					tbPlatform.Clear();
					tbGame.Clear();
					return;
				}

				lvSubmissions.Items.Clear();
				foreach (RankedSubmission submission in submissions)
				{
					LoadSubmission(submission);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error during search: {ex.Message}");
			}
		}
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void tbGame_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void tbPlatform_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
