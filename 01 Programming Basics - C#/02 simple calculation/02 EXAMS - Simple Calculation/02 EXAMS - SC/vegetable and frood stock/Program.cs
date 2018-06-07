using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetable_and_frood_stock
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegBGN = decimal.Parse(Console.ReadLine());
            var frBGN = decimal.Parse(Console.ReadLine());
            var vegKG = int.Parse(Console.ReadLine());
            var frKG = int.Parse(Console.ReadLine());
            var EUR = 1.94m;
            var vegEUR = vegBGN * vegKG / EUR;
            var frEUR = frBGN * frKG / EUR;
            var result = $"{(vegEUR + frEUR):f2}";
            Console.WriteLine(result);

        }    
    }
}
