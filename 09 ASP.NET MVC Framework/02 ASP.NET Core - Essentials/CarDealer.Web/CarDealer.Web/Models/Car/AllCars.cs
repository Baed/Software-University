using CarDealer.Services.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Web.Models.Car
{
    public class AllCars
    {
        public IEnumerable<CarModel> Cars { get; set; }
    }
}
