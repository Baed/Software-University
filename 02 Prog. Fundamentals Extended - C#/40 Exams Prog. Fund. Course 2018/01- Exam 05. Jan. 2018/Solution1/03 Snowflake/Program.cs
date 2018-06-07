using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            string input = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                input = Console.ReadLine();

                sb.Append(input);
            }

            string result = sb.ToString();

            string pattern = @"^([^A-Za-z\d]+)
                                ([\d_]+)((?:[^A-Za-z\d]+)
                                (?:[\d_]+)(?<core>[a-zA-Z]+)(?:[\d_]+)
                                (?:[^A-Za-z\d]+))([\d_]+)
                                ([^A-Za-z\d]+)$";

            if (Regex.IsMatch(result, pattern))
            {
                Match match = Regex.Match(result, pattern);

                int coreLenght = match.Groups["core"].Value.Length;

                Console.WriteLine("Valid");

                Console.WriteLine(coreLenght);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
