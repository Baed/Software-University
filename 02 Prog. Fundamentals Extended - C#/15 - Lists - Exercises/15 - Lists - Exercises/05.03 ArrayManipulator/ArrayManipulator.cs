using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03_ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] commandLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<int> result = ExecuteProgram(numbersList, commandLine);

            Writer(result);
        }

        private static void Writer(List<int> result)
        {
            Console.WriteLine($"[{String.Join(", ", result)}]");
        }

        private static List<int> ExecuteProgram(List<int> numbersList, string[] commandLine)
        {
            while (commandLine[0] != "print")
            {
                switch (commandLine[0])
                {
                    case "add":
                        numbersList.Insert(int.Parse(commandLine[1]), int.Parse(commandLine[2]));
                        break;
                    case "addMany":
                        numbersList = GetAddMany(numbersList, commandLine);
                        break;
                    case "contains":
                        //Console.WriteLine(numbersList.Contains(int.Parse(commandLine[1])) ? numbersList.IndexOf(int.Parse(commandLine[1])) : -1);
                        Console.WriteLine(numbersList.IndexOf(int.Parse(commandLine[1]))); // if don't exist return -1

                        break;
                    case "remove":
                        numbersList.RemoveAt(int.Parse(commandLine[1]));
                        break;
                    case "shift":
                        numbersList = GetShift(numbersList, int.Parse(commandLine[1]));
                        break;
                    case "sumPairs":
                        numbersList = GetSumPairs(numbersList);
                        break;
                }

                commandLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            return numbersList;
        }

        private static List<int> GetAddMany(List<int> numbersList, string[] command)
        {
            List<int> addElements = command.Skip(2).Select(int.Parse).ToList();

            numbersList.InsertRange(int.Parse(command[1]), addElements);

            return numbersList;
        }

        private static List<int> GetSumPairs(List<int> numbersList)
        {
            List<int> sumPairs = new List<int>();

            for (int i = 0; i < numbersList.Count - 1; i += 2)
            {
                sumPairs.Add(numbersList[i] + numbersList[i + 1]);
            }

            if (numbersList.Count % 2 != 0)
            {
                sumPairs.Add(numbersList[numbersList.Count - 1]);
            }

            return sumPairs;
        }

        private static List<int> GetShift(List<int> numbersList, int number)
        {
            for (int i = 0; i < number; i++)
            {
                int lastElement = numbersList[0];

                for (int j = 0; j < numbersList.Count - 1; j++)
                {
                    numbersList[j] = numbersList[j + 1];
                }

                numbersList[numbersList.Count - 1] = lastElement;
            }

            return numbersList;
        }
    }
}
