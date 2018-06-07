using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrString = Console.ReadLine().Split(' ').ToArray();
            string result = "";
            int cnt = 1;
            for (int i = arrString.Length - 1; i > 0; i--)
            {
                if (arrString[i - 1] == arrString[i])
                {
                    cnt++;
                    if (cnt == 3)
                    {
                        result = arrString[i] + " ";
                        Console.WriteLine(result + result + result);
                        break;
                    }
                }
                else
                {
                    cnt = 1;
                }
            }
        }
    }
}
