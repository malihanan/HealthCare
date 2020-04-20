using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Model
{
    class Prescription
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int MedicineId { get; set; }
        public string Time { get; set; }
        public int Amount { get; set; }
        public int Days { get; set; }
        public DateTime Date { get; set; }
        public bool Bought { get; set; }
    }
}
