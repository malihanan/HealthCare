using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare.View
{
    public partial class ViewCase : Form
    {
        Form prevForm;
        Case c = null;
        public ViewCase(int id, Form form)
        {
            InitializeComponent();
            prevForm = form;
            ManageCase mc = new ManageCase();
            ManageUser mu = new ManageUser();
            c = mc.GetCase(id);
            case_label.Text = "(" + c.Id.ToString() + ") " + c.Title;
            doctor.Text = "(" + c.DoctorId.ToString() + ") " + mu.getUser(c.DoctorId).Username;
            patient.Text = "(" + c.PatientId.ToString() + ") " + mu.getUser(c.PatientId).Username;
            disease.Text = c.Disease;
            description.Text = c.Description;
            creation_date.Text = c.OpenDate.ToShortDateString();
            if (c.ClosingDate == null)
            {
                closing_date.Visible = false;
                closing_summary.Visible = false;
                label10.Visible = false;
                label7.Visible = false;
            }
            else
            {
                closing_date.Text = ((DateTime)c.ClosingDate).ToShortDateString();
                closing_summary.Text = c.ClosingSummary;
            }
            dataGridView1.DataSource = this.PopulateDataGridView();
        }

        private DataTable PopulateDataGridView()
        {
            string query = "SELECT MedicineId, Name FROM [Prescription], [Medicine] where Prescription.MedicineId = Medicine.Id and Prescription.CaseId = @CaseId;";
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CaseId", c.Id);
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }
    }
}
