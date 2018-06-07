using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01_CountWorkingDay
{
    public class CountWorkingDay
    {
        public static void Main()
        {
            List<Date> holidays = GetHolidays();

            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime lastDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int cntWorkingDays = 0;

            for (DateTime i = firstDate; i <= lastDate; i = i.AddDays(1))
            {
                bool isNonWorkingDay = IsHoliday(i, holidays) 
                                       || i.DayOfWeek == DayOfWeek.Saturday 
                                       || i.DayOfWeek == DayOfWeek.Sunday;
                if (!isNonWorkingDay)
                {
                    cntWorkingDays++;
                }
            }

            Console.WriteLine(cntWorkingDays);
        }

        private static bool IsHoliday(DateTime date, List<Date> holidays)
        {
            foreach (Date holiday in holidays)
            {
                if (holiday.Month == date.Month && holiday.Day == date.Day)
                {
                    return true;
                }
            }

            return false;
        }

        private static List<Date> GetHolidays()
        {
            List<Date> holidays = new List<Date>();
            holidays.Add(new Date() { Month = 1, Day = 1 });
            holidays.Add(new Date() { Month = 3, Day = 3 });
            holidays.Add(new Date() { Month = 5, Day = 1 });
            holidays.Add(new Date() { Month = 5, Day = 6 });
            holidays.Add(new Date() { Month = 5, Day = 24 });
            holidays.Add(new Date() { Month = 9, Day = 6 });
            holidays.Add(new Date() { Month = 9, Day = 22 });
            holidays.Add(new Date() { Month = 11, Day = 1 });
            holidays.Add(new Date() { Month = 12, Day = 24 });
            holidays.Add(new Date() { Month = 12, Day = 25 });
            holidays.Add(new Date() { Month = 12, Day = 26 });

            return holidays;
        }
    }

    class Date
    {
        public int Month { get; set; }

        public int Day { get; set; }
    }
}
