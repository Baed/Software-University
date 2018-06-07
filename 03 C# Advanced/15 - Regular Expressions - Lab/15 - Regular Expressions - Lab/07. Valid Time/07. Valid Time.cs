using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Valid_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"\b(0?[0-9]|1[0-2])(:[0-5][0-9]){2}\s?(A|P)M\b";
            var regex = new Regex(pattern);

            while (input != "END")
            {

                if (regex.IsMatch(input))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                

                input = Console.ReadLine();
            }

        }

    }
}
