using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTest
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bmin = byte.MinValue;
            byte bmax = byte.MaxValue;
            Console.WriteLine(bmin);
            Console.WriteLine(bmax);

            sbyte sbmin = sbyte.MinValue;
            sbyte sbmax = sbyte.MaxValue;
            Console.WriteLine(sbmin);
            Console.WriteLine(sbmax);
            Console.WriteLine();

            short smin = short.MinValue;
            short smax= short.MaxValue;

            ushort usmin = ushort.MinValue;
            ushort usmax = ushort.MaxValue;
            Console.WriteLine(smin);
            Console.WriteLine(smax);
            Console.WriteLine(usmin);
            Console.WriteLine(usmax);
            Console.WriteLine();


            int intmin = int.MinValue;
            int intmax = int.MaxValue;

            uint uintmin = uint.MinValue;
            uint uintmax = uint.MaxValue;
            Console.WriteLine(intmin);
            Console.WriteLine(intmax);
            Console.WriteLine(uintmin);
            Console.WriteLine(uintmax);
            Console.WriteLine();

            

            long longmin = long.MinValue;
            long longmax = long.MaxValue;

            ulong ulongmin = ulong.MinValue;
            ulong ulongmax = ulong.MaxValue;
            Console.WriteLine(longmin);
            Console.WriteLine(longmax);
            Console.WriteLine(ulongmin);
            Console.WriteLine(ulongmax);
            Console.WriteLine();

        }
    }
}
