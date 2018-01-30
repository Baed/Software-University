public class FireBender : Bender
{
    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public double HeatAggression  { get; private set; }

    public override double GetTotalPower()
    {
        return this.HeatAggression * base.Power;
    }

    public override string ToString()
    {
        //var name = this.GetType().Name;
        //var index = name.IndexOf("Aggression");
        //name.Insert(index, " ");

        // "{basename}: {benderName}, Power: {power}, Heat Aggression: {aerialIntegrity}"
        return $"{base.ToString()}Heat Aggression: {this.HeatAggression:f2}";
    }
}

