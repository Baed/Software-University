using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number, toBase));
        }
        static string IntegerToBase(long number, int toBase)
        {
            string result = "";
            while (number > 0)
            {
                long remainder = (int)number % toBase;
                result = remainder + result;
                number /= toBase;
            }
            return result;
        }
    }
}
