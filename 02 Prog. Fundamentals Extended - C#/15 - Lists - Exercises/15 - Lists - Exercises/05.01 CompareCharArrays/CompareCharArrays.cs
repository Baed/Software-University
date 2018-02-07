using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arrFirstLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrSecondLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            if(arrFirstLine.Length == arrSecondLine.Length)
            {
                if (arrFirstLine[0] < arrSecondLine[0])
                {
                    Console.WriteLine(arrFirstLine);
                    Console.WriteLine(arrSecondLine);
                }
                else
                {
                    Console.WriteLine(arrSecondLine);
                    Console.WriteLine(arrFirstLine);
                }
            }
            else if (arrFirstLine.Length > arrSecondLine.Length)
            {
                Console.WriteLine(arrSecondLine);
                Console.WriteLine(arrFirstLine);
            }
            else
            {
                Console.WriteLine(arrFirstLine);
                Console.WriteLine(arrSecondLine);
            }
        }
    }
}
