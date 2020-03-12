using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.Model;

namespace HealthCare.View
{
    public partial class AddCase : Form
    {
        public AddCase()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (patient_id.Text == "")
            {
                error.Text = "Patient ID cannot be empty.";
            }
            else
            {
                Case c = new Case()
                {
                    DoctorId = Global.Id,
                    PatientId = Int32.Parse(patient_id.Text),
                    OpenDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Title = title.Text,
                    Description = description.Text,
                    Disease = disease.Text
                };
                ManageCase mc = new ManageCase();
                bool success = mc.AddCase(c);
                if (!success)
                {
                    error.Text = "Patient ID doesn't exist";
                }
                else
                {
                    error.Text = "Case added successfully.";
                    error.ForeColor = Color.Green;
                }
            }
        }
    }
}
