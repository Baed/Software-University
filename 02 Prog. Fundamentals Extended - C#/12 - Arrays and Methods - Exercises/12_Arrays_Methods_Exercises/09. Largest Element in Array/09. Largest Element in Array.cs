using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrNum = new int[int.Parse(Console.ReadLine())];
            /*
            string[] input = Console.ReadLine().Split();
            int[] arrNum = new int[input.Length];      
            for (int i = 0; i < input.Length; i++)
            {
                arrNum[i] = int.Parse(input[i]);
            }
            */
            int maxValue = int.MinValue;
            //string result = ""; // druga zadacha
            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = int.Parse(Console.ReadLine());// i tova izchezva
                //int subResult = arrNum[i]; // druga zadacha
                //result += subResult; // druga zadacha
                if (arrNum[i] > maxValue)
                {
                    maxValue = arrNum[i];
                }
            }
            //Console.WriteLine(result); // druga zadacha
            Console.WriteLine(maxValue);
        }
    }
}
