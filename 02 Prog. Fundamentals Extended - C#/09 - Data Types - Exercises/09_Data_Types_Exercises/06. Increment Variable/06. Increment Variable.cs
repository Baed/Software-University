using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            int overflow = (int)num / (byte.MaxValue + 1); // 255 + 1 = 256
            int result = (int)num % (byte.MaxValue + 1);   // 255 + 1 = 256         
            Console.WriteLine(result);
            if (overflow > 0)
            {
                Console.WriteLine($"Overflowed {overflow} times");
            }

        }
    }
}
