using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrTarget = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] arrCommand = Console.ReadLine().Split().ToArray();
            int currentAltitudeX = 0;
            int currentAltitudeY = 0;
            bool isGotEm = false;
            for (int i = 0; i < arrCommand.Length; i++)
            {
                if (i % 2 == 0)
                {
                    switch (arrCommand[i])
                    {
                        case "right": currentAltitudeX += int.Parse(arrCommand[i + 1]); break;
                        case "left": currentAltitudeX -= int.Parse(arrCommand[Math.Abs(i + 1)]); break;
                        case "up": currentAltitudeY += int.Parse(arrCommand[i + 1]); break;
                        case "down": currentAltitudeY -= int.Parse(arrCommand[i + 1]); break;
                    }
                    if (currentAltitudeX == arrTarget[0] && currentAltitudeY == arrTarget[1])
                    {
                        isGotEm = true;
                        break;
                    }
                }
            }
            Console.WriteLine(isGotEm == true ? $"firing at [{currentAltitudeX}, {currentAltitudeY}]\ngot 'em!" : $"firing at [{currentAltitudeX}, {currentAltitudeY}]\nbetter luck next time...");
        }
    }
}
