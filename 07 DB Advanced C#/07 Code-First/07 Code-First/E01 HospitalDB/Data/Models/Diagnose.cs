using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01HospitalDB.Data.Models
{
    public class Diagnose
    {
        public Diagnose()
        {
            
        }

        public int DiagnoseId { get; set; }

        public string Name { get; set; }

        public string Comments { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
