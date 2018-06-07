using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static Regex pattern = new Regex(@"^\d+(?<message>[a-zA-Z]+)[^a-zA-Z]*$");

        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "Over!")
            {
                int inputCmd = int.Parse(Console.ReadLine());

                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);
                    string message = match.Groups["message"].Value;

                    if (message.Length == inputCmd)
                    {
                        string decryptedMsg = ExtractIndices(input, message);

                        Console.WriteLine("{0} == {1}", message, decryptedMsg);
                    }
                }
            }
        }

        private static string ExtractIndices(string encryptedMsg, string msg)
        {
            string result = "";
            for (int i = 0; i < encryptedMsg.Length; i++)
            {
                if (char.IsDigit(encryptedMsg[i]))
                {
                    int index = encryptedMsg[i] - '0';
                    if (index < msg.Length)
                    {
                        result += msg[index];
                    }
                    else
                    {
                        result += " ";
                    }
                }
            }
            return result;
        }
    }
}
