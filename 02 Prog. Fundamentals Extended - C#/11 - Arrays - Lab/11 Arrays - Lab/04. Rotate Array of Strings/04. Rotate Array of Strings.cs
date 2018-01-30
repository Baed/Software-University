using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrString = Console.ReadLine().Split().ToArray();
            //string[] test = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            /* ---> gornoto +.ToArray() zamestva zakomentiranoto
            string[] ArrStrings = new string[stringInput.Length];
            for (int i = 0; i < stringInput.Length; i++)
            {
                ArrStrings[i] = stringInput[i];
            }
            */
            string[] arrRotate = new string[arrString.Length];
            for (int i = 0; i < arrString.Length - 1; i++)
            { // mahame posledniq element, kato namalqvame array
                arrRotate[i + 1] = arrString[i]; // nalivame v noviq arr ot 2 element
            }
            string lastElement = arrString[arrRotate.Length - 1]; //vzemame posledniq element
            arrRotate[0] = lastElement;
            Console.WriteLine(string.Join(" ", arrRotate));
        }
    }
}
