using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Program
    {
        static string[] arrPhoneNum;
        static string[] arrNames;

        static void Main(string[] args)
        {
            arrPhoneNum = Console.ReadLine().Split(' ');
            arrNames = Console.ReadLine().Split(' ');
            string[] inputTokens = Console.ReadLine().Split(' ');
            while (inputTokens[0] != "done")
            {
                string command = inputTokens[0];
                string argument = inputTokens[1];
                string name;
                string telephoneNum;
                string output;
                if (IsNumber(argument))
                {
                    name = GetEntry(argument);
                    telephoneNum = argument;
                    output = name;
                }
                else
                {
                    name = argument;
                    telephoneNum = GetEntry(argument);
                    output = telephoneNum;
                }
                int digitSum = GetDigitSum(telephoneNum);
                if (command == "call")
                {
                    Console.WriteLine($"calling {output}...");
                    if (digitSum % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int minutes = digitSum / 60;
                        int seconds = digitSum % 60;
                        Console.WriteLine($"call ended. duration: {minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}");
                    }
                }
                else if (command == "message")
                {
                    Console.WriteLine($"sending sms to {output}...");
                    if (digitSum % 2 == 1)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }
                inputTokens = Console.ReadLine().Split(' ');
            }
        }
        static int GetDigitSum(string telephoneNum)
        {
            int sum = 0;
            for (int i = 0; i < telephoneNum.Length; i++)
            {
                if (IsDigit(telephoneNum[i]))
                {
                    sum += telephoneNum[i] - '0';// zaradi var -->string
                }
            }
            return sum;
        }

        static string GetEntry(string inputArgument)
        {
            for (int i = 0; i < arrPhoneNum.Length; i++)
            {
                if (arrNames[i] == inputArgument)
                {
                    return arrPhoneNum[i];
                }
                else if (arrPhoneNum[i] == inputArgument)
                {
                    return arrNames[i];
                }
            }
            return string.Empty;
        }

        static bool IsNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (IsDigit(input[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsDigit(char symbol)
        {
            if (symbol >= '0' && symbol <= '9')
            {
                return true;
            }
            return false;
        }
    }
}
