using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            char[] firstChars = input[0].ToCharArray().Distinct().ToArray();
            char[] secondChars = input[1].ToCharArray().Distinct().ToArray();
            Console.WriteLine(firstChars.Length == secondChars.Length ? "true" : "false");
        }
    }
}
