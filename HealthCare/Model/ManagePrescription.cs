using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Model
{
    class ManagePrescription
    {
        public bool AddPrescription(Prescription p)
        {
            if(this.GetPrescription(p))
            {
                return UpdatePrescription(p);
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Insert into [Prescription] (CaseId, MedicineId, Time, Amount, Days, Date) values (@CaseId, @MedicineId, @Time, @Amount, @Days, @Date);";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@CaseId", p.CaseId);
                cmd.Parameters.AddWithValue("@MedicineId", p.MedicineId);
                cmd.Parameters.AddWithValue("@Time", p.Time);
                cmd.Parameters.AddWithValue("@Amount", p.Amount);
                cmd.Parameters.AddWithValue("@Days", p.Days);
                cmd.Parameters.AddWithValue("@Date", p.Date);
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

        public bool UpdatePrescription(Prescription p)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Update [Prescription] set Time = @Time, Amount = @Amount, Days = @Days, Date = @Date where CaseId = @CaseId and MedicineId = @MedicineId;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@CaseId", p.CaseId);
                cmd.Parameters.AddWithValue("@MedicineId", p.MedicineId);
                cmd.Parameters.AddWithValue("@Time", p.Time);
                cmd.Parameters.AddWithValue("@Amount", p.Amount);
                cmd.Parameters.AddWithValue("@Days", p.Days);
                cmd.Parameters.AddWithValue("@Date", p.Date);
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

        public bool DeletePrescription(Prescription p)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Delete from [Prescription] where CaseId = @CaseId and MedicineId = @MedicineId;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@CaseId", p.CaseId);
                cmd.Parameters.AddWithValue("@MedicineId", p.MedicineId);
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

        private bool GetPrescription(Prescription p)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Select * from [Prescription] where CaseId = @CaseId and MedicineId = @MedicineId;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@CaseId", p.CaseId);
                cmd.Parameters.AddWithValue("@MedicineId", p.MedicineId);
                using (con)
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    return (rdr.Read()) ? true : false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool giveMedicine(int medicineId, int patientId)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Update [Prescription] set Bought = 1 from [Prescription], [Case] where [Prescription].CaseId = [Case].Id and [Case].PatientId = @PatientId and [Prescription].MedicineId = @MedicineId;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@MedicineId", medicineId);
                using (con)
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return (rows >= 0) ? true : false;
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
