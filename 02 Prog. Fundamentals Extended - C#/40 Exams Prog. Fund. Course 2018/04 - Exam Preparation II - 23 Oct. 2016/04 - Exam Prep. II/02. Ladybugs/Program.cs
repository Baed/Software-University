using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] ladybugs = new int[n];

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            GetInitialField(ladybugs, indexes);

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                var cmdArgs = command.Split();

                int index = int.Parse(cmdArgs[0]);
                string moving = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                switch (moving)
                {
                    case "right":
                        MoveRight(index, flyLength, ladybugs);

                        break;
                    case "left": MoveLeft(index, flyLength, ladybugs);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }

        private static void MoveLeft(int index, int flyLength, int[] ladybugs)
        {
            if (IsInRange(index, ladybugs.Length))
            {
                if (ladybugs[index] == 1)
                {
                    ladybugs[index] = 0;

                    if (flyLength > 0)
                    {
                        ladybugs = MoveNegative(index, -flyLength, ladybugs);

                    }
                    else
                    {
                        ladybugs = MovePositive(index, -flyLength, ladybugs);
                    }
                }
            }
        }

        private static void MoveRight(int index, int flyLength, int[] ladybugs)
        {
            if (IsInRange(index, ladybugs.Length))
            {
                if (ladybugs[index] == 1)
                {
                    ladybugs[index] = 0;

                    if (flyLength > 0)
                    {
                        ladybugs = MovePositive(index, flyLength, ladybugs);
                    }
                    else
                    {
                        ladybugs = MoveNegative(index, flyLength, ladybugs);
                    }
                }
            }
        }

        private static int[] MoveNegative(int index, int flyLength, int[] ladybugs)
        {
            for (int i = index + flyLength; i >= 0; i--)
            {
                if (ladybugs[i] == 0)
                {
                    ladybugs[i] = 1;
                    break;
                }
            }

            return ladybugs;
        }

        private static int[] MovePositive(int index, int flyLength, int[] ladybugs)
        {
            for (int i = index + flyLength; i < ladybugs.Length; i++)
            {
                if (ladybugs[i] == 0)
                {
                    ladybugs[i] = 1;
                    break;
                }
            }

            return ladybugs;
        }

        private static bool IsInRange(int index, int ladybugsLength)
        {
            if (index >= 0 && index < ladybugsLength)
            {
                return true;
            }

            return false;
        }


        private static void GetInitialField(int[] ladybugs, int[] indexes)
        {
            for (int i = 0; i < ladybugs.Length; i++)
            {
                for (int j = 0; j < indexes.Length; j++)
                {
                    if (i == indexes[j] && indexes[j] < ladybugs.Length && indexes[j] >= 0)
                    {
                        ladybugs[i] = 1;
                        break;
                    }
                }
            }
        }
    }
}
