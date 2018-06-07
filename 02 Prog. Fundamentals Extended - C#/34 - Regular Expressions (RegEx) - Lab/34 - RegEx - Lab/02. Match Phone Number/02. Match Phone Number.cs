using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            Regex pattern = new Regex(@"\+359([ -])2\1\d{3}\1\d{4}\b");

            MatchCollection matchCollection = pattern.Matches(phones);

            List<Match> matches = matchCollection
                .Cast<Match>()
                .ToList();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
