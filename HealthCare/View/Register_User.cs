using HealthCare.Model;
using HealthCare.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class Register_User : Form
    {
        public Register_User()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                error.Text = "Username cannot be empty.";
            }
            else if (password.Text == "")
            {
                error.Text = "Password cannot be empty.";
            }
            else if (patient.Checked == false && doctor.Checked == false &&
                        labtechnician.Checked == false && pharmacist.Checked == false)
            {
                error.Text = "Select a user type.";
            }
            else
            {
                UserType type;
                if (patient.Checked)
                {
                    type = UserType.PATIENT;
                }
                else if (doctor.Checked)
                {
                    type = UserType.DOCTOR;
                }
                else if (labtechnician.Checked)
                {
                    type = UserType.LAB_TECHNICIAN;
                }
                else
                {
                    type = UserType.PHARMACIST;
                }
                User user = new User()
                {
                    Username = username.Text,
                    Password = password.Text,
                    Type = type
                };
                ManageUser mu = new ManageUser();
                bool result = mu.AddUser(user);
                if (result)
                {
                    error.ForeColor = Color.Green;
                    error.Text = "Successful";
                }
                else
                {
                    error.ForeColor = Color.Red;
                    error.Text = "Error registering user.";
                }
            }
        }

        private void login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login obj1 = new Login();
            obj1.Show();
            this.Hide();
        }
    }
}
