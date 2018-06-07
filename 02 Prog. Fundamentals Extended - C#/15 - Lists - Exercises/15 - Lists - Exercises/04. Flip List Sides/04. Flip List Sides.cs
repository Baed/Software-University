using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i < inputList.Count / 2; i++)
            {
                int firstNum = inputList[i];
                int lastNum = inputList[inputList.Count - 1 - i];

                inputList[i] = lastNum;
                inputList[inputList.Count - 1 - i] = firstNum;
                /*
                string temp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = temp;
                */
            }
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
