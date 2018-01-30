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
            Console.WriteLine("Inches to santimeter");
            Console.Write("Enter 'inches' = ");
            var inches = double.Parse(Console.ReadLine());
            var centimeter = inches * 2.54;
            Console.WriteLine("The result is = {0} centimeters", centimeter);
        }
    }
}
