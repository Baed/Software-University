using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();

            Regex pattern = new Regex(@"\b(?<day>\d{2})(?<separators>[-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b");

            MatchCollection matchCollection = pattern.Matches(dates);

            foreach (Match date in matchCollection)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
