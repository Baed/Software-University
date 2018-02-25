using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pizza_Calories.Models
{
    public class Topping
    {
        private const int Calories = 2;
        private readonly Dictionary<string, double> TypesMods = new Dictionary<string, double>()
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };
        private double _weight;
        private string _type;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => _type;

            set
            {
                if (!TypesMods.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                _type = value;
            }
        }
        

        public double Weight
        {
            get { return _weight; }

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                _weight = value;
            } 
        }

        public double CalculateCalories()
        {
            double sumOfCalories = Calories * this.Weight * this.TypesMods[this.Type.ToLower()];

            return sumOfCalories;
        }
    }
}
