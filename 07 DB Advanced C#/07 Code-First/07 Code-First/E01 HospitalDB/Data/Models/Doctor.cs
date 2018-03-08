using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01HospitalDB.Data.Models
{
    public class Doctor
    {
        public Doctor()
        {
            
        }

        public int DoctorId { get; set; }

        public string Name { get; set; }

        public string Specialty { get; set; }

        public ICollection<Visitation> Visitations { get; set; } = new List<Visitation>();
    }
}
