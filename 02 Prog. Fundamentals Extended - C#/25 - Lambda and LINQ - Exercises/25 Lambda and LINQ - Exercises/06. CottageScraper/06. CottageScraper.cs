using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<KeyValuePair<string, int>>(); // new Dictionary<string,List<int>>();

            string input = Console.ReadLine();

            while (input != "chop chop")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string woodType = tokens[0];
                int woodHeight = int.Parse(tokens[1]);

                data.Add(new KeyValuePair<string, int>(woodType, woodHeight));

                input = Console.ReadLine();
            }

            string wantedType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());

            double pricePerMeter = Math.Round(data.Average(d => d.Value), 2); 

            double usedLogsValue = data
                .Where(d => d.Key == wantedType && d.Value >= minHeight)
                .Sum(d => d.Value);

            double unUsedLogsValue = data
                .Where(d => !(d.Key == wantedType && d.Value >= minHeight))
                .Sum(d => d.Value);

            usedLogsValue = Math.Round(usedLogsValue * pricePerMeter, 2);
            unUsedLogsValue = Math.Round(unUsedLogsValue * pricePerMeter * 0.25, 2);

            double totalPrice = Math.Round(usedLogsValue + unUsedLogsValue, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogsValue:f2}");
            Console.WriteLine($"Unused logs price: ${unUsedLogsValue:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:f2}");
        }
    }
}
