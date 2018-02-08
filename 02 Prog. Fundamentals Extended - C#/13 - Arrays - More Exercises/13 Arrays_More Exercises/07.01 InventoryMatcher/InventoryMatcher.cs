using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._01_InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] productsArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            long[] quantityArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            decimal[] pricesArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            string command;
            while ((command = Console.ReadLine()) != "done")
            {
                int ìndex = Array.IndexOf(productsArr, command);

                Console.WriteLine($"{productsArr[ìndex]} costs: {pricesArr[ìndex]}; Available quantity: {quantityArr[ìndex]}");
            }
        }
    }
}