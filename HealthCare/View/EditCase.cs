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
    public partial class EditCase : Form
    {
        Case c;
        ManageCase mc;
        ManagePrescription mp;
        bool closing;
        Form prevForm;

        public EditCase(Form frm, int id)
        {
            InitializeComponent();
            prevForm = frm;
            mc = new ManageCase();
            mp = new ManagePrescription();
            c = mc.GetCase(id);
            if(c.ClosingDate == null)
            {
                description.Text = c.Description;
                closing = false;
                searchGridView.DataSource = this.PopulateSearchGridView();
                prescriptionGridView.DataSource = this.PopulatePrescriptionGridView();
            }
            else
            {
                searchGridView.Visible = false;
                searchBox.Visible = false;
                label1.Visible = false;
                description_label.Text = "Closing Summary";
                close_button.Visible = false;
                edit_button.Visible = false;
                description.Text = c.ClosingSummary;
                description.ReadOnly = true;
            }
            patient_id.Text = c.PatientId.ToString();
            title.Text = c.Title;
            disease.Text = c.Disease;
        }

        private DataTable PopulateSearchGridView()
        {
            string query = "SELECT Id, Name FROM [Medicine]";
            query += " WHERE Name LIKE '%' + @Name + '%'";
            query += " OR @Name = ''";
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", searchBox.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private DataTable PopulatePrescriptionGridView()
        {
            string query = "SELECT MedicineId, Name, Time, Amount, Days FROM [Prescription], [Medicine] where Prescription.MedicineId = Medicine.Id and Prescription.CaseId = @CaseId and DATEADD(day, Prescription.Days, Prescription.Date) >= @Date;";
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CaseId", c.Id);
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

        private void edit_button_Click(object sender, EventArgs e)
        {
            status.Text = "";
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
            status.Text = "";
            disease.Enabled = false;
            title.Enabled = false;
            close_button.Enabled = false;
            searchGridView.Visible = false;
            prescriptionGridView.Visible = false;
            searchBox.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            edit_button.Text = "Close";
            description_label.Text = "Closing Summary";
            closing = true;
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            searchGridView.DataSource = this.PopulateSearchGridView();
        }

        private void searchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                status.Text = "";
                try
                {
                    int medicineId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    string time = senderGrid.Rows[e.RowIndex].Cells["Time"].Value.ToString();
                    int amount = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
                    int days = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["Days"].Value.ToString());
                    Prescription p = new Prescription
                    {
                        CaseId = c.Id,
                        MedicineId = medicineId,
                        Time = time,
                        Amount = amount,
                        Days = days,
                        Date = DateTime.Now
                    };
                    mp.AddPrescription(p);
                    prescriptionGridView.DataSource = this.PopulatePrescriptionGridView();

                }
                catch (Exception ex)
                {
                    status.Text = "Unable to add prescription. Check your data.";
                    status.ForeColor = Color.Red;
                    Console.WriteLine(ex);
                }
            }
        }

        private void prescriptionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            status.Text = "";
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int medicineId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["PrescribedId"].Value.ToString());
                string time = senderGrid.Rows[e.RowIndex].Cells["PrescribedTime"].Value.ToString();
                int amount = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["PrescribedAmount"].Value.ToString());
                int days = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["PrescribedDays"].Value.ToString());

                Prescription p = new Prescription
                {
                    CaseId = c.Id,
                    MedicineId = medicineId,
                    Time = time,
                    Amount = amount,
                    Days = days,
                    Date = DateTime.Now
                };

                try
                {
                    if (e.ColumnIndex == 0) //Save
                    {
                        mp.UpdatePrescription(p);
                    }
                    else //Delete
                    {
                        mp.DeletePrescription(p);
                    }
                }
                catch (Exception ex)
                {
                    status.Text = "Unable to update prescriptions. Check your data.";
                    status.ForeColor = Color.Red;
                    Console.WriteLine(ex);
                }
                prescriptionGridView.DataSource = this.PopulatePrescriptionGridView();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Hide();
        }
    }
}
