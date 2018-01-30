using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Series_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"(\w)\1+";

            var result = Regex.Replace(input, pattern, "$1");
            // var result = Regex.Replace(text, @"([A-Za-z])\1+", m => m.Groups[1].Value); // Both variations work Identically
            Console.WriteLine(result);
           
        }
    }
}
