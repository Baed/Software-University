using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E04_Pizza_Calories.Models;

namespace E04_Pizza_Calories
{
    public class Pizza
    {
        private string _name;
        private Dough _dough;
        private IList<Topping> _toppings;

        public Pizza()
        {

        }

        public Pizza(string name)
        : this()
        {
            this.Name = name;
            this.Dough = _dough;
            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                _name = value;
            }
        }

        public Dough Dough
        {
            get => _dough;
            set => _dough = value;
        }

        public IList<Topping> Toppings
        {
            get => this._toppings as IList<Topping>;

            set
            {
                if (value.Count >= 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this._toppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this._toppings.Add(topping);
        }

        public double CalculateCalories()
        {
            double sumOfCalories = this.Dough.CalculateCalories() + this._toppings.Sum(t => t.CalculateCalories());

            return sumOfCalories;
        }
    }
}
