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
    public partial class AddGameForm : Form
    {
        private User loggedInUser;
        private GameController gameController = new GameController(new GameDAL());
        public AddGameForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            clbGenre.DataSource = Enum.GetValues(typeof(EnumGenre));
            clbPlatform.DataSource = Enum.GetValues(typeof(EnumPlatform));
            btnBack.Visible = true;
            ClearPage();
        }
        private void ClearPage()
        {
            tbTitle.Text = string.Empty;
            tbDeveloper.Text = string.Empty;
            dtpReleaseDate.Text = string.Empty;
            tbTrailerLink.Text = string.Empty;
            tbGenre.Text = string.Empty;
            tbPlatform.Text = string.Empty;
            tbCoverLink.Text = string.Empty;
            tbBKGCoverLink.Text = string.Empty;

            foreach (int i in clbGenre.CheckedIndices)
            {
                clbGenre.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in clbPlatform.CheckedIndices)
            {
                clbPlatform.SetItemCheckState(i, CheckState.Unchecked);
            }
            clbGenre.Visible = false;
            clbPlatform.Visible = false;
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

        private void btnAddGame_Click(object sender, EventArgs e)
        {
			try
			{
				ValidateInput();
				Game game = new Game(tbTitle.Text, tbDeveloper.Text, DateOnly.FromDateTime(dtpReleaseDate.Value), tbTrailerLink.Text, tbGenre.Text, tbPlatform.Text, tbCoverLink.Text, tbBKGCoverLink.Text);

				if (gameController.Create(game))
				{
					MessageBox.Show("Game added successfully.");
                    ClearPage();
				}
				else
				{
					MessageBox.Show("Error adding game. Game might already exist.");
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
                throw new InvalidOperationException("Game company cannot be empty.");
			if (!IsValidUrl(tbTrailerLink.Text))
				throw new InvalidOperationException("Invalid trailer link URL.");
			if (!IsValidUrl(tbCoverLink.Text))
				throw new InvalidOperationException("Invalid game cover link URL.");
			if (!IsValidUrl(tbBKGCoverLink.Text))
				throw new InvalidOperationException("Invalid game background cover link URL.");
			if (string.IsNullOrWhiteSpace(tbGenre.Text))
                throw new InvalidOperationException("Game genres cannot be empty.");
            if (string.IsNullOrWhiteSpace(tbPlatform.Text))
                throw new InvalidOperationException("Game platforms cannot be empty.");
			if (dtpReleaseDate.Value.Date > DateTime.Now.Date)
				throw new InvalidOperationException("Release date cannot be in the future.");
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
		private void CloseLists(object sender, EventArgs e)
        {
            if (clbGenre.Visible)
                btnShowGenreList_Click(sender, e);
            if (clbPlatform.Visible)
                btnShowPlatformList_Click(sender, e);
        }
        private void CheckValidState(object sender, EventArgs e)
        {
			btnAddGame.Visible = !string.IsNullOrWhiteSpace(tbTitle.Text) &&
						 !string.IsNullOrWhiteSpace(tbDeveloper.Text) &&
						 dtpReleaseDate.Value != null &&
						 !string.IsNullOrWhiteSpace(tbTrailerLink.Text) &&
						 !string.IsNullOrWhiteSpace(tbGenre.Text) &&
						 !string.IsNullOrWhiteSpace(tbPlatform.Text) &&
						 !string.IsNullOrWhiteSpace(tbCoverLink.Text) &&
						 !string.IsNullOrWhiteSpace(tbBKGCoverLink.Text);

			btnBack.Visible = !btnAddGame.Visible;
		}

		private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateCheckedListBoxText(clbGenre, tbGenre);
		}

		private void cbPlatform_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateCheckedListBoxText(clbPlatform, tbPlatform);
		}

		private void UpdateCheckedListBoxText(CheckedListBox clb, TextBox tb)
		{
			tb.Text = string.Join(", ", clb.CheckedItems.Cast<object>());
		}
	}
}
