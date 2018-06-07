using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E05_Football_Team_Generator.Models;

namespace E05_Football_Team_Generator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] statNames = new string[] { "Endurance", "Sprint", "Dribble", "Passing", "Shooting" };

            List<Team> teams = new List<Team>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var cmdArgs = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (cmdArgs[0])
                    {
                        case "Team":
                            teams.Add(new Team(cmdArgs[1]));
                            break;
                        case "Add":
                            Team team = FindAndGetTeam(teams, cmdArgs[1]);
                            Player player = GetPlayer(cmdArgs, statNames);
                            team.AddPlayers(player);
                            break;
                        case "Remove":
                            team = FindAndGetTeam(teams, cmdArgs[1]);
                            team.RemovePlayers(cmdArgs[2]);
                            break;
                        case "Rating":
                            team = FindAndGetTeam(teams, cmdArgs[1]);
                            Console.WriteLine($"{team.Name} - {team.Rating}");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static Player GetPlayer(string[] cmdArgs, string[] statNames)
        {
            Player player = new Player(cmdArgs[2]);

            for (int i = 0; i < statNames.Length; i++)
            {
                Statistic statistic = new Statistic(statNames[i], int.Parse(cmdArgs[3 + i]));

                player.AddStatistics(statistic);
            }

            return player;
        }

        private static Team FindAndGetTeam(List<Team> teams, string teamName)
        {
            Team team = teams.Find(t => t.Name.Equals(teamName));
            //Team team = teams.FirstOrDefault(t => t.Name.Equals(teamName));

            if (!teams.Any(t => t.Name.Equals(teamName))) // team == null
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }

            return team;
        }
    }
}
