using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Trade_Commision
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            var commision = 0.0;

            if (city == "sofia")
            {
                if (0 <= s && s <= 500)
                {
                    commision = 0.05;
                }

                else if (500 < s && s <= 1000)
                {
                    commision = 0.07;
                }

                else if (1000 < s && s <= 10000)
                {
                    commision = 0.08;
                }

                else if (s > 1000)
                {
                    commision = 0.12;
                }
            }

            else if (city == "varna")
            {

                if (0 <= s && s <= 500)
                {
                    commision = 0.045;
                }

                else if (500 < s && s <= 1000)
                {
                    commision = 0.075;
                }

                else if (1000 < s && s <= 10000)
                {
                    commision = 0.10;
                }

                else if (s > 1000)
                {
                    commision = 0.13;
                }
            }

            else if (city == "plovdiv")
            {

                if (0 <= s && s <= 500)
                {
                    commision = 0.055;
                }

                else if (500 < s && s <= 1000)
                {
                    commision = 0.08;
                }

                else if (1000 < s && s <= 10000)
                {
                    commision = 0.12;
                }

                else if (s > 1000)
                {
                    commision = 0.145;
                }
            }

            if (commision > 0)
            {
                Console.WriteLine($"{(commision * s):f2}");
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
