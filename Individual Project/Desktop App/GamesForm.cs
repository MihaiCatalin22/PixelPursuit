using Class_Library.Classes;
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
        public GamesForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
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
            UpdateGameForm updateGameForm = new UpdateGameForm(loggedInUser);
            this.Hide();
            updateGameForm.ShowDialog();
            this.Close();
        }
    }
}
