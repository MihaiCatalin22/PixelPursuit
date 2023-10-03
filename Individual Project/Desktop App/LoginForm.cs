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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tBUsername.Text;
            string password = tBPassword.Text;

            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }

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
                MessageBox.Show("Incorrect login details.");
                tBUsername.Text = string.Empty;
                tBPassword.Text = string.Empty;
            }
        }
    }
}
