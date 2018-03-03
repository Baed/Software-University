using System;
using System.Linq;
using System.Collections.Generic;


public sealed class Legion
{
    public Legion(string name, long activity)
    {
        this.Name = name;
        this.Activity = activity;
        this.Soldiers = new Dictionary<string, long>();
    }

    public string Name { get; private set; }

    public long Activity { get; set; }

    public Dictionary<string, long> Soldiers { get; set; }

    public override string ToString()
    {
        return $"{this.Activity} : {this.Name}";
    }
}

class Startup
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var legionsData = new Dictionary<string, Legion>();

        for (int i = 0; i < n; i++)
        {
            string[] cmdArgs = Console.ReadLine().Split(new[] { '=', ' ', ':', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            long lastActivity = long.Parse(cmdArgs[0]);
            string legionName = cmdArgs[1];
            string soldierType = cmdArgs[2];
            long soldierCount = long.Parse(cmdArgs[3]);

            if (legionsData.ContainsKey(legionName))
            {
                if (legionsData[legionName].Soldiers.ContainsKey(soldierType))
                {
                    legionsData[legionName].Soldiers[soldierType] += soldierCount;
                }
                else
                {
                    legionsData[legionName].Soldiers.Add(soldierType, soldierCount);
                }

                if (legionsData[legionName].Activity < lastActivity)
                {
                    legionsData[legionName].Activity = lastActivity;
                }
            }
            else
            {
                legionsData.Add(legionName, new Legion(legionName, lastActivity));
                legionsData[legionName].Soldiers.Add(soldierType, soldierCount);
            }
        }

        string[] outputFormat = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.None);

        if (outputFormat.Length > 1)
        {
            long activity = long.Parse(outputFormat[0]);
            string soldierType = outputFormat[1];
            var foundedSoldiers = new Dictionary<string, long>();

             foreach (var legion in legionsData)
             {
                 if (legion.Value.Activity >= activity)
                 {
                     continue;
                 }
            
                 foreach (var soldier in legion.Value.Soldiers)
                 {
                     if (soldier.Key == soldierType)
                     {
                         foundedSoldiers.Add(legion.Key, soldier.Value);
                     }
                 }
             }

            foreach (var item in foundedSoldiers.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
        else
        {
            var foundWithType = legionsData.Where(x => x.Value.Soldiers.Keys.Contains(outputFormat[0]));

            foreach (var soldier in foundWithType.OrderByDescending(x => x.Value.Activity))
            {
                Console.WriteLine(soldier.Value);
            }
        }
    }
}

