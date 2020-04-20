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
            user_id.Text = Global.Id.ToString();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void add_case_label_Click(object sender, EventArgs e)
        {
            AddCase addCase = new AddCase(this);
            addCase.Show();
            this.Hide();
        }

        private void view_case_label_Click(object sender, EventArgs e)
        {
            ViewCases viewCases = new ViewCases(this);
            viewCases.Show();
            this.Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //adddetails form
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Global.clear();
            Index index = new Index();
            this.Hide();
            index.Show();
        }
    }
}

/*
register
login
crud details - make classes extending from User
add case
*/
