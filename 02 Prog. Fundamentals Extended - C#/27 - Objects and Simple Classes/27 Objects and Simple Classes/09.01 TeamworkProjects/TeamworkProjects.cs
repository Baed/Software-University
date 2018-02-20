using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teamList = new List<Team>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split('-').ToArray();

                Team team = new Team();
                team.TeamName = inputLine[1];
                team.Creator = inputLine[0];
                team.Members = new List<string>();

                if (!teamList.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    if (!teamList.Select(x => x.Creator).Contains(team.Creator))
                    {
                        teamList.Add(team);
                        Console.WriteLine("Team {0} has been created by {1}!", inputLine[1], inputLine[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} cannot create another team!", team.Creator);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", team.TeamName);
                }
            }

            string inputCommand;
            while ((inputCommand = Console.ReadLine()) != "end of assignment")
            {
                var tokens = inputCommand.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string newUser = tokens[0];
                string newTeam = tokens[1];

                if (!teamList.Select(x => x.TeamName).Contains(newTeam))
                {
                    Console.WriteLine("Team {0} does not exist!", newTeam);
                }
                else if (teamList.Select(x => x.Members).Any(x => x.Contains(newUser)) || teamList.Select(x => x.Creator).Contains(newUser))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", newUser, newTeam);
                }
                else
                {
                    int teamToJoinIndex = teamList.FindIndex(x => x.TeamName == newTeam);
                    teamList[teamToJoinIndex].Members.Add(newUser);
                }

            }

            foreach (var team in teamList.
                                        OrderByDescending(x => x.Members.Count).
                                        ThenBy(x => x.TeamName).
                                        Where(x => x.Members.Count > 0))
            {
                Console.WriteLine($"{team.TeamName}");

                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in teamList
                                        .OrderBy(x => x.TeamName)
                                        .Where(x => x.Members.Count == 0))
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}