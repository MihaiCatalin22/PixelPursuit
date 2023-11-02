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
            btnAddGame.Visible = false;
            btnBack.Visible = true;
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
            Game game = new Game(tbTitle.Text, tbDeveloper.Text, DateOnly.FromDateTime(dtpReleaseDate.Value), tbTrailerLink.Text, tbGenre.Text, tbPlatform.Text, tbCoverLink.Text, tbBKGCoverLink.Text);
            if (gameController.Create(game))
            {
                MessageBox.Show("Game added succesfully.");
            }
            else
            {
                MessageBox.Show("Error adding game. Try again.");
            }
            ClearPage();
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
        private void CloseLists(object sender, EventArgs e)
        {
            if (clbGenre.Visible)
                btnShowGenreList_Click(sender, e);
            if (clbPlatform.Visible)
                btnShowPlatformList_Click(sender, e);
        }
        private void CheckValidState(object sender, EventArgs e)
        {
            if (tbTitle.Text.Length > 0 && tbDeveloper.Text.Length > 0 && dtpReleaseDate.Value.ToString().Length > 0 && tbTrailerLink.Text.Length > 0 && tbGenre.Text.Length > 0 && tbPlatform.Text.Length > 0 && tbCoverLink.Text.Length > 0 && tbBKGCoverLink.Text.Length > 0)
            {
                btnAddGame.Visible = true;
                btnBack.Visible = false;
            }
            else
            {
                btnAddGame.Visible = false;
                btnBack.Visible = true;
            }
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
