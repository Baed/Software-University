using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_daily_profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var N= int.Parse(Console.ReadLine()); // N - dni
            if (!(0 <= N) || !(N <= 30))
            {
                return;
            }

            var M = decimal.Parse(Console.ReadLine()); // m - $ per day
            if (!(10.00m <= M) || !(M <= 2000.00m))
            {
                return;
            }

            var courseBGNtoUSD = decimal.Parse(Console.ReadLine()); // m - $ per day
            if (!(0.99m <= courseBGNtoUSD) || !(courseBGNtoUSD <= 1.99m))
            {
                return;
            }       
            var salarypermonth = N * M ; // mesechna zaplata
            var bonus = salarypermonth * 2.5m; // godishen bonus
            var salaryperyear = salarypermonth * 12 + bonus; // godishen dohod
            var tax = salaryperyear * 0.25m;
            var salaryperyearBGN = (salaryperyear - tax) * courseBGNtoUSD;
            var salaryperdayBGN = salaryperyearBGN / 365;
            Console.WriteLine($"{salaryperdayBGN:f2}");
        }
    }
}
