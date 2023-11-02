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
    public partial class GamesForm : Form
    {
        private User loggedInUser;
        private GameController gameController = new(new GameDAL());
        private List<Game> games = new List<Game>();
        public GamesForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;

            foreach (Game game in gameController.ReadAll())
            {
                LoadGame(game);
            }
        }
        private void LoadGame(Game game)
        {
            ListViewItem item = new ListViewItem(game.ID.ToString());
            item.SubItems.Add(game.Name);
            item.SubItems.Add(game.Company);
            lvGames.Items.Add(item);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm(loggedInUser);
            this.Hide();
            landingForm.ShowDialog();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm(loggedInUser);
            this.Hide();
            addGameForm.ShowDialog();
            this.Close();
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            if (lvGames.SelectedIndices.Count > 0)
            {
                int index = Convert.ToInt32(lvGames.SelectedItems[0].SubItems[0].Text);
                Game game = gameController.ReadByID(index);

                UpdateGameForm updateGameForm = new UpdateGameForm(loggedInUser, game);
                this.Hide();
                updateGameForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No game has been selected.");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lvGames.Items.Clear();
            if (tbGame.Text != string.Empty || tbDeveloper.Text != string.Empty)
            {
                tbGame.Clear();
                tbDeveloper.Clear();
            }
            else
            {
                foreach (Game game in gameController.ReadAll())
                {
                    LoadGame(game);
                }
            }
        }
        private void Search()
        {
            lvGames.Items.Clear();
            string game = tbGame.Text;
            string company = tbDeveloper.Text;

            games = gameController.ReadAllSearch(game, company).ToList();

            foreach (Game g in games)
            {
                LoadGame(g);
            }
        }
        private void tbGame_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void tbDeveloper_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            if (lvGames.SelectedIndices.Count > 0)
            {
                int index = Convert.ToInt32(lvGames.SelectedItems[0].SubItems[0].Text);
                gameController.Delete(gameController.ReadByID(index));
                lvGames.Items.Clear();
                foreach (Game game in gameController.ReadAll())
                {
                    LoadGame(game);
                }
            }
            else
            {
                MessageBox.Show("No game has been selected.");
            }
        }
    }
}
