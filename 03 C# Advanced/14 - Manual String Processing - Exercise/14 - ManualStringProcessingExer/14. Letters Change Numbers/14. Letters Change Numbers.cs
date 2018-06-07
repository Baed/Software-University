using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var result = CalculateSum(input);

            Console.WriteLine($"{result:f2}");           
        }

        private static decimal CalculateSum(string[] input)
        {
            decimal result = 0;
            foreach (var token in input)
            {
                result += CalculateSumTokens(token);
            }

            return result;
        }

        private static decimal CalculateSumTokens(string token)
        {
            var firstLetter = token[0];
            var lastLetter = token[token.Length - 1];
            var number = int.Parse(token.Substring(1, token.Length - 2));
            decimal sum = number;

            switch (char.IsUpper(firstLetter))
            {
                case true: sum /= GetLetterNumber(firstLetter); break;
                case false: sum *= GetLetterNumber(firstLetter); break;
            }
            switch (char.IsUpper(lastLetter))
            {
                case true: sum -= GetLetterNumber(lastLetter); break;
                case false: sum += GetLetterNumber(lastLetter); break;
            }

            return sum;
        }

        private static decimal GetLetterNumber(char letter)
        {
            if (char.IsUpper(letter))
            {
                return letter - 'A' + 1;
            }
            if (char.IsLower(letter))
            {
                return letter - 'a' + 1;
            }

            return 0;
        }
    }
}
