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
    public partial class BanUserForm : Form
    {
        private User loggedInUser;
        public BanUserForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BansForm bansForm = new BansForm(loggedInUser);
            this.Hide();
            bansForm.ShowDialog();
            this.Close();
        }
    }
}
