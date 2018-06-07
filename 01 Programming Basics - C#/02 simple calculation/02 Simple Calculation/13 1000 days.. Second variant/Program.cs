using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1000_days._.Second_variant
{
    class Program
    {
        static void Main(string[] args)
        {

            var birthDate = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", CultureInfo.InvariantCulture);

            var thousanddayafter = birthDate.AddDays(999);

            Console.WriteLine(thousanddayafter.ToString("dd-mm-yyyy"));
           // Console.WriteLine("{dd:mm:yyyy}", thousanddayafter);


        }
    }
}
