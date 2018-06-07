using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E02_Date_Modifier.Models;

namespace E02_Date_Modifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstDateAsStr = Console.ReadLine();

            var secondDateAsStr = Console.ReadLine();

            var result = DateModifier.GetDaysBeetwenTwoDate(firstDateAsStr, secondDateAsStr);

            Console.WriteLine(Math.Abs(result));
        }
    }
}
