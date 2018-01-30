using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrCommand = Console.ReadLine().Split(' ').ToArray();
            double currentAltitude = double.Parse(arrCommand[0]);
            for (int i = 1; i < arrCommand.Length; i++)
            {
                if (i % 2 != 0 && arrCommand[i] == "up")
                {
                    currentAltitude += double.Parse(arrCommand[i + 1]);
                }
                else if (i % 2 != 0 && arrCommand[i] == "down")
                {
                    currentAltitude -= double.Parse(arrCommand[i + 1]);
                    if (currentAltitude <= 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(currentAltitude <= 0 ? "crashed" : $"got through safely. current altitude: {currentAltitude}m");
        }
    }
}
