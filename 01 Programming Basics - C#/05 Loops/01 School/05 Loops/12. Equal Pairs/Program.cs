using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int lastPair = 0;
            int maxDiff = 0;


            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int currentPair = num1 + num2;

                if (i > 0)
                {
                    if (lastPair != currentPair)
                    {
                        int diff = Math.Abs(currentPair - lastPair);

                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                    }
                }

                lastPair = currentPair;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={lastPair}");
            }

            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
