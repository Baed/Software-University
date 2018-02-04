using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._01_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Reader();
            double result = ExecuteProgram(input);
            Writer(result);
        }

        private static void Writer(double result)
        {
            Console.WriteLine($"{result:f2}");
        }

        private static double ExecuteProgram(string[] input)
        {
            double sideValue = double.Parse(input[0]);
            string parameter = input[1];

            double result = CalculateCase(sideValue, parameter);

            return result;
        }

        private static double CalculateCase(double sideValue, string parameter)
        {
            double result = 0;
            switch (parameter.ToLower())
            {
                case "face": result = (Math.Sqrt(2 * Math.Pow(sideValue, 2))); break;
                case "space": result = (Math.Sqrt(3 * Math.Pow(sideValue, 2))); break;
                case "volume": result = Math.Pow(sideValue, 3); break;
                case "area": result = 6 * Math.Pow(sideValue, 2); break;
            }

            return result;
        }

        private static string[] Reader()
        {
            string[] input = new string[2];
            input[0] = Console.ReadLine();
            input[1] = Console.ReadLine();

            return input;
        }
    }
}
