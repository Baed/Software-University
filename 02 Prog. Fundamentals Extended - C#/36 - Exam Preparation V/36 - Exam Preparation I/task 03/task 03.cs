using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long hornetsSum = hornets.Sum();

                if (beehives[i] >= hornetsSum)
                {
                    hornets.RemoveAt(0);                    
                }

                beehives[i] -= hornetsSum;          
            }

            if (beehives.Where(h => h > 0).ToList().Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(h => h > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
