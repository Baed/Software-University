using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Extract_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?:^|\s)([a-zA-Z\d]+([._-][a-zA-Z\d]+)*?)@([a-zA-Z]+(-[a-zA-Z]+)*(\.[a-zA-Z]+(-[a-zA-Z]+)*)*(\.[a-zA-Z]+))\b";
            // (?:^|\s)(\w+([._-]\w+)*?)@(\w+(-\w+)*(\.\w+(-\w+)*)*(\.\w+))\b
            string input = Console.ReadLine();

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}
