namespace E07_Custom_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomList<string> customList = new CustomList<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var commandArgs = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var command = commandArgs[0];
                commandArgs = commandArgs.Skip(1).ToList(); //skip commandArgs[0]

                switch (command)
                {
                    case "Add":
                        customList.Add(commandArgs[0]);
                        break;
                    case "Remove":
                        customList.Remove(int.Parse(commandArgs[0])); // NB do not print element
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(commandArgs[0]));
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(commandArgs[0]), int.Parse(commandArgs[1]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(commandArgs[0]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        customList.Print();
                        break;
                    case "Sort":
                        customList = Sorted.Sort(customList);
                        break;
                    default: break;
                }
            }
        }
    }
}
