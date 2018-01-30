using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int number = Convert.ToInt32(value, 16);
            Console.WriteLine(number);
        }
    }
}
