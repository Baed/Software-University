using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandForShopping = Console.ReadLine();
            Dictionary<string, int> productInMarket = new Dictionary<string, int>();

            while (commandForShopping != "shopping time")
            {
                string[] productToStock = commandForShopping.Split(' ');
                string product = productToStock[1];
                int quantity = int.Parse(productToStock[2]);

                if (!productInMarket.ContainsKey(product)) 
                {
                    productInMarket[product] = 0; // quantity = 0 --> Dictiinary<product , quantity>
                }

                productInMarket[product] += quantity;

                commandForShopping = Console.ReadLine();
            }

            commandForShopping = Console.ReadLine();

            while (commandForShopping != "exam time")
            {
                string[] productToBuy = commandForShopping.Split(' ');
                string product = productToBuy[1];
                int quantity = int.Parse(productToBuy[2]);

                if (!productInMarket.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (productInMarket[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        productInMarket[product] -= quantity;

                        if (productInMarket[product] < 0)
                        {
                            productInMarket[product] = 0;
                        }
                    }
                }
                commandForShopping = Console.ReadLine();
            }

            foreach (var item in productInMarket)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }

        }
    }
}
