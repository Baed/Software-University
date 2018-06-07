using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            nums.Sort(); // sortirame po vuzhoqsht
            var start = 0;
            var length = 1;
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1 || nums[i] != nums[i + 1])
                {
                    // new sequence starts --> Print the privious sequence
                    Console.WriteLine(nums[start] + " -> " + length);
                    start = i + 1;
                    length = 1;
                }
                else
                {
                    //Existing sequence end. New sequence start
                    length++;
                }
            }
        }
    }
}
