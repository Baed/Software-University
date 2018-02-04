using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._01_GeometryCalc
{
    class GeometryCalc
    {

        static void Main(string[] args)
        {
            List<string> input = Reader();
            double result = ExecuteProgram(input);
            Writer(result);
        }

        private static void Writer(double result)
        {
            Console.WriteLine($"{result:f2}");
        }

        private static double ExecuteProgram(List<string> input)
        {
            double result = CalculateAreaCase(input);

            return result;
        }

        private static double CalculateAreaCase(List<string> input)
        {
            double areaOfFigure = 0;
            switch (input[0].ToLower())
            {
                case "triangle": areaOfFigure = double.Parse(input[1]) * double.Parse(input[2]) / 2; break;
                case "square": areaOfFigure = Math.Pow(double.Parse(input[1]), 2); break;
                case "rectangle": areaOfFigure = double.Parse(input[1]) * double.Parse(input[2]); break;
                case "circle": areaOfFigure = Math.PI * Math.Pow(double.Parse(input[1]), 2); break;
            }

            return areaOfFigure;
        }

        private static List<string> Reader()
        {
            List<string> input = new List<string>();
            input.Add(Console.ReadLine());

            input = GetAreaType(input);

            return input;
        }

        private static List<string> GetAreaType(List<string> input)
        {
            switch (input[0].ToLower())
            {
                case "triangle":
                    input.Add(Console.ReadLine());
                    input.Add(Console.ReadLine());
                    break;
                case "square":
                    input.Add(Console.ReadLine());
                    break;
                case "rectangle":
                    input.Add(Console.ReadLine());
                    input.Add(Console.ReadLine());
                    break;
                case "circle":
                    input.Add(Console.ReadLine());
                    break;
            }

            return input;
        }
    }
}
