using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex didimon = new Regex(@"([^A-Za-z\-]+)");
            Regex bojomon = new Regex(@"([A-Za-z]+-[A-Za-z]+)");

            string inputLine = Console.ReadLine();

            bool lamp = false;
            int counter = 0;

            while (lamp != true)
            {
                if (counter % 2 == 0)
                {
                    Match match = didimon.Match(inputLine);

                    if (match.Success)
                    {
                        string result = match.Value;

                        Console.WriteLine(match.Value);

                        int remove = inputLine.IndexOf(result);
                        inputLine = inputLine.Remove(0, result.Length + remove);
                    }
                    else
                    {
                        lamp = true;
                    }
                }
                else if (counter % 2 != 0)
                {
                    Match match = bojomon.Match(inputLine);
                    if (match.Success)
                    {
                        string result = match.Value;

                        Console.WriteLine(match.Value);

                        int remove = inputLine.IndexOf(result);
                        inputLine = inputLine.Remove(0, result.Length + remove);
                    }
                    else
                    {
                        lamp = true;
                    }
                }

                counter++;
            }
        }
    }
}
