using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resultNums = new List<int>();

            for (int i = 0; i < listNums.Count; i++)
            {
                if (listNums[i] > 0)
                {
                    resultNums.Add(listNums[i]);
                }
            }
            resultNums.Reverse();
            if (resultNums.Count > 0)
            {
                Console.WriteLine(String.Join(" ", resultNums));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
