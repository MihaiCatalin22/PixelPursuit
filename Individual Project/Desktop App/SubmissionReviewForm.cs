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
    public partial class SubmissionReviewForm : Form
    {
        private User loggedInUser;
        public SubmissionReviewForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SubmissionForm submissionForm = new SubmissionForm(loggedInUser);
            this.Hide();
            submissionForm.ShowDialog();
            this.Close();
        }
    }
}
