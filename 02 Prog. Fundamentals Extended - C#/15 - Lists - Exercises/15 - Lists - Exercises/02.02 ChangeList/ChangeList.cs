using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02_ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbersList = ExecuteCommandLine(numbersList);

            Writer(numbersList);
        }

        private static void Writer(List<int> numbersList)
        {
            Console.WriteLine(String.Join(" ", numbersList));
        }

        private static List<int> ExecuteCommandLine(List<int> numbersList)
        {
            string[] commandLine = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                switch (commandLine[0])
                {
                    case "Delete":
                        numbersList
                            .Where(a => a == int.Parse(commandLine[1]))
                            .ToList()
                            .ForEach(a => numbersList.Remove(a));
                        break;
                    case "Insert":
                        numbersList.Insert(int.Parse(commandLine[2]), int.Parse(commandLine[1]));
                        break;
                    case "Odd":
                        numbersList
                            .Where(a => a % 2 == 0)
                            .ToList()
                            .ForEach(a => numbersList.Remove(a));
                        return numbersList;
                    case "Even":
                         numbersList
                            .Where(a => a % 2 != 0)
                            .ToList()
                            .ForEach(a => numbersList.Remove(a));
                        return numbersList;
                }

                commandLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
