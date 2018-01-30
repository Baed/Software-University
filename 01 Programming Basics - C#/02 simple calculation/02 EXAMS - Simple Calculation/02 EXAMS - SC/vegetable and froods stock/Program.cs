using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetable_and_froods_stock
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vegetableBGN = decimal.Parse(Console.ReadLine());
            decimal froodBGN = decimal.Parse(Console.ReadLine());
            decimal kur = decimal.Parse(Console.ReadLine());
            decimal putka = decimal.Parse(Console.ReadLine());

            //decimal EUR = 1.94m;

            //decimal vegeteblePriceEUR = vegetableBGN * vegetableKG * EUR;
            //decimal froodPriceEUR = froodBGN * froodKG  * EUR;
            //Console.WriteLine($"{(vegeteblePriceEUR+ froodPriceEUR):f2}");
        }
    }
}
