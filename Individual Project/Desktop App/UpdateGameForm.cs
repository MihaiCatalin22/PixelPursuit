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
            if (tbTitle.Text == selectedGame.Name && tbDeveloper.Text == selectedGame.Company && DateOnly.FromDateTime(dtpReleaseDate.Value) == selectedGame.ReleaseDate && tbTrailerLink.Text == selectedGame.TrailerLink && tbGenre.Text == selectedGame.Genres && tbPlatform.Text == selectedGame.Platforms && tbCoverLink.Text == selectedGame.PictureLink && tbBKGCoverLink.Text == selectedGame.BackgroundPictureLink)
            {
                btnUpdateGame.Visible = false;
                btnBack.Visible = true;
            }
            else
            {
                btnUpdateGame.Visible = true;
                btnBack.Visible = false;
            }
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
                MessageBox.Show("Game was updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update game.");
            }
            CheckValidState(sender, e);
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            CheckValidState(sender, e);
        }

        private void tbDeveloper_TextChanged(object sender, EventArgs e)
        {
            CheckValidState(sender, e);
        }

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            CheckValidState(sender, e);
        }

        private void tbTrailerLink_TextChanged(object sender, EventArgs e)
        {
            CheckValidState(sender, e);
        }

        private void tbCoverLink_TextChanged(object sender, EventArgs e)
        {
            CheckValidState(sender, e);
        }

        private void tbBKGCoverLink_TextChanged(object sender, EventArgs e)
        {
            CheckValidState(sender, e);
        }

        private void tbGenre_TextChanged(object sender, EventArgs e)
        {
            CheckValidState(sender, e);
        }

        private void tbPlatform_TextChanged(object sender, EventArgs e)
        {
            CheckValidState(sender, e);
        }
    }
}
