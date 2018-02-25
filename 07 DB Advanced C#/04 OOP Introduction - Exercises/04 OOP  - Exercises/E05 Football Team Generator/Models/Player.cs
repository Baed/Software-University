using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Football_Team_Generator.Models
{
    public class Player
    {
        private string _name;
        private IList<Statistic> _statistics;

        public Player(string name)
        {
            this.Name = name;
            this._statistics = new List<Statistic>();
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

        private IList<Statistic> Statistics
        {
            get => _statistics;

            set
            {
                _statistics = value; 

            }
        }

        public int Rating
        {
            get => (int)Math.Round(Statistics.Average(s => s.Value));
        }

        public void AddStatistics(Statistic statistic)
        {
            this.Statistics.Add(statistic);
        }
    }
}
