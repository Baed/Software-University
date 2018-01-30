using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToList();

            foreach (var item in firstList)
            {
                secondList.Remove(item);
            }

            var sumFirstListElemensts = firstList.Sum();
            var sumSecondListElemensts = secondList.Sum();

            if (sumFirstListElemensts == sumSecondListElemensts)
            {
                Console.WriteLine($"Yes. Sum: {sumFirstListElemensts}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumSecondListElemensts - sumFirstListElemensts)}");
            }
        }
    }
}
