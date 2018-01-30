using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int doctors = 7;
            int Treated = 0;
            int Untreated = 0;

            for (int i = 1; i <= day; i++)
            {
                int patient = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && Untreated > doctors)
                {
                    doctors++;
                }

                if (patient > doctors)
                {
                    Treated += doctors;
                    Untreated += patient - doctors;
                }
                else
                {
                    Treated += patient;
                }

            }

            Console.WriteLine($"Treated patients: {Treated}.");
            Console.WriteLine($"Untreated patients: {Untreated}.");
        }
    }
}
