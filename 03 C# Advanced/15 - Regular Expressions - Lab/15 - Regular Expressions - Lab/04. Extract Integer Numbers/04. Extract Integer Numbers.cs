using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Extract_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = "\\d+";
            string input = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

        }
    }
}
