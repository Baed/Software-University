using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());               

            for (int i = M; i >= 1; i--)
            {
                for (int j = N; j >= 1; j--)
                {
                    for (int k = L; k >= 1; k--)
                    {
                        int num = 100 * i + 10 * j + k;

                        if (num % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (num % 10 == 5) // ili k == 5
                        {
                            specialNum -= 2;
                        }
                        else if (num % 2 == 0)
                        {
                            specialNum *= 2;
                        }

                        if (specialNum >= controlNum)
                        {                           
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                            return;
                        }
                    }
                }              
            }
            if (specialNum < controlNum) // moje bez proverkata zaradi return
            {
                Console.WriteLine($"No! {specialNum} is the last reached special number.");
            }
            
        }
    }
}
