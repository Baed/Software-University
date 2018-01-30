using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = new List<int>();

            int locomotivePower = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "All ofboard!")
            {
                int weigth = int.Parse(input);
                wagons.Add(weigth);

                int sumOfWeight = wagons.Sum();

                if (sumOfWeight > locomotivePower)
                {
                    int currentAverageSum = sumOfWeight / wagons.Count;
                    int nearestWeight = wagons[0];
                    int differenceWeightToRemove = Math.Abs(nearestWeight - currentAverageSum);

                    for (int i = 1; i < wagons.Count; i++) // nearestWeight = wagons[0] --> we don't one iteration more!!!
                    {
                        int difference = Math.Abs(wagons[i] - currentAverageSum);

                        if (difference < differenceWeightToRemove)
                        {
                            differenceWeightToRemove = difference;
                            nearestWeight = wagons[i];
                        }                  
                    }

                    wagons.Remove(nearestWeight);
                }

                input = Console.ReadLine();
            }
            wagons.Reverse();
            wagons.Add(locomotivePower);
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
