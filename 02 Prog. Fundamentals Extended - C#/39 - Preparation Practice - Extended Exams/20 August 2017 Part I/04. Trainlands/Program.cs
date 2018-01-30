using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                string[] tokens = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string trainNames = tokens[0];

                if (!data.ContainsKey(trainNames))
                {
                    data.Add(trainNames, new Dictionary<string, int>());
                }

                if (tokens.Length == 3)     // tokens items = 3
                {
                    if (tokens[1] == "->")    // contains separator
                    {
                        string otherTrainNames = tokens[2];     // {OtherTrainName} = token with item = 3
                        Dictionary<string, int> otherData = data[otherTrainNames];      // create {OtherTrain} from {Train} with wagons and power

                        foreach (var trainName in otherData)
                        {
                            data[trainNames].Add(trainName.Key, trainName.Value);
                        }
                        data.Remove(otherTrainNames);  // remove it to next iteration
                    }
                    if (tokens[1] == "=")
                    {
                        string otherTrainNames = tokens[2];
                        Dictionary<string, int> otherData = data[otherTrainNames];      // create {OtherTrain} from {Train} with wagons and power

                        data[trainNames].Clear(); // clear to next Key

                        foreach (var trainName in otherData)
                        {
                            data[trainNames].Add(trainName.Key, trainName.Value);
                        }
                    }
                }
                else  // tokens.Length > 3
                {
                    string wagonName = tokens[2];          // tokens[3] == :
                    int powerValue = int.Parse(tokens[4]);

                    data[trainNames].Add(wagonName, powerValue);
                }
                input = Console.ReadLine();
            }
    
            foreach (var trainName in data.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine($"Train: {trainName.Key}");

                foreach (var wagonName in trainName.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagonName.Key} - {wagonName.Value}");
                }
            }
        }
    }
}
