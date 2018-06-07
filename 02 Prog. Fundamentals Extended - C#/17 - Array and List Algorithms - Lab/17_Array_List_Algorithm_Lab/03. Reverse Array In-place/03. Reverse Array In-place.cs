using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();            

            int left = 0;
            int right = arr.Length - 1;
            while (left < arr.Length / 2) //(left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
            //arr = arr.Reverse().ToArray(); gornoto se sintezira do tozi red
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
