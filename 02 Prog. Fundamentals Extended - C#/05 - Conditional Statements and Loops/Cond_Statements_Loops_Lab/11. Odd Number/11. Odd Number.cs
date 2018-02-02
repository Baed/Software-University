using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {           
            while (true)
            {
                int n = Math.Abs(int.Parse(Console.ReadLine()));
                if (n % 2 == 1)
                {
                    Console.WriteLine($"The number is: {n}"); // mojem da go premestim dolu
                    break;
                }
                Console.WriteLine($"Please write an odd number.");
            }
           // Console.WriteLine($"The number is: {n}"); ako go izvadim ot if - construkciqta
        }
    }
}
