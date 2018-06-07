using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var input = char.Parse(Console.ReadLine());

                if (input == 'a' || input == 'i' || input == 'o' || input == 'u' || input == 'e')
                {
                    Console.WriteLine("vowel");
                }

                else if (char.IsDigit(input))
                {
                    Console.WriteLine("digit");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
