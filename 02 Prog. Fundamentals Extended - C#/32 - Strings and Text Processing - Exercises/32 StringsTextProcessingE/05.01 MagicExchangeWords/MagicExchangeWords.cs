using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_MagicExchangeWords
{
    class MagicExchangeWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<char> first = input[0].ToCharArray().Distinct().ToList();
            List<char> second = input[1].ToCharArray().Distinct().ToList();

            bool exchengable = first.Count == second.Count;

            Console.WriteLine(exchengable.ToString().ToLower());
        }
    }
}
