using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {
                char charInput = char.Parse(Console.ReadLine());
                string encrypted = Encrypt(charInput);
                result += encrypted;
            }
            Console.WriteLine(result);
        }
        static string Encrypt(char charInput)
        {
            int asciiCodeNumber = charInput;
            int firstDigit = asciiCodeNumber;
            while (firstDigit >= 10) // za da iskara edna cifra --> firstDigit <10;
            {
                firstDigit /= 10;
            }
            int lastDigit = asciiCodeNumber % 10;
            char firstChar = (char)(asciiCodeNumber + lastDigit);
            char lastChar = (char)(asciiCodeNumber - firstDigit);
            string textOutput ="" + firstChar + firstDigit + lastDigit + lastChar;
            return textOutput;
        }
    }
}
