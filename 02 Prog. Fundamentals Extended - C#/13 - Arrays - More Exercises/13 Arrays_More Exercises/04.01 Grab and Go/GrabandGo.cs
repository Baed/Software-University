using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_Grab_and_Go
{
    class GrabandGo
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            long sum = 0;

            bool isExist = false;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == n)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += arr[j];       
                    }
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
