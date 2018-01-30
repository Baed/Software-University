namespace E03_WildFarms
{
    using Factories;
    using Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var animalTokens = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var foodTokens = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                Animal animal = AnimalFactory.GetAnimal(animalTokens);
                Food food = FoodFactory.GetFood(foodTokens);

                Console.WriteLine(animal.MakeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(animal);
            }
        }
    }
}
