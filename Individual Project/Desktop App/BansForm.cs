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
    public partial class BansForm : Form
    {
        private User loggedInUser;
        private BanController banController = new(new BanDAL());
        private UserController userController = new(new UserDAL());
        List<Ban> bans = new List<Ban>();
        public BansForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;

            rbNoDate.Checked = true;

            foreach (Ban ban in banController.ReadAll())
            {
                LoadBan(ban);
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(loggedInUser);
            this.Hide();
            usersForm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            BanUserForm banUserForm = new(new User(), loggedInUser);
            this.Hide();
            banUserForm.ShowDialog();
            this.Close();
        }
        private void LoadBan(Ban ban)
        {
            ListViewItem item = new ListViewItem(ban.Id.ToString());
            item.SubItems.Add(ban.User.Username);
            item.SubItems.Add(ban.StartDate.ToShortDateString());
            item.SubItems.Add(ban.EndDate.ToShortDateString());
            item.SubItems.Add(ban.Reason);
            lvBans.Items.Add(item);
        }
        private void Search()
        {
            string search = tbUsername.Text;
            DateOnly date = DateOnly.FromDateTime(dateTimePickerDate.Value);
            bool startDate = false;
            bool noDate = false;
            if (rbNoDate.Checked)
            {
                noDate = true;
            }
            if (rbStartDate.Checked)
            {
                noDate = false;
                startDate = true;
            }
            else if (rbEndDate.Checked)
            {
                noDate = false;
                startDate = false;
            }
            lvBans.Items.Clear();
            bans.Clear();
            foreach (Ban ban in banController.ReadAllSearch(search))
            {
                if (noDate)
                {
                    bans.Add(ban);
                }
                else
                {
                    if (startDate)
                    {
                        if (ban.StartDate == date)
                        {
                            bans.Add(ban);
                        }
                    }
                    else
                    {
                        if (ban.EndDate == date)
                        {
                            bans.Add(ban);
                        }
                    }
                }
            }
            foreach (Ban ban in bans)
            {
                LoadBan(ban);
            }
        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvBans.Items.Clear();
            tbUsername.Clear();
            dateTimePickerDate.Value = DateTime.Today;
            rbNoDate.Checked = true;
            rbStartDate.Checked = false;
            rbEndDate.Checked = false;
            foreach (Ban ban in banController.ReadAll())
            {
                LoadBan(ban);
            }
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            if (lvBans.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a banned user.");
                return;
            }

            string username = lvBans.SelectedItems[0].SubItems[1].Text;
            User user = userController.GetUserFromUsername(username);

            if (banController.UnbanUser(user))
            {
                MessageBox.Show("User has been unbanned successfully.");

                lvBans.Items.Clear();
                foreach (Ban ban in banController.ReadAll())
                {
                    LoadBan(ban);
                }
            }
            else
            {
                MessageBox.Show("Unable to unban the user. Please check if the user is currently banned or try again later.");
            }
        }
    }
}
