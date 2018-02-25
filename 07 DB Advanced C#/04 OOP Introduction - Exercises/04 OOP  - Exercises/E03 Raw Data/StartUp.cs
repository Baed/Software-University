using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using E03_Raw_Data.Models;
using E03_Raw_Data.Models.Entity;

namespace E03_Raw_Data
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = Reader();

            cars = ExecuteProgram(cars);

            Writer(cars);
        }

        private static void Writer(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }

        private static List<Car> ExecuteProgram(List<Car> cars)
        {
            string cargoType = Console.ReadLine();

            switch (cargoType)
            {
                case "fragile":
                    return cars.Where(c => c.Cargo.Type.Equals(cargoType) && c.Tires.Any(t => t.Pressure < 1)).ToList();
                case "flammable":
                    return cars.Where(c => c.Cargo.Type.Equals(cargoType) && c.Engine.Power > 250).ToList();
                default: return null;
            }
        }

        private static List<Car> Reader()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = cmdArgs[0];
                int engineSpeed = int.Parse(cmdArgs[1]);
                int enginePower = int.Parse(cmdArgs[2]);
                int cargoWeight = int.Parse(cmdArgs[3]);
                string cargoType = cmdArgs[4];

                Engine engine = new Engine(engineSpeed, enginePower);

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo);

                for (int j = 0; j < 8; j += 2)
                {
                    double tirePresssure = double.Parse(cmdArgs[5 + j]);
                    int tireAge = int.Parse(cmdArgs[6 + j]);
                    Tire tire = new Tire(tirePresssure, tireAge);

                    car.AddTires(tire);
                }

                cars.Add(car);
            }

            return cars;
        }
    }
}
