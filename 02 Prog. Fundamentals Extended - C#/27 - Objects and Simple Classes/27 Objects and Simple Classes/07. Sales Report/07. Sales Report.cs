using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                Sale saling = GetReadSale(Console.ReadLine());
                sales.Add(saling);
            }

            List<string> towns = sales
                .Select(s => s.Town)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            foreach (string townItem in towns)
            {
                double currentSum = sales
                    .Where(s => s.Town == townItem)
                    .Select(s => s.Price * s.Quantity)
                    .Sum();
                Console.WriteLine($"{townItem} -> {currentSum:f2}");
            }
        }
        private static Sale GetReadSale(string input)
        {
            string[] tokens = input.Split(' ');
            string town = tokens[0];
            string product = tokens[1];
            double price = double.Parse(tokens[2]);
            double quantity = double.Parse(tokens[3]);

            return new Sale
            {
                Town = town,
                Product = product,
                Price = price,
                Quantity = quantity
            };
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
