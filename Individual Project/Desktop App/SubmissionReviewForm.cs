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
	public partial class SubmissionReviewForm : Form
	{
		private User loggedInUser = null;
		private RankedSubmission rankedSubmission = null;
		private UserController userController = new UserController(new UserDAL());
		private SubmissionController submissionController = new SubmissionController(new SubmissionDAL());
		private GameController gameController = new GameController(new GameDAL());
		public SubmissionReviewForm(User user, RankedSubmission submission)
		{
			InitializeComponent();
			loggedInUser = user;
			rankedSubmission = submission;

			lblUsername1.Text = rankedSubmission.User.Username;
			lblGame1.Text = rankedSubmission.Game.Name;
			lblPlatform1.Text = rankedSubmission.Platform.ToString();
			lblDate1.Text = rankedSubmission.Date.ToShortDateString();
			lblTime1.Text = rankedSubmission.TotalTime.ToString();
			lblRank1.Text = submissionController.PredictRank(rankedSubmission)[0].ToString();
			lblLink1.Text = rankedSubmission.Link;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			SubmissionForm submissionForm = new SubmissionForm(loggedInUser);
			this.Hide();
			submissionForm.ShowDialog();
			this.Close();
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			rankedSubmission.Pending = false;
			rankedSubmission.Approved = true;
			rankedSubmission.Rank = submissionController.CalculateRank(rankedSubmission);

			if (submissionController.UpdateRanked(rankedSubmission))
			{
				User user = userController.GetUserFromId(rankedSubmission.User.Id);
				Game game = gameController.ReadByID(rankedSubmission.Game.ID);

				if (rankedSubmission.TotalTime < game.BestTime)
				{
					game.BestTime = rankedSubmission.TotalTime;
				}
				game.TotalTime = game.TotalTime.Add(rankedSubmission.TotalTime);
				game.NumberOfRuns++;

				if (!gameController.UserPlayedBefore(user, game))
				{
					game.NumberOfPlayers++;
				}
				gameController.Update(game);
				MessageBox.Show("The submission was approved succesfully.");
			}
			else
			{
				MessageBox.Show("There was an error approving the submission. Try again.");
			}
			btnBack_Click(sender, e);
		}

		private void btnDeny_Click(object sender, EventArgs e)
		{
			rankedSubmission.Pending = false;
			rankedSubmission.Approved = false;
			if (submissionController.UpdateRanked(rankedSubmission))
			{
				MessageBox.Show("The submission was rejected successfully.");
			}
			else
			{
				MessageBox.Show("There was an error rejecting the submission. Try again.");
			}
			btnBack_Click(sender, e);
		}
	}
}
