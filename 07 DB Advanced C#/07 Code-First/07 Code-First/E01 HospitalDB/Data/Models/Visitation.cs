using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01HospitalDB.Data.Models
{
    public class Visitation
    {
        public Visitation()
        {
            
        }

        public int VisitationId { get; set; }

        public DateTime Date { get; set; }

        public string Comments { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
