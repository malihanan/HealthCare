using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare
{
    public static class Global
    {
        public static int? Id { get; set; }
        public static UserType? Type { get; set; }
        public static string Username { get; set; }

        public static void clear()
        {
            Global.Id = null;
            Global.Type = null;
            Global.Username = null;
        }
    }
}
