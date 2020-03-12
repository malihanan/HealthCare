using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Model
{
    class ManageCase
    {
        public bool AddCase(Case c)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Select * from [User] where [User].Id = @Id;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Id", c.PatientId);
                using (con)
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string cmdText2 = "Insert into [Case] (DoctorId, PatientId, OpenDate, ModifyDate, Title, Description, Disease) values (@DoctorId, @PatientId, @OpenDate, @ModifyDate, @Title, @Description, @Disease);";
                        SqlCommand cmd2 = new SqlCommand(cmdText2, con);
                        cmd2.Parameters.AddWithValue("@DoctorId", c.DoctorId);
                        cmd2.Parameters.AddWithValue("@PatientId", c.PatientId);
                        cmd2.Parameters.AddWithValue("@OpenDate", c.OpenDate);
                        cmd2.Parameters.AddWithValue("@ModifyDate", c.ModifyDate);
                        cmd2.Parameters.AddWithValue("@Title", c.Title);
                        cmd2.Parameters.AddWithValue("@Description", c.Description);
                        cmd2.Parameters.AddWithValue("@Disease", c.Disease);
                        rdr.Close();
                        cmd2.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
