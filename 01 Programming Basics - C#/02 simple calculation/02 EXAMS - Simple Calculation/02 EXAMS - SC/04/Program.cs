using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = 1168 ;
            decimal UIAN = 0.15m ;
            decimal USD = 1.76m ;
            decimal EUR = 1.95m ;
            // var comission = 0.05 ;

            var Bitvalue = decimal.Parse(Console.ReadLine());
            var UIANvalue = decimal.Parse(Console.ReadLine());
            var comissionvalue = decimal.Parse(Console.ReadLine());

            if (!(0 <= comissionvalue) || !(comissionvalue <= 5))
            {
                return;
            }

            var resultBitToBGN = Bitvalue * bitcoin;
            var resultUIANToUSD = UIANvalue * UIAN;
            var resultUSDToBGN = resultUIANToUSD * USD;
            var resultBGN = resultBitToBGN + resultUSDToBGN;
            var resultBGNToEUR = resultBGN / EUR;
            var resultComission = resultBGNToEUR * comissionvalue / 100;
            var result = resultBGNToEUR - resultComission;
           //Console.WriteLine($"{resultBitToBGN}");
           // Console.WriteLine($"{resultUIANToUSD}");
           // Console.WriteLine($"{resultUSDToBGN}");
           // Console.WriteLine($"{resultBGN}");
           // Console.WriteLine($"{resultComission}");
            Console.WriteLine($"{result:f2}");



        }
    }
}
