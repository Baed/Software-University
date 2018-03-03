using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01_Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locoPower = int.Parse(Console.ReadLine());

            List<int> wagonTrain = new List<int>();

            while (true)
            {
                string theFollowUp = Console.ReadLine();

                if (theFollowUp == "All ofboard!")
                {
                    break;
                }

                wagonTrain.Add(int.Parse(theFollowUp));

                if (wagonTrain.Sum() > locoPower)
                {
                    var nearest = wagonTrain.OrderBy(x => Math.Abs(x - wagonTrain.Average())).First();

                    wagonTrain.Remove(nearest);
                }
            }

            wagonTrain.Reverse();

            Console.WriteLine(string.Join(" ", wagonTrain) + " " + locoPower);
        }
    }
}
