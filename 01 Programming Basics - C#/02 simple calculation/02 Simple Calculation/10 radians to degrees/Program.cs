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
            Console.WriteLine("Converter Radians to Degrees");
            Console.Write("Enter 'rad' = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180/Math.PI;
            Console.WriteLine($"The result of 'degrees' is : {deg:f0}");
        }
    }
}
