using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01HospitalDB.Data.Models
{
    public class Patient
    {
        public Patient()
        {
            
        }

        public int PatientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public bool HasInsurance { get; set; }

        public ICollection<Visitation> Visitations { get; set; } = new List<Visitation>();

        public ICollection<Diagnose> Diagnoses { get; set; } = new List<Diagnose>();

        public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();
    }
}
