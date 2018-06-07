using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Trubi_v_basein
{
    class Program
    {
        static void Main(string[] args)
        {

            var V = int.Parse(Console.ReadLine()); //obem
            var P1 = int.Parse(Console.ReadLine()); //debit 
            var P2 = int.Parse(Console.ReadLine()); //debit
            var H = double.Parse(Console.ReadLine()); //rabotnik otsustva

            var fill = (P1 + P2) * H;

            if (fill <= V)
            {
                var rateFull = Math.Truncate (fill * 100 / V);
                var rate1 = Math.Truncate (P1 * H * 100 / fill);
                var rate2 = Math.Truncate (P2 * H * 100 / fill);

                Console.WriteLine($"The pool is {rateFull:f0}% full. Pipe 1: {rate1:f0}%. Pipe 2: {rate2:f0}%.");
            }

            else
            {
                Console.WriteLine($"For {H} hours the pool overflows with {(fill - V):f1} liters.");
            }     

        }
    }
}
