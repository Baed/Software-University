using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] initialRaindropStates = inputNumbers.Take(inputNumbers.Length - 1).ToArray();

            int[] currentRaindropStates = initialRaindropStates.ToArray();

            int currentIndex = inputNumbers.Last();

            bool hasGottenWet = false;

            int steps = 0;

            while (!hasGottenWet)
            {
                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    currentRaindropStates[i]--;
                }

                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    if (currentRaindropStates[i] == 0 && i == currentIndex)
                    {
                        hasGottenWet = true;
                        break;
                    }
                }

                if (hasGottenWet)
                {
                    break;
                }

                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    if (currentRaindropStates[i] == 0)
                    {
                        currentRaindropStates[i] = initialRaindropStates[i];
                    }
                }

                currentIndex = int.Parse(Console.ReadLine());
                steps++;
            }

            Console.WriteLine(string.Join(" ", currentRaindropStates));
            Console.WriteLine(steps);
        }
    }
}
