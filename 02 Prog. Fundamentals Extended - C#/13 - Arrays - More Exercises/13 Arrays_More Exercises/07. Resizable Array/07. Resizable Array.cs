using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class Program
    {
        static int[] elements;
        static int elementsLength;

        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split();
            elements = new int[4];
            elementsLength = 0;

            while (inputTokens[0] != "end")
            {
                string command = inputTokens[0];
                switch (command)
                {
                    case "push":
                        elements[elementsLength] = int.Parse(inputTokens[1]);
                        elementsLength++;
                        if (elementsLength >= elements.Length)
                        {
                            GrowArray();
                        }
                        break;
                    case "pop":
                        elements[elementsLength] = 0;
                        elementsLength--;
                        break;
                    case "removeAt":
                        int index = int.Parse(inputTokens[1]);
                        shiftArray(index);
                        elementsLength--;
                        break;
                    case "clear":
                        elementsLength = 0;
                        break;
                    default:
                        break;
                }
                inputTokens = Console.ReadLine().Split();
            }
            PrintArray();
        }
        static void PrintArray()
        {
            for (int i = 0; i < elementsLength; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }
        static void GrowArray()
        {
            int[] newArray = new int[elementsLength * 2];
            for (int i = 0; i < elementsLength; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }
        static void shiftArray(int index)
        {
            for (int i = index + 1; i < elementsLength; i++)
            {
                elements[i - 1] = elements[i];
            }
        }
    }
}
