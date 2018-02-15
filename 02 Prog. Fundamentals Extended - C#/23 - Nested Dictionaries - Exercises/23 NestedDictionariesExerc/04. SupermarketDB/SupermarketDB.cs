using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SupermarketDB
{
    class SupermarketDB
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> data = new Dictionary<string, double[]>();

            double totalSum = 0;

            string input;
            while ((input = Console.ReadLine()) != "stocked")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!data.ContainsKey(product))
                {
                    data.Add(product, new double[2]);
                    data[product] = new double[] { 0.0, 0.0 };
                }

                data[product][0] = price;
                data[product][1] += quantity;
            }

            foreach (var kvp in data)
            {
                Console.WriteLine("{0}: ${1:F2} * {2} = ${3:F2}", kvp.Key, kvp.Value[0], kvp.Value[1], kvp.Value[0] * kvp.Value[1]);

                totalSum += kvp.Value[0] * kvp.Value[1];
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${totalSum:f2}");
        }
    }
}
