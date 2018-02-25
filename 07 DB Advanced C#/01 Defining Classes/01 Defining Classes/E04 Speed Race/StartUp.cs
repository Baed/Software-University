using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace E04_Speed_Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = Reader();

            ExecuteProgram(cars);

            Printer(cars);
        }

        private static void Printer(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        private static void ExecuteProgram(List<Car> cars)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string racingType = cmdArgs.First();
                var tokensArgs = cmdArgs.Skip(1).ToArray();

                switch (racingType)
                {
                    case "Drive": Drive(tokensArgs, cars); break;
                }
            }
        }

        private static void Drive(string[] tokensArgs, List<Car> cars)
        {
            string model = tokensArgs[0];
            double distance = double.Parse(tokensArgs[1]);

            Car car = cars.Find(c => c.Model.Equals(model)); //Car car = cars.FirstOrDefault(c => c.Model.Equals(model));

            bool isMoved = car.Move(distance);
            if (!isMoved)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        private static List<Car> Reader()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                var cmdArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = cmdArgs[0];
                var fuel = double.Parse(cmdArgs[1]);
                var consumption = double.Parse(cmdArgs[2]);

                if (!cars.Any(c => c.Model.Equals(model)))
                {
                    cars.Add(new Car(model, fuel, consumption));
                }
            }

            return cars;
        }
    }
}
