using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }
        static int FindNthDigit(long number, int index)
        {
            int currentDiggit = 0;
            for (int i = 1; i < index; i++)
            {
                number /= 10;              
            }
            return currentDiggit = (int)number % 10;
        }
    }
}
