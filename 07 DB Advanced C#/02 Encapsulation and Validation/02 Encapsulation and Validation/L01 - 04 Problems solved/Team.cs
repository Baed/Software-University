namespace L01___04_Problems_solved
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Team
    {
        private List<Person> _firstTeam;
        private List<Person> _reserveTeam;

        public Team()
        {

            this._firstTeam = new List<Person>();
            this._reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this._firstTeam.AsReadOnly(); }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this._reserveTeam.AsReadOnly(); }
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this._firstTeam.Add(person);
            }
            else
            {
                this._reserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"First team have {FirstTeam.Count} players");
            sb.AppendLine($"Reserve team have {ReserveTeam.Count} players");

            return sb.ToString().Trim();
        }
    }
}
