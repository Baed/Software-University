using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> goalsData = new Dictionary<string, long>();

            Dictionary<string, long> tournamentData = new Dictionary<string, long>();

            string key = Console.ReadLine();
            int keycount = key.Length;

            Regex regex = new Regex($"(?:([{key}]" + "{" + $"{keycount}" + @"}))([a-zA-Z]*)\1.*\1([a-zA-Z]*)\1.*[^\d](\d+:\d+)");

            string command;
            while ((command = Console.ReadLine()) != "final")
            {
                Match match = regex.Match(command);

                string teamFirst = string.Join("", match.Groups[2].Value.ToUpper().Reverse());
                string teamSecond = string.Join("", match.Groups[3].Value.ToUpper().Reverse());
                string[] result = match.Groups[4].Value.Split(':');
                long goalsFirst = long.Parse(result[0]);
                long goalsSecond = long.Parse(result[1]);

                if (!goalsData.ContainsKey(teamFirst))
                {
                    goalsData.Add(teamFirst, goalsFirst);
                }
                else
                {
                    goalsData[teamFirst] += goalsFirst;
                }
                if (!goalsData.ContainsKey(teamSecond))
                {
                    goalsData.Add(teamSecond, goalsSecond);
                }
                else
                {
                    goalsData[teamSecond] += goalsSecond;
                }

                if (goalsFirst > goalsSecond)
                {
                    if (!tournamentData.ContainsKey(teamFirst))
                    {
                        tournamentData.Add(teamFirst, 3);
                    }
                    else
                    {
                        tournamentData[teamFirst] += 3;
                    }
                    if (!tournamentData.ContainsKey(teamSecond))
                    {
                        tournamentData.Add(teamSecond, 0);
                    }
                    else
                    {
                        tournamentData[teamSecond] += 0;
                    }
                }
                else if (goalsFirst < goalsSecond)
                {
                    if (!tournamentData.ContainsKey(teamFirst))
                    {
                        tournamentData.Add(teamFirst, 0);
                    }
                    else
                    {
                        tournamentData[teamFirst] += 0;
                    }
                    if (!tournamentData.ContainsKey(teamSecond))
                    {
                        tournamentData.Add(teamSecond, 3);
                    }
                    else
                    {
                        tournamentData[teamSecond] += 3;
                    }
                }
                else // ==
                {
                    if (!tournamentData.ContainsKey(teamFirst))
                    {
                        tournamentData.Add(teamFirst, 1);
                    }
                    else
                    {
                        tournamentData[teamFirst] += 1;
                    }

                    if (!tournamentData.ContainsKey(teamSecond))
                    {
                        tournamentData.Add(teamSecond, 1);
                    }
                    else
                    {
                        tournamentData[teamSecond] += 1;
                    }
                }
            }

            Console.WriteLine("League standings:");

            int place = 1;
            foreach (var kvp in tournamentData.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{place}. {kvp.Key} {kvp.Value}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var kvp in goalsData.OrderByDescending(g => g.Value).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");  
            }

        }
    }
}
