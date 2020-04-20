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
    public partial class ViewHistory : Form
    {
        Form prevForm;
        int patientId;
        public ViewHistory(int id, Form form)
        {
            InitializeComponent();
            this.prevForm = form;
            this.patientId = id;
            dataGridView1.DataSource = this.PopulateGridView();
        }

        private DataTable PopulateGridView()
        {
            string query = "SELECT Id, Title, Disease, OpenDate FROM [Case] where PatientId = @PatientId;";
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PatientId", patientId);
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
            prevForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                ViewCase viewCase = new ViewCase(id, this);
                this.Hide();
                viewCase.Show();
            }
        }
    }
}
