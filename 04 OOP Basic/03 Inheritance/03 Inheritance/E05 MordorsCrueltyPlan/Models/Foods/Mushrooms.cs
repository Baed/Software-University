namespace E05_MordorsCrueltyPlan.Models.Foods
{

    public class Mushrooms : Food
    {
        private const int HappinessPoints = -10;

        public Mushrooms() : base(HappinessPoints)
        {
        }
    }
}
