using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legionActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> soldiers = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long soldierCount = long.Parse(tokens[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, lastActivity);
                    soldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!soldiers[legionName].ContainsKey(soldierType))
                {
                     soldiers[legionName][soldierType] = 0; // No! -> soldiers[legionName].Add(soldierType, soldierCount);
                    //Alternative -> soldiers[legionName].Add(soldierType, 0);
                }

                if (legionActivity[legionName] < lastActivity)
                {
                    legionActivity[legionName] = lastActivity;
                }

                soldiers[legionName][soldierType] += soldierCount;
            }

            string[] conditions = Console.ReadLine().Split('\\');

            if (conditions.Length == 1) // output examples : 2
            {
                string soldierType = conditions[0];

                foreach (KeyValuePair<string, int> legion in legionActivity.OrderByDescending(l => l.Value))
                {
                    if (soldiers[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else
            {
                int searchedActivity = int.Parse(conditions[0]);
                string searchedSoldiers = conditions[1];

                foreach (KeyValuePair<string, Dictionary <string, long>>
                    legion in soldiers
                    .Where(l => l.Value.ContainsKey(searchedSoldiers))
                    .OrderByDescending(l => l.Value[searchedSoldiers]))
                {
                    if (legionActivity[legion.Key] < searchedActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[searchedSoldiers]}");
                    }
                }
            }
        }
    }
}
