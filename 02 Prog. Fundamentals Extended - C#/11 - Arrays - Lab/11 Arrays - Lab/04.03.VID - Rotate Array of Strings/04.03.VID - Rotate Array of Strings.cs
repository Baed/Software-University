using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.VID___Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string currentElement = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                string temp = arr[i];
                arr[i] = currentElement;
                currentElement = temp;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
