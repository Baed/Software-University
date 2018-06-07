using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerPrint(number, power));
        }
        static double PowerPrint(double num, int repetition)
        {
            double result = Math.Pow(num, repetition);
            /*
            result = num;
            for (int i = 1; i < repetition; i++)
            {
                result *= num;
            }
            */
            return result;
        }
    }
}
