using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var baseN = int.Parse(input[0]);
            string numberbasedToN = input[1];

            Console.WriteLine(GetOwnMetodToConvert(baseN, numberbasedToN));       
        
        }

        private static BigInteger GetOwnMetodToConvert(int baseN, string numberbasedToN)
        {
            BigInteger numberDec = 0;

            for (int power = 0; power < numberbasedToN.Length; power++)
            {
                numberDec += int.Parse(numberbasedToN[numberbasedToN.Length - 1 - power].ToString()) * GetCalcNumRaisedToPower(baseN, power);
            }

            return numberDec;
        }

        private static BigInteger GetCalcNumRaisedToPower(int baseN, int power)
        {
            BigInteger result = 1;

            for (int p = 0; p < power; p++)
            {
                result *= baseN;
            }

            return result;
        }
    }
}
