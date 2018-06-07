using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plantLives = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int daysCount = 0;
            int seasonCount = 0;
            int daysInSeason = plantLives.Length;
            while (AreAnyPlantAlive(plantLives))
            {
                for (int i = 0; i < plantLives.Length; i++)
                {
                    if (plantLives[i] != 0)
                    {
                        if ((daysCount % daysInSeason) != i)
                        {
                            plantLives[i]--;
                        }
                    }
                }
                daysCount++;
                if (daysCount % daysInSeason == 0)
                {
                    for (int i = 0; i < plantLives.Length; i++)
                    {
                        if (plantLives[i] != 0)
                        {
                            plantLives[i]++;
                        }
                    }
                    seasonCount++;
                }
            }
            if (daysCount % 4 == 0)
            {
                seasonCount--;
            }
            string seasonFormat = "seasons";
            if (seasonCount == 1)
            {
                seasonFormat = "season";
            }
            Console.WriteLine($"survived {daysCount} days ({seasonCount} {seasonFormat})");
        }
        static bool AreAnyPlantAlive(int[] plantlives)
        {
            for (int i = 0; i < plantlives.Length; i++)
            {
                if (plantlives[i] > 0 )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
