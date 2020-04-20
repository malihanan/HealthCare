using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Model
{
    class Case
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Disease { get; set; }
        public string ClosingSummary { get; set; }
    }
}
