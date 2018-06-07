using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            var kpd = workers * 8 * days;

            if (kpd >= hours)
            {
                Console.WriteLine($"{kpd - hours} hours left");
            }

            else if (hours > kpd)
            {
                Console.WriteLine($"{hours - kpd} overtime \nPenalties: {(hours - kpd) * days}");
            }
        }
    }
}
