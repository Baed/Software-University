using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02_Debugging_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets user input
            string digit = Math.Abs(int.Parse(Console.ReadLine())).ToString();
            Console.WriteLine(Odd(digit) * Even(digit));
        }
        // Returs a sum of all odd digits
        private static int Odd(string digit)
        {
            int odd = 0;
            for (int i = 0; i < digit.Length; i += 2)
            {
                //Get all odd positions in the string, converts them as int and add them
                odd += int.Parse(digit[i].ToString());
            }
            return odd;
        }

        // Returs a sum of all even digits
        private static int Even(string digit)
        {
            int even = 0;
            for (int i = 1; i < digit.Length; i += 2)
            {
                //Get all odd positions in the string, converts them as int and add them
                even += int.Parse(digit[i].ToString());
            }
            return even;
        }

    }
}
