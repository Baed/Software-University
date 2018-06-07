using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Formatting_Numbers
{
    class Program
    {
        private const int width = 10;
        private static readonly char[] separator = new[] { ' ', '\n', '\t', '\r' };

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            string firstColHex = $"|{a, -width:X}"; // $"|{a.ToString("X"), -width}";
            string secondColBin = $"|{Convert.ToString(a, 2).PadLeft(width, '0').Substring(0, width)}|";
            string thirdCol = $"{b,width:f2}|";
            string fourthCol = $"{c,-width:f3}|";
            Console.WriteLine($"{firstColHex}{secondColBin}{thirdCol}{fourthCol}");
        }
    }
}
