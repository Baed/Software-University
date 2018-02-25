using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pizza_Calories
{
    public class Dough
    {
        private const int Calories = 2;
        private readonly Dictionary<string, double> TypesMods = new Dictionary<string, double>
        {
            { "white",  1.5 },
            { "wholegrain", 1.0}
        };
        private readonly Dictionary<string, double> BakingTechniquesMods = new Dictionary<string, double>
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };
        private double _weight;
        private string _bakingTechnique;
        private string _type;

        public Dough(string type, string bakingTechnique, double weight)
        {
            this.Type = type;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string Type
        {
            get { return _type;}
            set
            {
                if (!TypesMods.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                _type = value;
            }
        }

        public string BakingTechnique
        {
            get { return _bakingTechnique; }
            set
            {
                if (!BakingTechniquesMods.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                _bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                _weight = value;
            }
        }

        public double CalculateCalories()
        {
            double sumOfCalories = Calories * this.Weight * this.TypesMods[this.Type.ToLower()] * this.BakingTechniquesMods[this.BakingTechnique.ToLower()];

            return sumOfCalories;
        }
    }
}
