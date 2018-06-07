using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01.Cars.Data.Models
{
    public class Car
    {
        public Car()
        {

        }

        public Car(Make make, string model, Engine engine, int doors, Transmission transmission, DateTime productionYear)
        {
            Make = make;
            Model = model;
            Engine = engine;
            Doors = doors;
            Transmission = transmission;
            ProductionYear = productionYear;
        }

        public int Id { get; set; }

        public int MakeId { get; set; }

        public Make Make { get; set; }

        public string Model { get; set; }

        public int EngineId { get; set; }

        public Engine Engine { get; set; }

        public int Doors { get; set; }

        public Transmission Transmission { get; set; }

        public DateTime ProductionYear { get; set; }

        public int? LicensePlateId { get; set; }

        public LicensePlate LicensePlate { get; set; }

        public ICollection<CarDealership> CarsDealerships { get; set; } = new List<CarDealership>();
    }
}
