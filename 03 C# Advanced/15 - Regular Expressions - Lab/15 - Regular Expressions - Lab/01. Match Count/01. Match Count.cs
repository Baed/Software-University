using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string stringInput = Console.ReadLine();

            Regex regex = new Regex(pattern);
            var matches = regex.Matches(stringInput);
           
            //int counter = regex.Matches(stringInput).Count;
            int counter = matches.Count;

            Console.WriteLine(counter);
        }
    }
}
