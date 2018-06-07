using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01.Cars.Data.Models
{
    public class CarDealership
    {
        public CarDealership()
        {

        }

        public CarDealership(Car car, Dealership dealership)
        {
            Car = car;
            Dealership = dealership;
        }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int DealershipId { get; set; }
        public Dealership Dealership { get; set; }
    }
}
