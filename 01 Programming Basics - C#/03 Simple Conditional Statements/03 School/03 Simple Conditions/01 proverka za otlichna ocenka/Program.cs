using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_proverka_za_otlichna_ocenka
{
    class Program
    {
        static void Main(string[] args)
        {
            // nad 5.50 e otleichen
            double grade = double.Parse(Console.ReadLine());

            bool isexcellent = grade >= 5.50; // bool - При команди с IF/ IF ELSE/.. true или false само това

            //Console.WriteLine(isexcellent);

            if (isexcellent)
            {
                Console.WriteLine("Excellent!");
            }

            else
            {
                Console.WriteLine("Not Excellent.");
            }


        }
    }
}
