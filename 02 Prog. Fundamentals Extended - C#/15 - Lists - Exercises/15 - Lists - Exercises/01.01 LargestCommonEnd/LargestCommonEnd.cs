using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01_LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] arrFirstLine = Console.ReadLine().Split(' ');

            string[] arrSecondLine = Console.ReadLine().Split(' ');

            int cntAscOrder = 0;

            int cntDescOrder = 0;

            for (int i = 0; i < arrFirstLine.Length && i < arrSecondLine.Length; i++)
            {
                if (arrFirstLine[i] == arrSecondLine[i])
                {
                    cntAscOrder++;
                }
            }

            for (int i = 0; i < arrFirstLine.Length && i < arrSecondLine.Length; i++)
            {
                if (arrFirstLine[arrFirstLine.Length - 1 - i] == arrSecondLine[arrSecondLine.Length - 1 - i])
                {
                    cntDescOrder++;
                }
            }

            Console.WriteLine(cntAscOrder > cntDescOrder ? cntAscOrder : cntDescOrder);
        }
    }
}
