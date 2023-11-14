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
    public partial class BanUserForm : Form
    {
        private UserController userController = new(new UserDAL());
        private BanController banController = new(new BanDAL());
        private User loggedInUser;
        private User user1;
        public BanUserForm(User user, User admin)
        {
            InitializeComponent();
            loggedInUser = admin;
            user1 = user;

            foreach (User u in userController.ReadAllUsers())
            {
                if (u.Banned == false)
                {
                    cbUsers.Items.Add(u.Username);
                }
            }

            if (user1.Username == null)
            {
                lblSelUser.Text = "Select a user:";
                cbUsers.SelectedIndex = -1;
            }
            else
            {
                lblSelUser.Text = "Selected user:";
                cbUsers.Enabled = false;
                cbUsers.SelectedItem = user1.Username;
            }
            dtpSD.Value = DateTime.Today;
            dtpED.Value = DateTime.Today;
            tbReason.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BansForm bansForm = new BansForm(loggedInUser);
            this.Hide();
            bansForm.ShowDialog();
            this.Close();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            if (cbUsers.SelectedIndex != -1 && dtpSD.Value >= DateTime.Now && dtpED.Value > DateTime.Now && tbReason.Text != string.Empty)
            {
                User userToBan = userController.GetUserFromUsername(cbUsers.SelectedItem.ToString());
                DateOnly startDate = DateOnly.FromDateTime(dtpSD.Value);
                DateOnly endDate = DateOnly.FromDateTime(dtpED.Value);
                string reason = tbReason.Text;
                Ban ban = new(startDate, endDate, reason, userToBan, loggedInUser);
                if (banController.Create(ban))
                {
                    MessageBox.Show("User was succesfully banned.");
                    btnBack_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Please provide all the details needed.");
                }
            }
        }
    }
}
