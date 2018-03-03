using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04.Hornet_Armada
{
    class Program //70/100
    {
        static void Main(string[] args)
        {
            List<Legion> legionsList = Reader();

            ExecuteProgram(legionsList);
        }

        private static void ExecuteProgram(List<Legion> legionsList)
        {
            string[] cmdArgs = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmdArgs.Length > 1)
            {
                WriteActivity(legionsList, cmdArgs[0], cmdArgs[1]);
            }
            else
            {
                WriteSoldierTypes(legionsList, cmdArgs[0]);
            }
        }

        private static void WriteActivity(List<Legion> legionsList, string activity, string soldierType)
        {

            foreach (var legion in legionsList.Where(l => l.Activity < long.Parse(activity) && l.Soldier.Equals(soldierType))
                                              .OrderByDescending(l => l.SoldierCount)
                                              .ToList())
            {
                Console.WriteLine($"{legion.LegionName} -> {legion.SoldierCount}");
            }
        }

        private static void WriteSoldierTypes(List<Legion> legionsList, string soldierType)
        {
            foreach (var legion in legionsList.Where(l => l.Soldier.Equals(soldierType))
                                              .OrderByDescending(l => l.Activity)
                                              .ToList())

            {
                Console.WriteLine($"{legion.Activity} : {legion.LegionName}");
            }
        }

        private static List<Legion> Reader()
        {
            List<Legion> legionsList = new List<Legion>();

            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(new[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(cmdArgs[0]);
                string legionName = cmdArgs[1];
                string soldier = cmdArgs[2];
                long soldierCount = long.Parse(cmdArgs[3]);

                if (!legionsList.Any(l => l.LegionName.Contains(legionName)))
                {
                    Legion legion = new Legion(lastActivity, legionName, soldier, soldierCount);

                    legionsList.Add(legion);
                }
                else
                {
                    Legion legion = legionsList.FirstOrDefault(l => l.LegionName.Equals(legionName));

                     if (legion.Activity < lastActivity)
                    {
                        legion.Activity = lastActivity;
                    }

                    if (legionsList.Any(l => l.LegionName.Equals(legionName)
                                             && l.Soldier.Equals(soldier)))
                    {
                        legion = legionsList.FirstOrDefault(l => l.LegionName.Equals(legionName)
                                                                 && l.Soldier.Equals(soldier));
                        legion.SoldierCount += soldierCount;
                    }

                    else if (legionsList.Any(l => l.Activity >= lastActivity 
                                                  && l.LegionName.Equals(legionName)))
                    {
                        long highestActivityForCurrentLegion = legion.Activity;

                        legion = new Legion(highestActivityForCurrentLegion, legionName, soldier, soldierCount);

                        legionsList.Add(legion);
                    }

                }
            }

            return legionsList;
        }

        class Legion
        {
            public Legion(long activity, string legionName, string soldier, long soldierCount)
            {
                this.Activity = activity;
                this.LegionName = legionName;
                this.Soldier = soldier;
                this.SoldierCount = soldierCount;
            }

            public long Activity { get; set; }

            public string LegionName { get; set; }

            public string Soldier { get; set; }

            public long SoldierCount { get; set; }
        }
    }
}
