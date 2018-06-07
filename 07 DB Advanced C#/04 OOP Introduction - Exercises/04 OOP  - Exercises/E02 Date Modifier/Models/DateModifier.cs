using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Date_Modifier.Models
{
    public class DateModifier
    {
        public static long GetDaysBeetwenTwoDate(string firstDateAsStr, string secondDateAsStr)
        {
            DateTime firstDate = DateTime.ParseExact(firstDateAsStr, "yyyy MM dd", CultureInfo.InvariantCulture);

            DateTime secondDate = DateTime.ParseExact(secondDateAsStr, "yyyy MM dd", CultureInfo.InvariantCulture);

            double result = (secondDate - firstDate).TotalDays;

            return (long)result;
        }
    }
}
