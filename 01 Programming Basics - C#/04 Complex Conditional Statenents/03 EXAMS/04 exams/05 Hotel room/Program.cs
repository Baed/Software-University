using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            var StudioPrice = 0.0;
            var ApartmentPrice = 0.0;
            
            if (month == "May" || month == "October")
            {
                StudioPrice = 50.00;
                ApartmentPrice = 65.00;

                if (night > 14)
                {
                    StudioPrice -= 0.30 * 50.00;
                    ApartmentPrice -= 0.10 * 65.00;
                }

                else if (night > 7)
                {
                    StudioPrice -= 0.05 * 50.00; // -= ==> 5% = 1-0.05
                }
            }

            else if (month == "June" || month == "September")
            {
                StudioPrice = 75.20;
                ApartmentPrice = 68.70;

                if (night > 14)
                {
                    StudioPrice -= 0.20 * 75.20;
                    ApartmentPrice -= 0.10 * 68.70;
                }
            }

            else if (month == "July" || month == "August")
            {
                StudioPrice = 76.00;
                ApartmentPrice = 77.00;

                if (night > 14)
                {
                    ApartmentPrice -= 0.10 * 77.00;
                }
            }

            Console.WriteLine($"Apartment: {ApartmentPrice * night:f2} lv."
                        + $"\nStudio: {StudioPrice * night:f2} lv.");

        }
    }
}
