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

        public Case GetCase(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Select * from [Case] where [Case].Id = @Id;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Id", id);
                using (con)
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Case c = new Case
                        {
                            Id = Int32.Parse(rdr["Id"].ToString()),
                            DoctorId = Int32.Parse(rdr["DoctorId"].ToString()),
                            PatientId = Int32.Parse(rdr["PatientId"].ToString()),
                            Description = rdr["Description"].ToString(),
                            Disease = rdr["Disease"].ToString(),
                            Title = rdr["Title"].ToString(),
                            OpenDate = DateTime.Parse(rdr["OpenDate"].ToString()),
                            ModifyDate = DateTime.Parse(rdr["ModifyDate"].ToString())
                        };
                        if(!rdr["ClosingDate"].ToString().Equals(""))
                        {
                            c.ClosingDate = DateTime.Parse(rdr["ClosingDate"].ToString());
                            c.ClosingSummary = rdr["ClosingSummary"].ToString();
                        }
                        return c;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return null;
        }

        public bool EditCase(Case c)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Update [Case] set Title = @Title, Description = @Description, Disease = @Disease, ModifyDate = @ModifyDate where [Case].Id = @Id;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Id", c.Id);
                cmd.Parameters.AddWithValue("@Title", c.Title);
                cmd.Parameters.AddWithValue("@Description", c.Description);
                cmd.Parameters.AddWithValue("@Disease", c.Disease);
                cmd.Parameters.AddWithValue("@ModifyDate", c.ModifyDate);
                using (con)
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return (rows > 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool CloseCase(int id, string closingSummary)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Update [Case] set ClosingDate = @ClosingDate, ClosingSummary = @ClosingSummary where [Case].Id = @Id;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@ClosingDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@ClosingSummary", closingSummary);
                using (con)
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return (rows > 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
