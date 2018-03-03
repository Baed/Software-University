using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Program
{
    static void Main() // 100/100
    {
        int[] collection = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] cmdArgs = command.Split();
            string evenOrOdd = string.Empty;

            string instructs = cmdArgs[0];
            switch (instructs)
            {
                case "exchange":
                    int index = int.Parse(cmdArgs[1]);
                    collection = ExchangeArreyElements(collection, index);
                    break;
                case "max":
                case "min":
                    evenOrOdd = cmdArgs[1];
                    FindMaxOrMinElement(collection, instructs, evenOrOdd);
                    break;
                case "first":
                case "last":
                    int count = int.Parse(cmdArgs[1]);
                    evenOrOdd = cmdArgs[2];
                    FindFirstOrLastElements(collection, instructs, count, evenOrOdd);
                    break;
            }
        }

        Console.WriteLine("[{0}]", string.Join(", ", collection));
    }

    private static void FindFirstOrLastElements(int[] arr, string firstOrLast, int count, string evenOrOdd)
    {
        if (count > arr.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        int evenOrOdParity = evenOrOdd == "even" ? 0 : 1;
        IEnumerable<int> evenOrOddElements = arr.Where(a => a % 2 == evenOrOdParity);

        int[] foundElements;
        if (firstOrLast == "first")
        {
            foundElements = evenOrOddElements
                .Take(count)
                .ToArray();
        }
        else
        {
            foundElements = evenOrOddElements
                .Reverse()
                .Take(count)
                .Reverse()
                .ToArray();
        }
        Console.WriteLine("[{0}]", string.Join(", ", foundElements));
    }

    private static void FindMaxOrMinElement(int[] arr, string maxOrMin, string evenOrOdd)
    {
        int evenOrOddElementsParity = evenOrOdd == "even" ? 0 : 1;
        int[] evenOrOddElements = arr.Where(a => a % 2 == evenOrOddElementsParity).ToArray();

        if (!evenOrOddElements.Any())
        {
            Console.WriteLine("No matches");
            return;
        }

        int maxOrMinElement = 0;
        if (maxOrMin == "max")
        {
            maxOrMinElement = evenOrOddElements.Max();
        }
        else
        {
            maxOrMinElement = evenOrOddElements.Min();
        }

        int maxOrMinElementIndex = Array.LastIndexOf(arr, maxOrMinElement);
        Console.WriteLine(maxOrMinElementIndex);
    }

    private static int[] ExchangeArreyElements(int[] arr, int index)
    {
        bool isValidIndex = index >= 0 && index < arr.Length;
        if (!isValidIndex)
        {
            Console.WriteLine("Invalid index");
            return arr;
        }

        IEnumerable<int> leftPart = arr.Take(index + 1);
        IEnumerable<int> rightPart = arr.Skip(index + 1);

        int[] combinedArray = rightPart.Concat(leftPart).ToArray();
        return combinedArray;
    }
}