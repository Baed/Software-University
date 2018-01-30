using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < cnt; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            }

            int truckFuel = 0;
            int startIndex = 0;
            var loopBottom = pumps.Count;

            if (startIndex < pumps.Count)
            {
                for (int i = 0; i < loopBottom; i++)
                {
                    int[] currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                    truckFuel += currentPump[0] - currentPump[1];

                    if (truckFuel < 0)
                    {
                        startIndex = i + 1;
                        loopBottom += pumps.Count;
                        truckFuel = 0;
                    }
                }              
            }
            Console.WriteLine(startIndex);
        }
    }
}
