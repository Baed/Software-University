using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneytoConvert = decimal.Parse(Console.ReadLine()); // za6toto rabotim s pari

            decimal firstRate = 0m;
            decimal secondRate = 0m;

            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();
            
            if (firstCurrency == "BGN")
            {
                firstRate = 1;
            }
            else if (firstCurrency == "USD")
            {
                firstRate = 1.79549m;
            }
            else if (firstCurrency == "EUR")
            {
                firstRate = 1.95583m;
            }
            else if (firstCurrency == "GBR")
            {
                firstRate = 2.53405m;
            }

            if (secondCurrency == "BGN")
            {
                secondRate = 1;
            }
            else if (secondCurrency == "USD")
            {
                secondRate = 1.79549m;
            }
            else if (secondCurrency == "EUR")
            {
                secondRate = 1.95583m;
            }
            else if (secondCurrency == "GBR")
            {
                secondRate = 2.53405m;
            }

            decimal result = moneytoConvert * (firstRate / secondRate);

            //Console.WriteLine(Math.Round(result, 2));

            Console.WriteLine($"{result:f2} {secondCurrency}");
        }
    }
}
