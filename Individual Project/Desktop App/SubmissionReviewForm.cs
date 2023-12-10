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

			LoadSubmissionData();

			lblLink1.Click += new EventHandler(lblLink1_Click);
			lblLink1.Cursor = Cursors.Hand;
		}
		private void LoadSubmissionData()
		{
			try
			{
				lblUsername1.Text = rankedSubmission.User.Username;
				lblGame1.Text = rankedSubmission.Game.Name;
				lblPlatform1.Text = rankedSubmission.Platform.ToString();
				lblDate1.Text = rankedSubmission.Date.ToShortDateString();
				lblTime1.Text = rankedSubmission.TotalTime.ToString();
				lblRank1.Text = submissionController.PredictRank(rankedSubmission)[0].ToString();
				lblLink1.Text = rankedSubmission.Link;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to load submission data: " + ex.Message);
			}
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
			try
			{
				PerformSubmissionApproval(true);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while approving submission: " + ex.Message);
			}
		}

		private void btnDeny_Click(object sender, EventArgs e)
		{
			try
			{
				PerformSubmissionApproval(false);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while denying submission: " + ex.Message);
			}
		}
		private void PerformSubmissionApproval(bool approve)
		{
			rankedSubmission.Pending = false;
			rankedSubmission.Approved = approve;
			if (approve)
			{
				rankedSubmission.Rank = submissionController.CalculateRank(rankedSubmission);
			}

			if (submissionController.UpdateRanked(rankedSubmission))
			{
				if (approve)
				{
					UpdateGameStats();
				}
				MessageBox.Show(approve ? "The submission was approved successfully." : "The submission was rejected successfully.");
				btnApprove.Enabled = false;
				btnDeny.Enabled = false;
			}
			else
			{
				MessageBox.Show("There was an error processing the submission. Try again.");
			}
		}
		private void UpdateGameStats()
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
		}

		private void lblLink1_Click(object sender, EventArgs e)
		{
			try
			{
				var url = lblLink1.Text;

				if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
					!url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
				{
					url = "http://" + url;
				}

				if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
				{
					var psi = new System.Diagnostics.ProcessStartInfo
					{
						FileName = url,
						UseShellExecute = true
					};
					System.Diagnostics.Process.Start(psi);
				}
				else
				{
					MessageBox.Show("Invalid URL.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to open link: " + ex.Message);
			}
		}
	}
}
