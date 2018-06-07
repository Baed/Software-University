using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            double magnolia = double.Parse(Console.ReadLine());
            double zumbiuli = double.Parse(Console.ReadLine());
            double rozi = double.Parse(Console.ReadLine());
            double kaktusi = double.Parse(Console.ReadLine());
            double gift_price = double.Parse(Console.ReadLine());

            var magnovia_price = 3.25;
            var zumbiuli_price = 4.00;
            var rozi_price = 3.50;
            var kaktusi_price = 8.00;

            var sum = magnolia * magnovia_price + zumbiuli * zumbiuli_price + rozi * rozi_price + kaktusi * kaktusi_price;
            var sum_with_vat = sum - sum * 0.05;
            //var profit = sum_with_vat - gift_price;
            
            if (sum_with_vat < gift_price)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(gift_price - sum_with_vat)} leva.");                
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(sum_with_vat - gift_price)} leva.");
            }
        }
    }
}
