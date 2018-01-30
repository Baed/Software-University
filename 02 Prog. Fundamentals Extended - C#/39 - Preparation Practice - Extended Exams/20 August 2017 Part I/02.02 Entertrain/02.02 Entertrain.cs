using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02_Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locoPower = int.Parse(Console.ReadLine());

            List<int> wagonData = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "All ofboard!")
                {
                    break;
                }

                wagonData.Add(int.Parse(input));

                if (wagonData.Sum() > locoPower)
                {
                    var nearest = wagonData.OrderBy(x => Math.Abs(x - wagonData.Average())).First();
                    wagonData.Remove(nearest);
                }
            }
            wagonData.Reverse();

            Console.WriteLine(string.Join(" ", wagonData) + " " + locoPower);
        }
    }
}
