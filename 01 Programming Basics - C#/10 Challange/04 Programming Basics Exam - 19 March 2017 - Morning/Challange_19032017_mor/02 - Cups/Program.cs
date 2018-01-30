using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int glass = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            var kpd = workers * workDays * 8;
            var madeglasses = (kpd / 5);

            if (glass > madeglasses)
            {
                Console.WriteLine($"Losses: {(glass - madeglasses)*4.2:f2}");
            }
            else
            {
                Console.WriteLine($"{(madeglasses - glass)*4.2:f2} extra money");
            }
        }
    }
}
