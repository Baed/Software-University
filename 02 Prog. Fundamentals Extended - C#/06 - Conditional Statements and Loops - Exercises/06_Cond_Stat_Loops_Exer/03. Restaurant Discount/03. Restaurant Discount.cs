using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();   
            var discount = 0.0;
            var price_package = 0.0;
            var price_hall = 0.0;
            var type_Hall = String.Empty;
            switch (package) {
                case "Normal": discount = 0.05; price_package = 500; break;
                case "Gold": discount = 0.10; price_package = 750; break;
                case "Platinum": discount = 0.15; price_package = 1000; break;
                default: discount = 0.0; price_package = 0; break;
            }
            if (people > 120) {
                Console.WriteLine($"We do not have an appropriate hall.");
            }
            else if (people > 100) {
                price_hall = 7500; type_Hall = "Great Hall";
            }          
            else if (people > 50) {
                price_hall = 5000; type_Hall = "Terrace";
            }           
            else if (people > 0) {
                price_hall = 2500; type_Hall = "Small Hall";
            }           
            if (people <= 120)
            {
                Console.WriteLine($"We can offer you the {type_Hall}");
                Console.WriteLine($"The price per person is {(price_hall + price_package - (price_hall + price_package) * discount) / people:f2}$");
            }
            
        }
    }
}
