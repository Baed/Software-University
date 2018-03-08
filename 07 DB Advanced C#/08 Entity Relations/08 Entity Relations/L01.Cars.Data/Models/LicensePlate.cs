using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01.Cars.Data.Models
{
    public class LicensePlate
    {
        public LicensePlate()
        {
            
        }

        public LicensePlate(string number)
        {
            Number = number;
        }

        public int Id { get; set; }

        public string Number { get; set; }

        public int? CarId { get; set; }

        public Car Car { get; set; }
    }
}
