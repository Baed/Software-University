using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[aeiouy]";
            string input = Console.ReadLine().ToLower();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int counter = matches.Count;

            Console.WriteLine($"Vowels: {counter}");


        }
    }
}
