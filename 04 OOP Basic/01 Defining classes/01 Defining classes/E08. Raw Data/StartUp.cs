using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = GetCars();

            PrintResult(cars);
        }

        private static void PrintResult(List<Car> cars)
        {
            var cargoTypeFilter = Console.ReadLine();

            switch (cargoTypeFilter)
            {
                case "fragile":
                    cars
                        .Where(c => c.IsFragile())
                        .ToList()
                        .ForEach(c => Console.WriteLine(c.Model));
                    break;
                case "flamable":
                     cars
                        .Where(c => c.IsFlamable())
                        .ToList()
                        .ForEach(c => Console.WriteLine(c.Model));
                    break;
            }
        }

        private static List<Car> GetCars()
        {
            var cars = new List<Car>();

            var numberOfcars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfcars; i++)
            {
                var carInfo = Console.ReadLine().Split(' ');

                var model = carInfo[0];

                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var engine = new Engine(engineSpeed, enginePower);

                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                var cargo = new Cargo(cargoWeight, cargoType);

                var tires = new List<Tire>();

                for (int tireCnt = 0; tireCnt < 4; tireCnt++)
                {
                    var tirePressure = double.Parse(carInfo[5 + tireCnt]);
                    var tireAge = int.Parse(carInfo[6] + tireCnt * 2);
                    var tire = new Tire(tirePressure, tireAge * 2);

                    tires.Add(tire);
                }
                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            return cars;
        }
    }

