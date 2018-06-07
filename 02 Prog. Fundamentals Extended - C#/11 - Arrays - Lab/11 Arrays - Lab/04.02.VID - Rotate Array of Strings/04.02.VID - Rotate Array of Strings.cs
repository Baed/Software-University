using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02.VID___Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrString = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            string[] arrRotate = new string[arrString.Length];
            for (int i = 0; i < arrString.Length - 1; i++)
            {
                arrString[i + 1] = arrString[i];
                //arrString[(i + 1) % arrString.Length] = arrString[i];
            }
            arrRotate[0] = arrString[arrString.Length - 1]; // bez tova v skruten var
            Console.WriteLine(string.Join(" ", arrRotate));
        }
    }
}
