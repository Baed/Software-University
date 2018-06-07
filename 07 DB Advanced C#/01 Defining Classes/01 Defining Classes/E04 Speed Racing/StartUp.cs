using System.Xml.Linq;

namespace E04_Speed_Racing
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


        }

        private static void ExecuteProgram(List<Car> cars)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string carType = cmdArgs.Take(0).ToString();
                var tokens = cmdArgs.Skip(0).ToArray();
                Console.WriteLine(carType);
                Console.WriteLine(string.Join(", ", tokens));

              // switch (carType)
              // {
              //         
              // }


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
