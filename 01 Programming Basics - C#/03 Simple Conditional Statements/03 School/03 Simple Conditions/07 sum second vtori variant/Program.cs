using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_sum_second_vtori_variant
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var secs = sec1 + sec2 + sec3;
            var mins = 0;

            if (secs > 59)
            {
                mins++;
                secs -= 60;
              //secs = secs - 60;
            }

            if (secs > 59)
            {
                mins++;
                secs = secs - 60;
            }

            if (secs < 10)
            {
                Console.WriteLine(mins + ":" + "0" + secs);
            }
            else
            {
                Console.WriteLine(mins + ":" + secs);
            }
          
        }
    }
}
