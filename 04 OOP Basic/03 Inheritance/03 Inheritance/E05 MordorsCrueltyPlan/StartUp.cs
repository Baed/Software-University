namespace E05_MordorsCrueltyPlan
{
    using E05_MordorsCrueltyPlan.Factories;
    using E05_MordorsCrueltyPlan.Models;
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var foodFactory = new FoodFactory();
            var moodFactory = new MoodFactory();

            var inputFood = Console.ReadLine()
                .Split(new[] { "\t", " ", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var gandalf = new Gandalf();

            foreach (var foodStr in inputFood)
            {
                Food food = foodFactory.GetFood(foodStr);
                gandalf.Eat(food);
            }

            int totalHappinessPoints = gandalf.GetHappinessPoints();

            Mood currentMood = moodFactory.GetMood(totalHappinessPoints);

            Console.WriteLine(totalHappinessPoints);
            Console.WriteLine(currentMood.ToString());
        }
    }
}
