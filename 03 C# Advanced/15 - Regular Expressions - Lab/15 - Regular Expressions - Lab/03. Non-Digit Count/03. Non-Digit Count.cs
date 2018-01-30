using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Non_Digit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^0-9]";
            string input = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            int counter = matches.Count;

            Console.WriteLine($"Non-digits: {counter}");
        }
    }
}
