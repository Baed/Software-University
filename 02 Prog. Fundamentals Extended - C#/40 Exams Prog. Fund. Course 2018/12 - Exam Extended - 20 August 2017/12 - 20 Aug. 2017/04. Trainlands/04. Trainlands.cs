using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            string command;
            while ((command = Console.ReadLine()) != "It's Training Men!")
            {
                string[] cmdArgs = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string trainNames = cmdArgs[0];

                if (!data.ContainsKey(trainNames))
                {
                    data.Add(trainNames, new Dictionary<string, int>());
                }

                if (cmdArgs.Length == 3)
                {
                    if (cmdArgs[1] == "->")
                    {
                        string otherTrainNames = cmdArgs[2];
                        Dictionary<string, int> otherData = data[otherTrainNames];

                        foreach (var trainName in otherData)
                        {
                            data[trainNames].Add(trainName.Key, trainName.Value);
                        }

                        data.Remove(otherTrainNames);
                    }

                    if (cmdArgs[1] == "=")
                    {
                        string otherTrainNames = cmdArgs[2];
                        Dictionary<string, int> otherData = data[otherTrainNames];

                        data[trainNames].Clear();

                        foreach (var trainName in otherData)
                        {
                            data[trainNames].Add(trainName.Key, trainName.Value);
                        }
                    }
                }
                else  
                {
                    string wagonName = cmdArgs[2];
                    int powerValue = int.Parse(cmdArgs[4]);

                    data[trainNames].Add(wagonName, powerValue);
                }
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
