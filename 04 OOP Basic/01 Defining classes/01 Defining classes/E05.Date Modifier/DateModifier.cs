using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05.Date_Modifier
{
    public class DateModifier
    {
        public static int GetDateDifference(string firstDate, string secondDate)
        {
            TimeSpan difference = DateTime.Parse(firstDate) - DateTime.Parse(secondDate);
            return Math.Abs(difference.Days);
        }
    }
}
