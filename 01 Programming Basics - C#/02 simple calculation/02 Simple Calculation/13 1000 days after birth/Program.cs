using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _13_1000_days_after_birth
{
    class Program
    {
        static void Main(string[] args)
        {

            //using System.Globalization; - монтираме глобализацията

             string input = Console.ReadLine(); // wuvejdane na format dd-mm-yyyy
             DateTime today = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
             //DateTime today = date;
             DateTime answer = today.AddDays(999);
            //Console.WriteLine("{0:dd-MM-yyyy}", today);
             Console.WriteLine("{0:dd-MM-yyyy}", answer);
            //Console.WriteLine(thousanddayafter.ToString("dd-mm-yyyy"));
            // https://msdn.microsoft.com/en-us/library/system.datetime.adddays(v=vs.110).aspx


            //DateTime today = DateTime.Now;
            //DateTime answer = today.AddDays(36);
            //Console.WriteLine("Today: {0:dddd}", today);
            //Console.WriteLine("36 days from today: {0:dddd}", answer);


        }
    }
}
