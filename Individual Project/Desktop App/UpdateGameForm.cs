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
    public partial class UpdateGameForm : Form
    {
        private User loggedInUser;
        private GameController gameController = new GameController(new GameDAL());
        private Game selectedGame;
        public UpdateGameForm(User user, Game game)
        {
            InitializeComponent();
            loggedInUser = user;
            selectedGame = game;
            clbGenre.DataSource = Enum.GetValues(typeof(EnumGenre));
            clbPlatform.DataSource = Enum.GetValues(typeof(EnumPlatform));
            btnBack.Visible = true;

            tbTitle.Text = selectedGame.Name;
            tbDeveloper.Text = selectedGame.Company;
            tbGenre.Text = selectedGame.Genres;
            tbPlatform.Text = selectedGame.Platforms;
            tbTrailerLink.Text = selectedGame.TrailerLink;
            dtpReleaseDate.Value = selectedGame.ReleaseDate.ToDateTime(TimeOnly.MinValue);
            tbCoverLink.Text = selectedGame.PictureLink;
            tbBKGCoverLink.Text = selectedGame.BackgroundPictureLink;
			clbGenre.Visible = false;
			clbPlatform.Visible = false;
			InitializeCheckedListBox(clbPlatform, tbPlatform.Text);
			InitializeCheckedListBox(clbGenre, tbGenre.Text);
		}
		private void InitializeCheckedListBox(CheckedListBox clb, string selectedItems)
		{
			string[] selected = selectedItems.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < clb.Items.Count; i++)
			{
				if (selected.Contains(clb.Items[i].ToString()))
				{
					clb.SetItemChecked(i, true);
				}
			}
		}
		private void CloseLists(object sender, EventArgs e)
        {
            if (clbGenre.Visible)
                btnShowGenreList_Click(sender, e);
            if (clbPlatform.Visible)
                btnShowPlatformList_Click(sender, e);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            GamesForm gamesForm = new GamesForm(loggedInUser);
            this.Hide();
            gamesForm.ShowDialog();
            this.Close();
        }

        private void btnShowGenreList_Click(object sender, EventArgs e)
        {
            if (clbPlatform.Visible)
                clbPlatform.Visible = false;

            if (clbGenre.Visible == false)
            {
                tbPlatform.Visible = false;
                btnShowPlatformList.Visible = false;
                clbGenre.Visible = true;
            }
            else
            {
                tbPlatform.Visible = true;
                btnShowPlatformList.Visible = true;
                clbGenre.Visible = false;
            }
        }

        private void btnShowPlatformList_Click(object sender, EventArgs e)
        {
            if (clbGenre.Visible)
                clbGenre.Visible = false;

            if (clbPlatform.Visible == false)
                clbPlatform.Visible = true;
            else
                clbPlatform.Visible = false;
        }

        private void UpdateGameForm_Load(object sender, EventArgs e)
        {
            dtpReleaseDate.Value = selectedGame.ReleaseDate.ToDateTime(TimeOnly.MinValue);
        }

        private void clbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbGenre.Text = string.Empty;
            if (clbGenre.CheckedItems.Count > 0)
            {
                tbGenre.Text = clbGenre.CheckedItems[0].ToString();
                for (int i = 1; i < clbGenre.CheckedItems.Count; i++)
                {
                    tbGenre.Text += ", " + clbGenre.CheckedItems[i].ToString();
                }
            }
        }

        private void clbPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPlatform.Text = string.Empty;
            if (clbPlatform.CheckedItems.Count > 0)
            {
                tbPlatform.Text = clbPlatform.CheckedItems[0].ToString();
                for (int i = 1; i < clbPlatform.CheckedItems.Count; i++)
                {
                    tbPlatform.Text += ", " + clbPlatform.CheckedItems[i].ToString();
                }
            }
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
			try
			{
				ValidateInput();
				selectedGame.Name = tbTitle.Text;
				selectedGame.Company = tbDeveloper.Text;
				selectedGame.ReleaseDate = DateOnly.FromDateTime(dtpReleaseDate.Value);
				selectedGame.TrailerLink = tbTrailerLink.Text;
				selectedGame.Genres = tbGenre.Text;
				selectedGame.Platforms = tbPlatform.Text;
				selectedGame.PictureLink = tbCoverLink.Text;
				selectedGame.BackgroundPictureLink = tbBKGCoverLink.Text;

				if (gameController.Update(selectedGame))
				{
					MessageBox.Show("Game updated successfully.");
				}
				else
				{
					MessageBox.Show("Failed to update game. Please check the details.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void ValidateInput()
		{
			if (string.IsNullOrWhiteSpace(tbTitle.Text))
				throw new InvalidOperationException("Title cannot be empty.");
			if (string.IsNullOrWhiteSpace(tbDeveloper.Text))
				throw new InvalidOperationException("Developer cannot be empty.");
			if (dtpReleaseDate.Value.Date > DateTime.Now.Date)
				throw new InvalidOperationException("Release date cannot be in the future.");
			if (!IsValidUrl(tbTrailerLink.Text))
				throw new InvalidOperationException("Invalid trailer link URL.");
			if (!IsValidUrl(tbCoverLink.Text))
				throw new InvalidOperationException("Invalid game cover link URL.");
			if (!IsValidUrl(tbBKGCoverLink.Text))
				throw new InvalidOperationException("Invalid game background cover link URL.");
			if (string.IsNullOrWhiteSpace(tbGenre.Text))
				throw new InvalidOperationException("Genres cannot be empty.");
			if (string.IsNullOrWhiteSpace(tbPlatform.Text))
				throw new InvalidOperationException("Platforms cannot be empty.");
		}

		private bool IsValidUrl(string url)
		{
			if (string.IsNullOrWhiteSpace(url))
				return false;

			if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
				!url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
			{
				url = "http://" + url;
			}

			return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
				   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
		}
	}
}
