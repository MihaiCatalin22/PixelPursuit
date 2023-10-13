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
    public partial class UserDetailsForm : Form
    {
        private User loggedInUser;
        private User user1;
        public UserDetailsForm(User user, User admin)
        {
            InitializeComponent();
            loggedInUser = admin;
            user1 = user;

            lblUsername.Text = "Username: " + user.Username;
            lblEmail.Text = "Email: " + user.Email;
            lblRegDate.Text = "Registration date: " + user.RegistrationDate;
            if (user.Banned == true)
                lblBanned.Text = "Banned";
            else
                lblBanned.Text = "Not banned";
            lblBio.Text = "Bio: " + user.Bio;
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
