using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrPhoneNum = Console.ReadLine().Split().ToArray();
            string[] arrNames = Console.ReadLine().Split().ToArray();
            string inputName = "";
            while (inputName != "done")
            {
                inputName = Console.ReadLine();
                for (int i = 0; i < arrNames.Length; i++)
                {
                    if (arrNames[i] == inputName)
                    {
                        Console.WriteLine($"{arrNames[i]} -> {arrPhoneNum[i]}");
                        break;
                    }
                }
            }            
        }
    }
}
