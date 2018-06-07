using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace _04.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            var baseN = int.Parse(input[0]);
            var numberDec = BigInteger.Parse(input[1]);

            Console.WriteLine(GetOwnMetodToConvert(baseN, numberDec));
        }

        private static string GetOwnMetodToConvert(int baseN, BigInteger numberDec)
        {
            var builder = new StringBuilder();

            while (numberDec != 0)
            {
                builder.Append(numberDec % baseN);
                numberDec /= baseN;
            }

            var serchedNum = new StringBuilder();

            for (int i = builder.Length - 1; i >= 0; i--)
            {
                serchedNum.Append(builder[i]);
            }

            return serchedNum.ToString();

        }
    }
}
