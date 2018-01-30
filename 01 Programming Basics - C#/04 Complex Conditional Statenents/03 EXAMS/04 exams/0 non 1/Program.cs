using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_non_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int Exam = examHour * 60 + examMinutes;
            int Arrive = arriveHour * 60 + arriveMinutes;

            int diffMinutes = Exam - Arrive;

            int diffHours = 0;


            if (diffMinutes == 0 || diffMinutes > 0 && diffMinutes <= 30)
            {
                Console.WriteLine("On time");

                if (diffMinutes != 0)
                {
                    Console.WriteLine("{0} minutes before the start", diffMinutes);
                }

            }
            else if (diffMinutes > 30)
            {
                Console.WriteLine("Early");

                while (diffMinutes > 59)
                {
                    diffHours++;
                    diffMinutes -= 60;
                }

                if (diffHours > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", diffHours, diffMinutes);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", diffMinutes);
                }

            }

            else
            {
                Console.WriteLine("Late");

                diffMinutes = Math.Abs(diffMinutes);

                while (diffMinutes > 59)
                {
                    diffHours++;
                    diffMinutes -= 60;
                }

                if (diffHours > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", diffHours, diffMinutes);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", diffMinutes);
                }
            }
        }
    }
}
