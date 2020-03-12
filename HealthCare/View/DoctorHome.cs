using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare.View
{
    public partial class DoctorHome : Form
    {
        public DoctorHome()
        {
            InitializeComponent();
            username.Text = Global.Username;
            usertype.Text = Global.Type.ToString();
        }

        private void detailsForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //adddetails form
        }

        private void addCase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCase addCase = new AddCase();
            addCase.Show();
            this.Hide();
        }

        private void viewCases_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewCases viewCases = new ViewCases();
            viewCases.Show();
            this.Hide();
        }
    }
}

/*
register
login
crud details - make classes extending from User
add case
*/
