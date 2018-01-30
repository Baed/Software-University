using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ontime_for_exams
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minuteArrival = int.Parse(Console.ReadLine());

            int Exam = hourExam * 60 + minuteExam;
            int Arrive = hourArrival * 60 + minuteArrival;
            int diffMinutes =Exam - Arrive;
            int diffHours = 0;

            if (diffMinutes == 0 || diffMinutes > 0 && diffMinutes <= 30 )
            {
                Console.WriteLine("On time");             
                if (diffMinutes != 0)
                {
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }  
            }

            else if (diffMinutes > 30)
            {
                Console.WriteLine("Early");

                while (diffMinutes > 59)
                { 
                    diffHours++; // diffHours = diffHours + 1;
                    diffMinutes -= 60; // diffMinutes = diffMinutes - 60;
                }
                if (diffHours > 0)
                {
                    Console.WriteLine($"{diffHours}:{diffMinutes:00} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }
            }
            
            else
            {
                Console.WriteLine("Late");
                diffMinutes = Math.Abs(diffMinutes);
                
                while (diffMinutes >59)
                {
                    diffHours++; // diffHours = diffHours + 1;
                    diffMinutes -= 60; // diffMinutes = diffMinutes - 60;
                }

                if ( diffHours > 0)
                {
                    Console.WriteLine($"{diffHours}:{diffMinutes:00} hours after the start"); // :00 --> dva znaka "05"
                }
                else
                {
                    Console.WriteLine($"{diffMinutes} minutes after the start"); ;
                }                
            }
        }
    }
}
