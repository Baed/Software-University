using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01_ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                switch (command[0])
                {
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Reverse":
                        arr = arr.Reverse().ToArray();
                        break;
                    case "Replace":
                        Replace(arr, int.Parse(command[1]), command[2]);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", arr));

        }

        private static void Replace(string[] arr, int ìndex, string text)
        {
            arr[ìndex] = text;
        }
    }
}
