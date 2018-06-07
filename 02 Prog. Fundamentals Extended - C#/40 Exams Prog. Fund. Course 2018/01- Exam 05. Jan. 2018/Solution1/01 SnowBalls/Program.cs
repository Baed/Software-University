using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01_SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());

            BigInteger highestSnowballValue = 0;

            int snow = 0;
            int time = 0;
            byte quality = 0;

            while (numberOfSnowballs-- > 0)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;

                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }
            }

            Console.WriteLine($"{snow} : {time} = {highestSnowballValue} ({quality})");
        }
    }
}
