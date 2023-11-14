using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class UsersForm : Form
    {
        private User loggedInUser;
        private UserController userController = new(new UserDAL());
        private List<User> users = new List<User>();
        public UsersForm(User admin)
        {
            InitializeComponent();
            loggedInUser = admin;

            foreach (User user in userController.ReadAllUsers())
            {
                LoadUser(user);
            }
        }
        private void LoadUser(User user)
        {
            ListViewItem item = new ListViewItem(user.Id.ToString());
            item.SubItems.Add(user.Username);
            item.SubItems.Add(user.Email);
            item.SubItems.Add(user.RegistrationDate.ToString());
            if (user.Banned == true)
            {
                item.SubItems.Add("Banned.");
            }
            else
            {
                item.SubItems.Add("Not banned.");
            }
            lvUsers.Items.Add(item);
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("No user has been selected.");
            }
            else
            {
                string username = lvUsers.SelectedItems[0].SubItems[1].Text;
                User user = userController.GetUserFromUsername(username);
                UserDetailsForm userDetailsForm = new UserDetailsForm(user, loggedInUser);
                this.Hide();
                userDetailsForm.ShowDialog();
                this.Close();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm(loggedInUser);
            this.Hide();
            landingForm.ShowDialog();
            this.Close();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            GamesForm gamesForm = new GamesForm(loggedInUser);
            this.Hide();
            gamesForm.ShowDialog();
            this.Close();
        }

        private void btnSubmissions_Click(object sender, EventArgs e)
        {
            SubmissionForm submissionForm = new SubmissionForm(loggedInUser);
            this.Hide();
            submissionForm.ShowDialog();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvUsers.Items.Clear();
            if (tbUsername.Text != string.Empty || cbBanned.Checked)
            {
                tbUsername.Clear();
                cbBanned.Checked = false;
            }
            else
            {
                foreach (User user in userController.ReadAllUsers())
                {
                    LoadUser(user);
                }
            }
        }
        private void Search()
        {
            lvUsers.Items.Clear();
            string search = tbUsername.Text;
            bool banned = cbBanned.Checked;

            users = userController.ReadAllUsersSearch(search).ToList();
            foreach (User user in users)
            {
                if (search != string.Empty)
                {
                    if (user.Banned == banned)
                    {
                        LoadUser(user);
                    }
                }
                else
                {
                    if (banned == false)
                    {
                        LoadUser(user);
                    }
                }
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbBanned_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("No user has been selected.");
            }
            else
            {
                string username = lvUsers.SelectedItems[0].SubItems[1].Text;
                User user = userController.GetUserFromUsername(username);

                BanUserForm form = new BanUserForm(user, loggedInUser);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
