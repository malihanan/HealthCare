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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                error.ForeColor = Color.Red;
                error.Text = "Username cannot be empty.";
            }
            else if (password.Text == "")
            {
                error.ForeColor = Color.Red;
                error.Text = "Password cannot be empty.";
            }
            else if (patient.Checked == false && doctor.Checked == false &&
                        labtechnician.Checked == false && pharmacist.Checked == false)
            {
                error.ForeColor = Color.Red;
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
                UserFactory fac = new UserFactory();
                UserStore userStore = new UserStore(fac);
                userStore.SetUser(username.Text, password.Text, type);

                bool result = userStore.AddUser();
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

        private void login_label_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
