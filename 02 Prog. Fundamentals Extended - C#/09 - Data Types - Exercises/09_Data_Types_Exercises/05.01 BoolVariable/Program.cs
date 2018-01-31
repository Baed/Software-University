using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_BoolVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (bool.Parse(input))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
