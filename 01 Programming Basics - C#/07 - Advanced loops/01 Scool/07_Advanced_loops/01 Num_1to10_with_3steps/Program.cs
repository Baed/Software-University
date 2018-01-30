using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Num_1to10_with_3steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());

            for (int i = 1; i <= max; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
