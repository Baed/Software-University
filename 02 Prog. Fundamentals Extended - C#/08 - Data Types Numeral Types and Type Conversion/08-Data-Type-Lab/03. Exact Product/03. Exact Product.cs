using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal product = 1m;
            for (int i = 0; i < n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine()); // bez tova
                // product *= decimal.Parse(Console.ReadLine()); // samo tova
                product *= num; // bez tova
            }
            Console.WriteLine(product);
        }
    }
}
