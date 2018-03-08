using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01.Cars.Data.Models
{
    public class Engine
    {
        public Engine()
        {
            
        }

        public Engine(double capacity, FuelType fuelType, int cyllinders, int horsePower)
        {
            Capacity = capacity;
            FuelType = fuelType;
            Cyllinders = cyllinders;
            HorsePower = horsePower;
        }

        public int Id { get; set; }

        public double Capacity { get; set; }

        public FuelType FuelType { get; set; }

        public int Cyllinders { get; set; }

        public int HorsePower { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
