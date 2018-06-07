using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using E04_Pizza_Calories.Models;

namespace E04_Pizza_Calories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Pizza pizza = Reader();

            Writer(pizza);
        }

        private static void Writer(Pizza pizza)
        {
            Console.WriteLine($"{pizza.Name} - {pizza.CalculateCalories():f2}.");
        }

        private static Pizza Reader()
        {
            Pizza pizza = new Pizza();

            try
            {
                string inputPizzaType = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];

                pizza = new Pizza(inputPizzaType);

                var inputDoughType = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var doughType = inputDoughType[1];
                var doughBakingTechnique = inputDoughType[2];
                var doughWeight = double.Parse(inputDoughType[3]);

                Dough dough = new Dough(doughType, doughBakingTechnique, doughWeight);

                pizza.Dough = dough;

                string inputToppingType;
                while ((inputToppingType = Console.ReadLine()) != "End")
                {
                    var toppingArgs = inputToppingType.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var toppingType = toppingArgs[1];
                    var toppingWeight = double.Parse(toppingArgs[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // Environment.Exit(Environment.ExitCode);
            }

            return pizza;
        }
    }
}
