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
            string input = Console.ReadLine();
            var pattern = @"\+359( |-)[2]\1\d{3}\1\d{4}\b";

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
