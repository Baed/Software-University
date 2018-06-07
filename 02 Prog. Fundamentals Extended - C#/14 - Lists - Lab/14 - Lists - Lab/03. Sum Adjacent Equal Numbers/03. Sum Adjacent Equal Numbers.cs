using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < numList.Count; i++)
            {
                if (numList[i - 1] == numList[i])
                {
                    numList[i - 1] += numList[i];
                    numList.RemoveAt(i);
                    i = i - 2;
                    if (i < 0)
                    {
                        i = 0;
                    }
                    // ili i == 0;
                }
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
