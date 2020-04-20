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
    public partial class GiveMedicine : Form
    {
        public GiveMedicine()
        {
            InitializeComponent();
            checkout.Enabled = false;
            if (Global.Type == UserType.LAB_TECHNICIAN)
            {
                give_medicine_label.Text = "GIVE REPORT";
                Amount.Visible = false;
                Days.Visible = false;
                Time.Visible = false;
                Medicine.HeaderText = "Report";
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                int patientid = Int32.Parse(patient_id.Text);
                error.Text = "";
                dataGridView1.DataSource = this.PopulateDataGridView();
                checkout.Enabled = true;
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[0].ReadOnly = false;
            }
            catch (Exception ex)
            {
                error.Text = "Invalid id";
            }
        }

        private DataTable PopulateDataGridView()
        {
            string query = "";
            if(Global.Type == UserType.PHARMACIST)
            {
                query = "SELECT MedicineId, Name, Time, Amount, Days " +
                            "FROM[Prescription], [Medicine], [Case] " +
                            "WHERE[Prescription].MedicineId = [Medicine].Id and " +
                            "[Prescription].CaseId = [Case].Id and " +
                            "[Case].PatientId = @Id and " +
                            "([Prescription].MedicineId != 1 and [Prescription].MedicineId != 2) and " +
                            "DATEADD(day, Prescription.Days, Prescription.Date) >= @Date and " +
                            "Prescription.Bought = 0;";
            }
            else
            {
                query = "SELECT MedicineId, Name, Time, Amount, Days " +
                            "FROM[Prescription], [Medicine], [Case] " +
                            "WHERE[Prescription].MedicineId = [Medicine].Id and " +
                            "[Prescription].CaseId = [Case].Id and " +
                            "[Case].PatientId = @Id and " +
                            "([Prescription].MedicineId = 1 or [Prescription].MedicineId = 2) and " +
                            "DATEADD(day, Prescription.Days, Prescription.Date) >= @Date and " +
                            "Prescription.Bought = 0;";
            }
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Int32.Parse(patient_id.Text));
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    if (Convert.ToBoolean(row.Cells["Give"].Value))
                    {
                        ManagePrescription mp = new ManagePrescription();
                        mp.giveMedicine(Int32.Parse(row.Cells["Id"].Value.ToString()), Int32.Parse(patient_id.Text));
                    }
                }
            }
            PharmacistHome pharmacistHome = new PharmacistHome();
            this.Hide();
            pharmacistHome.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            PharmacistHome pharmacistHome = new PharmacistHome();
            this.Hide();
            pharmacistHome.Show();
        }
    }
}
