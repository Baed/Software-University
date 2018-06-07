using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02_Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                string[] tokens = input.Split().ToArray();

                string trainName = tokens[0];

                if (!data.ContainsKey(trainName))
                {
                    data[trainName] = new Dictionary<string, int>();
                }
                if (tokens[1].Trim() == "->" && tokens.Length == 3)
                {
                    string otherTrainName = tokens[2];
                    Dictionary<string, int> otherData = data[otherTrainName];

                    foreach (var key in otherData)
                    {
                        data[trainName].Add(key.Key, key.Value);
                    }
                    data.Remove(otherTrainName);

                }
                if (tokens[1].Trim() == "->" && tokens.Length > 3)   // zapisavame sashtite vagoni na drugiq i mahame
                {
                    string wagonName = tokens[2];
                    int wagonPower = int.Parse(tokens[4]);

                    data[trainName].Add(wagonName, wagonPower); ;
                }

                if (tokens[1].Trim() == "=")  // zapisavame sashtite vagoni na drugiq
                {
                    string otherTrainName = tokens[2];
                    Dictionary<string, int> otherData = data[otherTrainName];

                    data[trainName].Clear();

                    foreach (var wagon in otherData)
                    {
                        data[trainName].Add(wagon.Key, wagon.Value);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var trainName in data.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine("Train: {0}", trainName.Key);

                foreach (var wagon in trainName.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("###{0} - {1}", wagon.Key, wagon.Value);
                }
            }
        }
    }
}
