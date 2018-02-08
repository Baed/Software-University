using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_SafeManipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            string[] command = Console.ReadLine().Split(' ');
            while(command[0] != "END")
            {
                try
                {
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
                        default: Console.WriteLine("Invalid input!"); break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        private static void Replace(string[] arr, int ìndex, string text)
        {
            arr[ìndex] = text;
        }
    }
}
