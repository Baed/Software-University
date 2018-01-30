namespace E05.Pizza_Calories
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split(' ');
                try
                {
                    switch (tokens[0])
                    {
                        case "Dough":
                            var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                            Console.WriteLine($"{dough.GetDoughCalories():f2}");
                            break;
                        case "Topping":
                            var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                            Console.WriteLine($"{topping.GetToppingCalories():f2}");
                            break;
                        case "Pizza":
                            MakePizza(tokens);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

            }
        }

        private static void MakePizza(string[] tokens)
        {
            var numOfTopping = int.Parse(tokens[2]);

            var pizza = new Pizza(tokens[1], numOfTopping);

            var doughInfo = Console.ReadLine().Split(' ');

            var dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));

            pizza.Dough = dough;

            for (int i = 0; i < numOfTopping; i++)
            {
                var topInfo = Console.ReadLine().Split(' ');

                var topping = new Topping(topInfo[1], double.Parse(topInfo[2]));

                pizza.AddTopping(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.GetPizzaCalories():f2} Calories.");
        }
    }
}
