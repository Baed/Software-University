using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var num = 1;
            var ctr_calories = 0;
            do
            {
                string ingredients = Console.ReadLine().ToLower();
                num++;
                if (ingredients == "cheese")
                {
                    ctr_calories += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    ctr_calories += 150;
                }
                else if (ingredients == "salami")
                {
                    ctr_calories += 600;
                }
                else if (ingredients == "pepper")
                {
                    ctr_calories += 50;
                }
            } while (num <= n);

            Console.WriteLine($"Total calories: {ctr_calories}");
        }
    }
}
