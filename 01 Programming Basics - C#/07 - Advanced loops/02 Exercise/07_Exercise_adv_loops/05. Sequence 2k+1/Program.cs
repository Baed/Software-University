using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var current_number = 1;
            while (current_number <= n)
            {
                Console.WriteLine(current_number);
                current_number = current_number * 2 + 1;
            }
        }
    }
}
