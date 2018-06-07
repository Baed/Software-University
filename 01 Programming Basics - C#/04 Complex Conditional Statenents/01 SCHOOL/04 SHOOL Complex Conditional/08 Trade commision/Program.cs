using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Trade_commision
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            bool firstsales = sales >= 0 && sales <= 500;
            bool secondsales = sales > 500 && sales <= 1000;
            bool thirdsales = sales > 1000 && sales <= 10000;
            bool foursales = sales > 10000;

            double commisionpercent = 0.0;

            if (town == "Sofia")
            {
                if (firstsales)
                {
                    commisionpercent = 0.05;
                }

                else if (secondsales)
                {
                    commisionpercent = 0.07;
                }

                else if (thirdsales)
                {
                    commisionpercent = 0.08;
                }

                else if (foursales)
                {
                    commisionpercent = 0.12;
                }

            }

            if (town == "Varna")
            {
                if (firstsales)
                {
                    commisionpercent = 0.045;
                }

                else if (secondsales)
                {
                    commisionpercent = 0.075;
                }

                else if (thirdsales)
                {
                    commisionpercent = 0.10;
                }

                else if (foursales)
                {
                    commisionpercent = 0.13;
                }
            }

            if (town == "Plovdiv")
            {
                if (firstsales)
                {
                    commisionpercent = 0.055;
                }

                else if (secondsales)
                {
                    commisionpercent = 0.08;
                }

                else if (thirdsales)
                {
                    commisionpercent = 0.12;
                }

                else if (foursales)
                {
                    commisionpercent = 0.145;
                }
            }

            if (commisionpercent == 0)
            {
                Console.WriteLine("error");
            }

            else
            {
                Console.WriteLine($"{(sales * commisionpercent):f2}");
            }

        }
    }
}
