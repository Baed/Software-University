using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_non_training_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();

            if (color == "red")
            {
                Console.WriteLine("In if");
                Console.WriteLine("red");
            }
            else
            {
                Console.WriteLine("in else");
                Console.WriteLine("NOT red");
            }

        }
    }
}
