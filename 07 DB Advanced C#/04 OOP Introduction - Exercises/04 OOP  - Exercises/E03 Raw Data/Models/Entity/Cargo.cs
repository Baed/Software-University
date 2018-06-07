using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Raw_Data.Models.Entity
{
    public class Cargo
    {
        private int _weight;
        private string _type;

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }
    }
}
