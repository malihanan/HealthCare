using HealthCare.Model;
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
    public partial class PharmacistHome : Form
    {
        public PharmacistHome()
        {
            InitializeComponent();
            username.Text = Global.Username;
            usertype.Text = Global.Type.ToString();
            user_id.Text = Global.Id.ToString();
            if(Global.Type == UserType.LAB_TECHNICIAN)
            {
                give_medicine_label.Text = "GIVE REPORT";
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Global.clear();
            Index index = new Index();
            this.Hide();
            index.Show();
        }

        private void give_medicine_label_Click(object sender, EventArgs e)
        {
            GiveMedicine giveMedicine = new GiveMedicine();
            this.Hide();
            giveMedicine.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
    }
}
