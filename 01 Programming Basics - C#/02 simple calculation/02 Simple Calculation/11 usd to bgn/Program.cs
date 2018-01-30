using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inches_to_santimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Convertor USD to BGN");
            //Console.Write("Enter 'USD' = ");
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            Console.WriteLine($"{BGN:f2} BGN");
        }
    }
}
