using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elementsArr = Console.ReadLine().Split(); // var == string[]
            double[] arrNum = new double[elementsArr.Length];

            for (int i = 0; i < elementsArr.Length; i++)
            {
                arrNum[i] = double.Parse(elementsArr[i]); // prevrustame str --> double
            }

            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] *= p;
            }
            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.Write(arrNum[i] + " ");
            }
            Console.WriteLine();           
        }
    }
}
