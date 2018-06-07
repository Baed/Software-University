using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07.Speed_Racing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carsData = GetCars();

            carsData = DriveCars(carsData);

            foreach (var car in carsData)
            {
                Console.WriteLine(car.Value.ToString());
            }
        }

        private static Dictionary<string, Car> DriveCars(Dictionary<string, Car> carsData)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var carModel = args[1];
                var distance = int.Parse(args[2]);

                if (carsData.ContainsKey(carModel))
                {
                    carsData[carModel].Drive(distance);
                }
            }

            return carsData;
        }

        private static Dictionary<string, Car> GetCars()
        {
            var carsData = new Dictionary<string, Car>();

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));

                if (!carsData.ContainsKey(car.Model))
                {
                    carsData.Add(car.Model, car);
                }
            }
            return carsData;
        }
    }
}
