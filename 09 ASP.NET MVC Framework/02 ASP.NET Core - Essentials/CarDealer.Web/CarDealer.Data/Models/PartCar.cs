using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Data.Models
{
    public class PartCar
    {
        public int CarId { get; set; }

        public Car Car { get; set; }

        public int  PartId { get; set; }

        public Part Part { get; set; }
    }
}
