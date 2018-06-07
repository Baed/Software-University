using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01.Cars.Data.Models
{
    public class Dealership
    {
        public Dealership()
        {
            
        }

        public Dealership(string name)
        {
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CarDealership> CarsDealerships { get; set; } = new List<CarDealership>();
    }
}
