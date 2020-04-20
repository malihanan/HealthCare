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
    public partial class PatientHome : Form
    {
        public PatientHome()
        {
            InitializeComponent();
            username.Text = Global.Username;
            usertype.Text = Global.Type.ToString();
            user_id.Text = Global.Id.ToString();
        }

        private void view_case_label_Click(object sender, EventArgs e)
        {
            ViewCases viewCases = new ViewCases(this);
            viewCases.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Global.clear();
            Index index = new Index();
            this.Hide();
            index.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {

        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void usertype_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
