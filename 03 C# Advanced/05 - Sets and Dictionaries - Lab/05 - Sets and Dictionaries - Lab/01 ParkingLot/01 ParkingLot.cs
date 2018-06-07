using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new HashSet<string>(); // sortedset

            while (input != "END")
            {
                string[] tokens = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //var tokens = Regex.Split(input, ", ");
                var command = tokens[0];
                var serialNumber = tokens[1];

                if (command == "IN")
                {
                    parking.Add(serialNumber);
                }
                else if (command == "OUT")
                {
                    parking.Remove(serialNumber);
                }
                input = Console.ReadLine();
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking.OrderBy(n => n))
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
