using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01HospitalDB.Data.Models
{
    public class PatientMedicament
    {
        public PatientMedicament()
        {
            
        }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int MedicamentId { get; set; }
        public Medicament Medicament { get; set; }
    }
}
