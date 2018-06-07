namespace E05_MordorsCrueltyPlan.Models
{
    public abstract class Food
    {
        protected Food(int happinessPoints)
        {
            this.HappinessPoints = happinessPoints;
        }

        public int HappinessPoints { get; set; }

        public int GetHappinessPoints()
        {
            return this.HappinessPoints;
        }
    }
}
