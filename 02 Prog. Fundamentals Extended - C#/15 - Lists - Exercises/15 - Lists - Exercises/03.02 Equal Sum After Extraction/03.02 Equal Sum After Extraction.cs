using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02_Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> filtredSecList = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list2.RemoveAt(j);
                        j--;
                    }
                }
            }

            // sec var
            /*
            for (int i = 0; i < list2.Count; i++)
            {
                list2 = list2.Where(a => !list1.Contains(a)).ToList(); 
            }
            */

            int sumList2 = list2.Sum();
            int sumList1 = 0;
            foreach (var item in list1)
            {
                sumList1 += item;
            }
            if (sumList1 == sumList2)
            {
                Console.WriteLine($"Yes. Sum: {sumList2}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumList2 - sumList1)}");
            }
        }
    }
}
