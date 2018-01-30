using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lection_num = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            
            var jelev_presence = 0.0;
            var royal_presence = 0.0;
            var roli_presence = 0.0;
            var trofon_presence = 0.0;
            var sino_presence = 0.0;
            var others_presence = 0.0;
            
            for (int i = 1; i <= lection_num; i++)
            {
                string lector_name = Console.ReadLine();
                
                if (lector_name == "Jelev")
                {
                    jelev_presence++;                   
                }
                else if (lector_name == "RoYaL")
                {
                    royal_presence++;
                }
                else if (lector_name == "Roli")
                {
                    roli_presence++;
                }
                else if (lector_name == "Trofon")
                {
                    trofon_presence++;
                }
                else if (lector_name == "Sino")
                {
                    sino_presence++;
                }
                else
                {
                    others_presence++;
                }
            }
            Console.WriteLine($"Jelev salary: {(budget/lection_num * jelev_presence):f2} lv");
            Console.WriteLine($"RoYaL salary: {(budget / lection_num * royal_presence):f2} lv");
            Console.WriteLine($"Roli salary: {(budget / lection_num * roli_presence):f2} lv");
            Console.WriteLine($"Trofon salary: {(budget / lection_num * trofon_presence):f2} lv");
            Console.WriteLine($"Sino salary: {(budget / lection_num * sino_presence):f2} lv");
            Console.WriteLine($"Others salary: {(budget / lection_num * others_presence):f2} lv");
        }
    }
}
