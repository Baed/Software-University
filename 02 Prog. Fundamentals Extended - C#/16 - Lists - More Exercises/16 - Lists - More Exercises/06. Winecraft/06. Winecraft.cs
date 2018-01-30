using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft
{
    class Program
    {
        static int[] grapes;
        static void Main(string[] args)
        {
            grapes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            do
            {
                for (int i = 0; i < n; i++)
                {
                    BloomGrape();
                }

                KillGrapesWithPowerLesserOrEqualTo(n);
            } while (StrongGrapesAreGraterOrEqualThan(n));
            PrintLiveGrapes();
        }

        static void PrintLiveGrapes() // 3
        {
            for (int index = 0; index < grapes.Length; index++)
            {
                if (IsAlive(index))
                {
                    Console.Write(grapes[index] + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsAlive(int index) // 4
        {
            if (index < 0 || index >= grapes.Length )
            {
                return false;
            }
            return grapes[index] > 0;
        }

        static void KillGrapesWithPowerLesserOrEqualTo(int treshold) // 2
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (grapes[i] <= treshold)
                {
                    grapes[i] = 0;
                }
            }
        }

        static bool StrongGrapesAreGraterOrEqualThan(int treshold) // 1
        {
            //return grapes.Where(e => e > treshold).Count() >= treshold;
            int strongGrapesCnt = 0;
            for (int i = 0; i < grapes.Length; i++)
            {
                if (grapes[i] > treshold)
                {
                    strongGrapesCnt++;
                }
            }
            return (strongGrapesCnt >= treshold);
        }

        static void BloomGrape() // 5
        {
            for (int index = 0; index < grapes.Length; index++)
            {
                if (!IsAlive(index))
                {
                    continue;
                }
                if (IsGreaterGrape(index))
                {
                    grapes[index]++;
                    if (IsAlive(index - 1))
                    {
                        grapes[index]++;
                        grapes[index - 1]--;
                    }
                    if (IsAlive(index + 1))
                    {
                        grapes[index]++;
                        grapes[index + 1]--;
                    }
                }
                else if (IsLesserGrape(index))
                {
                    // do nothing
                }
                else 
                {
                    // normal grape
                    grapes[index]++;
                }
            }
        }

        static bool IsGreaterGrape(int index) // 7
        {
            if (index <= 0 || index >= (grapes.Length - 1))
            {
                return false;
            }
            return (grapes[index] > grapes[index - 1] && grapes[index] > grapes[index + 1]);
        }

        static bool IsLesserGrape(int index) // 6
        {
            //return (IsGreaterGrape(index - 1) || IsGreaterGrape(index + 1));
            if (IsGreaterGrape(index - 1) || IsGreaterGrape(index + 1))
            {
                return true;
            }

            return false;
        }
    }
}
