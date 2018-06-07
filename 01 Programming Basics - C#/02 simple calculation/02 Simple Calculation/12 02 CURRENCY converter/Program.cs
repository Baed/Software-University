using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02_CURRENCY_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vuvevdane na cifrova stoinost 
            decimal moneytoConvert = decimal.Parse(Console.ReadLine()); // za6toto rabotim s pari
            // vuvejdane na string - vid valuta 1 i 2
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();
            
            var currencies = new Dictionary<string, decimal>()
                                  {
                { "BGN", 1 },
                { "USD", 1.79549m },
                { "EUR", 1.95583m },
                { "GBR", 2.53405m }
                                  };

            decimal result = moneytoConvert * (currencies[firstCurrency] / currencies[secondCurrency]);

                    // Console.WriteLine(currencies[]);


                    // Console.WriteLine(Math.Round(result, 2));

             Console.WriteLine($"{currencies} {result:F2}", secondCurrency);

        }
    }
}
