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
            Console.WriteLine("Celsius to Fahrenheit");
            Console.Write("Enter 'celsius': ");
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"The result of 'fahrenheit' is : {fahrenheit:f2} F");
            
            // Console.Write("The result of 'fahrenheit' is = ");
            // Console.WriteLine(fahrenheit);
        }
    }
}
