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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                error.Text = "Username cannot be empty.";
            }
            else if (password.Text == "")
            {
                error.Text = "Password cannot be empty.";
            }
            else
            {
                User user = new User()
                {
                    Username = username.Text,
                    Password = password.Text,
                };
                ManageUser mu = new ManageUser();
                User u = mu.LoginUser(user);
                if (u != null)
                {
                    error.ForeColor = Color.Green;
                    error.Text = "Successfully Logged in.";
                    Global.Id = u.Id;
                    Global.Username = u.Username;
                    Global.Type = u.Type;
                    if (u.Type == UserType.DOCTOR)
                    {
                        DoctorHome obj1 = new DoctorHome();
                        obj1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    error.ForeColor = Color.Red;
                    error.Text = "Invalid Username or Password.";
                }
            }
        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_User obj1 = new Register_User();
            obj1.Show();
            this.Hide();
        }
    }
}
