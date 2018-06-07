using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Debugging_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(Result(num));
        }
        static int Even(int n)
        {
            int sum = 0; // sum = 9
            while (n > 0)
            {
                int lastDiggit = n % 10; // (1) 12345 % 10 = 5 (2) 1234 % 10 = 4
                if (lastDiggit % 2 != 0) // even
                {
                    sum += lastDiggit; // (1)5 + (3)3 + (5)1 
                }
                n /= 10; // (1)12345 / 10 = 1234 (2) 1234 / 10 = 123
            }
            return sum;
        }
        static int Odd(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDiggit = n % 10;
                //sum += lastDiggit % 2 == 0 ? lastDiggit : 0;
                if (lastDiggit % 2 == 0)
                {
                    sum += lastDiggit;
                }
                n /= 10;
            }
            return sum;
        }
        static int  Result(int n)
        {
            return Even(n) * Odd(n);
        }
    }
}
