using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04_frood_and_vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            bool fruit = 
                product == "banana" ||
                product == "apple" ||
                product == "kiwi" ||
                product == "cherry" ||
                product == "lemon" ||
                product == "grapes";

            bool vegetable =
                product == "tomato" ||
                product == "cucumber" ||
                product == "pepper" ||
                product == "carrot";

            if (fruit)
            {
                Console.WriteLine("fruit");
            }

            else if (vegetable)
            {
                Console.WriteLine("vegetable");
            }

            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
