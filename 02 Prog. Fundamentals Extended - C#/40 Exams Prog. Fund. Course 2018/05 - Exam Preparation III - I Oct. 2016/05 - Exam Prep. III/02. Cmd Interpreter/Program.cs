using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cmd_Interpreter
{
    class Program
    {
        private const string Exeptions = "Invalid input parameters.";

        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                var cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string instruct = cmdArgs[0];

                switch (instruct)
                {
                    case "reverse":
                        int startIndex = int.Parse(cmdArgs[2]);
                        int count = int.Parse(cmdArgs[4]);
                        ExecuteReverse(startIndex, count, collection);
                        break;

                    case "sort":
                        startIndex = int.Parse(cmdArgs[2]);
                        count = int.Parse(cmdArgs[4]);
                        ExecuteSort(startIndex, count, collection);
                        break;

                    case "rollLeft":
                        count = int.Parse(cmdArgs[1]);
                        ExecuteRollLeft(count, collection);
                        break;

                    case "rollRight":
                        count = int.Parse(cmdArgs[1]);
                        ExecuteRollRight(count, collection);
                        break;
                    default: break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", collection)}]");
        }

        private static void ExecuteRollRight(int count, List<string> collection)
        {
            if (count > 0)
            {
                for (int i = 0; i < count % collection.Count; i++) // less iterations 
                {
                    string element = collection[collection.Count - 1]; // last index
                    collection.RemoveAt(collection.Count - 1); // remove last element
                    collection.Insert(0, element); // add element to first index
                }
            }
            else
            {
                Console.WriteLine(Exeptions);
            }
        }

        private static void ExecuteRollLeft(int count, List<string> collection)
        {
            if (count > 0)
            {
                for (int i = 0; i < count % collection.Count; i++) // less iterations 
                {
                    string element = collection[0]; // first index
                    collection.RemoveAt(0); // remove first element
                    collection.Add(element); // add element to last index
                }
            }
            else
            {
                Console.WriteLine(Exeptions);
            }
        }

        private static void ExecuteSort(int startIndex, int count, List<string> collection)
        {
            List<string> temp = new List<string>();

            if (IsInRange(startIndex, count, collection.Count))
            {
                temp = collection.Skip(startIndex).Take(count).OrderBy(x => x).ToList();

                collection.RemoveRange(startIndex, count);
                collection.InsertRange(startIndex, temp);
            }
            else
            {
                Console.WriteLine(Exeptions);
            }

        }

        private static void ExecuteReverse(int startIndex, int count, List<string> collection)
        {
            List<string> temp = new List<string>();

            if (IsInRange(startIndex, count, collection.Count))
            {
                temp = collection.Skip(startIndex).Take(count).Reverse().ToList();

                collection.RemoveRange(startIndex, count);
                collection.InsertRange(startIndex, temp);
            }
            else
            {
                Console.WriteLine(Exeptions);
            }
        }

        private static bool IsInRange(int startIndex, int count, int collectionCount)
        {
            if (startIndex < 0 || startIndex + count > collectionCount || count < 0 || startIndex >= collectionCount)
            {
                return false;
            }

            return true;
        }
    }
}
