using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int camelsBack = int.Parse(Console.ReadLine());
            int roundsCnt = 0;

            while (elements.Count > camelsBack)
            {
                elements.RemoveAt(0); //premahvane na indexa na elementa;
                elements.RemoveAt(elements.Count - 1); //premahvane na indexa na elementa;

                roundsCnt++;
            }
            if (roundsCnt == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", elements)}");
            }
            else
            {
                Console.WriteLine($"{roundsCnt} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", elements)}");
            }
        }
    }
}
