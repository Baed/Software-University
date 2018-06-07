using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxIndex = numbersArr.Length - 1;

            int sumOfElements = 0;
            int index = 0;

            while (true)
            {
                sumOfElements += numbersArr[index];

                int nextIndex = index + numbersArr[index];

                if (nextIndex <= maxIndex)
                {
                    index = nextIndex;
                    continue;
                }

                else
                {
                    nextIndex = index - numbersArr[index];
                }

                if (nextIndex >= 0)
                {
                    index = nextIndex;
                    continue;
                }

                break;
            }

            Console.WriteLine(sumOfElements);

        }
    }
}
