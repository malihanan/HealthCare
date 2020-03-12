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
        public ViewCases()
        {
            InitializeComponent();
            refreshData();
        }

        private void refreshData()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Select [Case].Id, [Case].ModifyDate, [Case].Title, [User].Id, [User].Username from [Case], [User] where [Case].PatientId = [User].Id and [Case].DoctorId = @Id;";
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
    }
}
