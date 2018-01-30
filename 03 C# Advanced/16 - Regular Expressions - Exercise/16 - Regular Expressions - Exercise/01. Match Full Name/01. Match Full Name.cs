using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";

            var regex = new Regex(pattern);

            while (input != "end")
            {
                var matches = regex.Matches(input);

                input = Console.ReadLine();

                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
