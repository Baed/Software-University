using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Back_To_The_Past___IZPITNA_04
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal year = 18m;
            decimal money = decimal.Parse(Console.ReadLine());
            decimal finalYear = decimal.Parse(Console.ReadLine());

            decimal expensive = 0m;

            for (int i = 0; i <= finalYear; i++)
                // vuv skobite moje da vkarame ,year++
                // za uvelichavane s 2 ==> i+=2
            {
                if (i % 2 == 0)
                {
                    expensive += 12000; // pribavqme kum razhodite tezi

                    //money -= expensive;
                }
                else
                {
                    expensive += 12000 + 50 * year;

                    //money -= expensive;
                }

                year++;
            }

            decimal diff = money - expensive;

            if (diff >=0)
            {
                Console.WriteLine($"{diff:f2}"); // bez tekst
            }

            else
            {
                Console.WriteLine($"{Math.Abs(diff):f2}"); // bez tekst
            }
        }
    }
}
