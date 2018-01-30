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

            string names = Console.ReadLine();

            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection matches = pattern.Matches(names);

            foreach (Match item in matches)
            {
                Console.Write(item.Groups[0] + " "); //Console.Write(item.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
