using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            string[] result = arr
              .Where(a => a.Length == n)
              .Take(10)
              .ToArray();

            result
              .ToList()
              .ForEach(a => Console.WriteLine($"Adding {a}."));

            Console.WriteLine($"Made pizza with total of {result.Count(a => a.Length == n)} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(@", ", result.Where(a => a.Length == n))}.");

            // cheese flour tomato bread olives salami pepperoni cheese cheese cheese cheese cheese tomato salami olives
        }
    }
}
