namespace E05.Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int numberOfToppings;

        private const int MaxRange = 10;
        private const int MinRange = 0;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
            this.NumberOfToppings = numberOfToppings;
        }

        public Dough Dough
        {
            set { this.dough = value; }
        }

        public int NumberOfToppings
        {
            get { return this.numberOfToppings; }
            set
            {
                if (value < MinRange || value > MaxRange)
                {
                    throw new ArgumentException($"Number of toppings should be in range [{MinRange}..{MaxRange}].");
                }
                this.numberOfToppings = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double GetPizzaCalories()
        {
           return this.dough.GetDoughCalories() + this.toppings.Sum(t => t.GetToppingCalories());
        }
    }
}
