using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_non_training_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 5) //4
            {
                //Console.WriteLine(">4");
                Console.WriteLine("one");
            }

            else if (num >= 6)
            {   // ako e samo if e druga proverka, NO ako ima "esle if" togava e kum gornata no s drugo uslovie
                //Console.WriteLine(">6"); 
                Console.WriteLine("two");
            }
        }
    }
}
