using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Football_Team_Generator.Models
{
    public class Team
    {
        private string _name;
        private IList<Player> _players;

        public Team(string name)
        {
            this.Name = name;
            this._players = new List<Player>();
        }

        public string Name
        {
            get => _name;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                _name = value;
            }
        }

        private IList<Player> Players
        {
            get => _players;

            set
            {
                _players = value;
            }
        }

        public int Rating
        {
            get
            {
                if (this.Players.Count == 0)
                {
                    return 0;
                }

                return (int)Math.Round(Players.Select(p => p.Rating).Average());
            }
        }

        public void AddPlayers(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayers(string playerName)
        {

            if (!this.Players.Any(p => p.Name.Equals(playerName)))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            Player player = this.Players.FirstOrDefault(p => p.Name.Equals(playerName));

            this.Players.Remove(player);
        }
    }
}
