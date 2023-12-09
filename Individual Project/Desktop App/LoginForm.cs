using Class_Library.Classes;
using Class_Library.Interfaces;
using Class_Library.DAL;
using Class_Library.Controllers;
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
    public partial class LoginForm : Form
    {
        private LoginController loginController = new();
        public LoginForm()
        {
            InitializeComponent();
			this.AcceptButton = btnLogin;
		}
		private int loginAttempts = 0;
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = tBUsername.Text;
			string password = tBPassword.Text;

			if (string.IsNullOrWhiteSpace(username))
			{
				MessageBox.Show("Please enter a username.");
				tBUsername.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Please enter a password.");
				tBPassword.Focus();
				return;
			}
			try
			{
				User loggedInUser = loginController.LoginUsernameAdmin(username, password);

				if (loggedInUser != null)
				{
					LandingForm landingForm = new LandingForm(loggedInUser);
					this.Hide();
					landingForm.ShowDialog();
					this.Close();
				}
				else
				{
					loginAttempts++;
					if (loginAttempts >= 5)
					{
						MessageBox.Show("Maximum login attempts reached. Application will now close.");
						Application.Exit();
					}
					else
					{
						MessageBox.Show($"Incorrect login details. You have {5 - loginAttempts} attempts left.");
						tBUsername.Text = string.Empty;
						tBPassword.Text = string.Empty;
						tBUsername.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}		
	}
}
