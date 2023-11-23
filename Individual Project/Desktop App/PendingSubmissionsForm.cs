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
    public partial class PendingSubmissionsForm : Form
    {
        private User loggedInUser;
        private SubmissionController submissionController = new(new SubmissionDAL());
        private List<RankedSubmission> submissions = new();
        public PendingSubmissionsForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;

            foreach (RankedSubmission submission in submissionController.ReadPendingAdmin(1, "", "", ""))
            {
                LoadSubmission(submission);
            }
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

        private void btnAllSubmissions_Click(object sender, EventArgs e)
        {
            SubmissionForm submissionForm = new SubmissionForm(loggedInUser);
            this.Hide();
            submissionForm.ShowDialog();
            this.Close();
        }
        private void LoadSubmission(RankedSubmission submission)
        {
            ListViewItem item = new ListViewItem(submission.Id.ToString());
            item.SubItems.Add(submission.User.Username);
            item.SubItems.Add(submission.Game.Name);
            item.SubItems.Add(submission.Platform.ToString());
            item.SubItems.Add(submission.Date.ToShortDateString());
            item.SubItems.Add(submission.TotalTime.ToString());
            lvSubmissions.Items.Add(item);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvSubmissions.Items.Clear();
            if (tbGame.Text != string.Empty || tbUsername.Text != string.Empty || tbPlatform.Text != string.Empty)
            {
                tbGame.Clear();
                tbPlatform.Clear();
                tbUsername.Clear();
            }
            else
            {
                foreach (RankedSubmission submission in submissionController.ReadPendingAdmin(1, "", "", ""))
                {
                    LoadSubmission(submission);
                }
            }
        }

        private void btnReviewSubmission_Click(object sender, EventArgs e)
        {
            if (lvSubmissions.SelectedIndices.Count > 0)
            {
                int index = Convert.ToInt32(lvSubmissions.SelectedItems[0].SubItems[0].Text);
                RankedSubmission submission = submissionController.ReadRanked(index);

                SubmissionReviewForm form = new SubmissionReviewForm(loggedInUser, submission);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No submission was selected.");
            }
        }
        private void Search()
        {
            string username = tbUsername.Text;
            string platform = tbPlatform.Text;
            string game = tbGame.Text;
            

            submissions = submissionController.ReadPendingAdmin(1, username, game, platform).ToList();

            foreach (RankedSubmission submission in submissions)
            {
                LoadSubmission(submission);
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

        private void tbGenre_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void tbPlatform_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
