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
    public partial class ViewCases : Form
    {
        DoctorHome doctorHome;
        public ViewCases(Form frm)
        {
            InitializeComponent();
            doctorHome = (DoctorHome)frm;
            refreshData();
        }

        public void refreshData()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Select [Case].Id, [Case].ModifyDate, [Case].Title, [User].Id, [User].Username from [Case], [User] where [Case].PatientId = [User].Id and [Case].DoctorId = @Id and [Case].ClosingDate IS NULL;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Id", Global.Id);
                using (con)
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                EditCase editCase = new EditCase(this, Int32.Parse(senderGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                this.Hide();
                editCase.Show();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorHome.Show();
        }
    }
}
