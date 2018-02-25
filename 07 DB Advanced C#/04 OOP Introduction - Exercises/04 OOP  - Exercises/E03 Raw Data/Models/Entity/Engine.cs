using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Raw_Data.Models.Entity
{
    public class Engine
    {
        private int _speed;
        private int _power;

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed
        {
            get => _speed;
            set => _speed = value;
        }

        public int Power
        {
            get => _power;
            set => _power = value;
        }
    }
}
