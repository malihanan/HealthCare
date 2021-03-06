﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HealthCare.Model
{
    public class ManageUser
    {
        public bool AddUser(User user)
        {
            try
            {
                //string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Insert into [User] (Username, Password, Type) values(@Username, @Password, @Type);";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Type", user.Type.ToString());
                using (con)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public User LoginUser(User user)
        {
            UserType type;
            User u = null;
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Select * from [User] where Username=@Username and Password=@Password;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                using (con)
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Enum.TryParse<UserType>(rdr["Type"].ToString(), out type);
                        u = new User()
                        {
                            Id = Int32.Parse(rdr["Id"].ToString()),
                            Username = rdr["Username"].ToString(),
                            Password = rdr["Password"].ToString(),
                            Type = type
                        };
                    }
                }
                return u;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public User getUser(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HealthCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Select * from [User] where [User].Id = @Id;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Id", id);
                using (con)
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        User user = new User
                        {
                            Id = Int32.Parse(rdr["Id"].ToString()),
                            Username = rdr["Username"].ToString(),
                            Type = GetUserType(rdr["Type"].ToString())
                        };
                        return user;
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

        UserType? GetUserType(string type)
        {
            if (type.Equals("PATIENT"))
            {
                return UserType.PATIENT;
            }
            else if (type.Equals("DOCTOR"))
            {
                return UserType.DOCTOR;
            }
            else if (type.Equals("PHARMACIST"))
            {
                return UserType.PHARMACIST;
            }
            else if (type.Equals("LAB_TECHNICIAN"))
            {
                return UserType.LAB_TECHNICIAN;
            }
            else
            {
                return null;
            }
        }
    }
}
