using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();

            Regex pattern = new Regex(@"\b(0x)?[0-9A-F]+\b");

            MatchCollection matchCollection = pattern.Matches(hexadecimal);

            List<Match> matches = matchCollection
                .Cast<Match>()
                .ToList();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
