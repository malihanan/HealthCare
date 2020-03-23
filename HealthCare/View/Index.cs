using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.Model;

namespace HealthCare.View
{
    public partial class Index : Form
    {
        public Index()
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
                UserFactory fac = new UserFactory();
                UserStore userStore = new UserStore(fac);
                userStore.SetUser(username.Text, password.Text, null);
                User u = userStore.LoginUser();

                if (u != null)
                {
                    error.ForeColor = Color.Green;
                    error.Text = "Successfully Logged in.";
                    Global.Id = u.Id;
                    Global.Username = u.Username;
                    Global.Type = (UserType)u.Type;
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

        private void register_label_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
