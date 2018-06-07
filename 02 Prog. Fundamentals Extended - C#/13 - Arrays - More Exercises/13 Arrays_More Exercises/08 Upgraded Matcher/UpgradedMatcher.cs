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
            Array.Resize(ref quantityArr, productsArr.Length);

            decimal[] pricesArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            string command;
            while ((command = Console.ReadLine()) != "done")
            {
                string[] tokens = command.Split(' ');

                int ìndex = Array.IndexOf(productsArr, tokens[0]); ;

                long neededQuantity = long.Parse(tokens[1]);

                if (neededQuantity <= quantityArr[ìndex])
                {
                    Console.WriteLine($"{productsArr[ìndex]} x {neededQuantity} costs {(long.Parse(tokens[1]) * pricesArr[ìndex]):f2}");
                    quantityArr[ìndex] -= neededQuantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {productsArr[ìndex]}");
                }
            }
        }
    }
}
