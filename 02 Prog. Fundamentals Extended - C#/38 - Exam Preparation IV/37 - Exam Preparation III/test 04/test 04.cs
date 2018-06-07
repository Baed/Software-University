using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test_04
{
    class Program
    {
        static Regex messagesPattern = new Regex(@"^\d+(?<message>[a-zA-Z]+)[^a-zA-Z]*$");

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Over!")
            {
                int validMsgLength =
                    int.Parse(Console.ReadLine());

                if (messagesPattern.IsMatch(input))
                {
                    Match match = messagesPattern.Match(input);
                    string msg = match.Groups["message"].Value;

                    if (msg.Length == validMsgLength)
                    {
                        string decryptedMsg =
                            ExtractIndices(input, msg);

                        Console.WriteLine("{0} == {1}",
                            msg,
                            decryptedMsg);
                    }
                }

                input = Console.ReadLine();
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
