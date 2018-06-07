namespace E05_MordorsCrueltyPlan.Factories
{
    using E05_MordorsCrueltyPlan.Models;
    using E05_MordorsCrueltyPlan.Models.Moods;

    public class MoodFactory
    {
        public Mood GetMood(int happinessPoints)
        {
            if (happinessPoints < -5)
            {
                return new Angry();
            }
            if (happinessPoints <= 0)
            {
                return new Sad();
            }
            if (happinessPoints <= 15)
            {
                return new Happy();
            }

            return new JavaScript();
        }
    }
}
