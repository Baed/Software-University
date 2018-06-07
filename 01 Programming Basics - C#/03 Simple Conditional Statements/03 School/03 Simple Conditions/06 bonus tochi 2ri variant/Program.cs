using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_bonus_tochi_2ri_variant
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var bonus = 0m; // zapochvame s 0, zashtoto tova e nachaloto

            if (number > 1000)
            {
                // bonus += 5; // sukraten variant
                bonus += number * 0.1m; //number = 0; promenq se v zavisimost ot uslovieto
                // bonus = 0 + 5
            }

            else if (number > 100) // ??? <=
            {
                bonus += number * 0.2m; // 20 %
            }

            else 
            {
                bonus += 5;
            }

            if (number % 2 == 0) // % modulno delenie s ostatuk
            {
                //bonus = bonus + 1;
                //bonus += 1;
                bonus++; // vzima bonusa i dobavq 1 kum nego
            }

            if (number % 10 == 5) // moje s else if v tozi sluchai
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
