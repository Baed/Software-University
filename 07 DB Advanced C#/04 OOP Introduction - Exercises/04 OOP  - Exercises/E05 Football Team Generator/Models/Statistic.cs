using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Football_Team_Generator.Models
{
    public class Statistic
    {
        private string _type;
        private int _value;

        public Statistic(string type, int value)
        {
            this.Type = type;
            this.Value = ValidateValue(type, value);
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public int Value
        {
            get => _value;

            private set
            {
                this._value = value;
            }
        }

        private static int ValidateValue(string type, int value)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{type} should be between 0 and 100.");
            }

            return value;
        }
    }
}
