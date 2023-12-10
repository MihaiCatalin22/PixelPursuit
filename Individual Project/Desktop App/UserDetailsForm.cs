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
    public partial class UserDetailsForm : Form
    {
        private User loggedInUser;
        private User user1;
		private UserController userController;
		private BanController banController;
		public UserDetailsForm(User user, User admin)
        {
            InitializeComponent();
            loggedInUser = admin;
            user1 = user;
			userController = new UserController(new UserDAL());
			banController = new BanController(new BanDAL());

			LoadUserData();
		}
		private void LoadUserData()
		{
			lblUsername.Text = "Username: " + user1.Username;
			lblEmail.Text = "Email: " + user1.Email;
			lblRegDate.Text = "Registration date: " + user1.RegistrationDate.ToString("d");

			UpdateBanStatus();

			lblBio.Text = "Bio: " + (string.IsNullOrEmpty(user1.Bio) ? "No bio provided" : user1.Bio);
		}
		private void UpdateBanStatus()
		{
			var currentBan = banController.ReadAll().FirstOrDefault(ban => ban.User.Id == user1.Id && ban.IsActive);
			if (currentBan != null)
			{
				lblBanned.Text = "Banned";
				lblBanned.ForeColor = Color.Red;
			}
			else
			{
				lblBanned.Text = "Not banned";
				lblBanned.ForeColor = Color.Green;
			}
		}
		private void btnBack_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(loggedInUser);
            this.Hide();
            usersForm.ShowDialog();
            this.Close();
        }
    }
}
