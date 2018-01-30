using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            bool result = (n >= 3.00);

            if (result == true)
            {
                Console.WriteLine("Passed!");
            }

            if (n >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
