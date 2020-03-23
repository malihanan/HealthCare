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
    public partial class EditCase : Form
    {
        Case c;
        ManageCase mc;
        bool closing;
        DoctorHome doctorHome;

        public EditCase(Form frm, int id)
        {
            InitializeComponent();
            doctorHome = (DoctorHome)frm;
            mc = new ManageCase();
            c = mc.GetCase(id);
            patient_id.Text = c.PatientId.ToString();
            description.Text = c.Description;
            title.Text = c.Title;
            disease.Text = c.Disease;
            closing = false;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (closing)
            {
                bool success = mc.CloseCase(c.Id, description.Text);
                if (success)
                {
                    status.Text = "Successfully closed case.";
                    status.ForeColor = Color.Green;
                }
                else
                {
                    status.Text = "Error closing case.";
                    status.ForeColor = Color.Red;
                }
                edit_button.Enabled = false;
            }
            else
            {
                c.Title = title.Text;
                c.Description = description.Text;
                c.Disease = disease.Text;
                c.ModifyDate = DateTime.Now;
                ManageCase mc = new ManageCase();
                bool success = mc.EditCase(c);
                if (success)
                {
                    status.Text = "Successfully edited case.";
                    status.ForeColor = Color.Green;
                }
                else
                {
                    status.Text = "Error editing case.";
                    status.ForeColor = Color.Red;
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            disease.Enabled = false;
            title.Enabled = false;
            close_button.Enabled = false;
            edit_button.Text = "Close";
            description_label.Text = "Closing Summary";
            closing = true;
        }

        private void view_case_label_Click(object sender, EventArgs e)
        {
            ViewCases viewCases = new ViewCases(doctorHome);
            viewCases.Show();
            this.Hide();
        }

        private void add_case_label_Click(object sender, EventArgs e)
        {
            AddCase addCase = new AddCase(doctorHome);
            addCase.Show();
            this.Hide();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            DoctorHome doctorHome = new DoctorHome();
            doctorHome.Show();
            this.Hide();
        }
    }
}
