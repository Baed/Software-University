public class AirBender : Bender
{
    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity  { get; private set; }

    public override double GetTotalPower()
    {
        return this.AerialIntegrity * base.Power;
    }

    public override string ToString()
    {
       // var name = this.GetType().Name;
       // var index = name.IndexOf("Integrity");
       // name = name.Insert(index, " ");

        // "{basename}: {benderName}, Power: {power}, Aerial Integrity: {aerialIntegrity}"
        return $"{base.ToString()}Aerial Integrity: {this.AerialIntegrity:f2}"; 
    }
}

