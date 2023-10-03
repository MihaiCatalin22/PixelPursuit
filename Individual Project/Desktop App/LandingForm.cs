using Class_Library.Controllers;
using Class_Library.DAL;
using Class_Library.Classes;
using Class_Library.Interfaces;
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
    public partial class LandingForm : Form
    {
        private User loggedInUser;
        public LandingForm(User admin)
        {
            InitializeComponent();
            loggedInUser = admin;
            lblWelcome.Text = $"Welcome, {loggedInUser.Username}!";

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
