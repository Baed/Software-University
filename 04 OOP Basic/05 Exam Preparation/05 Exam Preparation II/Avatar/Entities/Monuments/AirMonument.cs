public class AirMonument : Monument
{
    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    private int AirAffinity { get; }

    public override double GetMonumentBonus()
    {
        return this.AirAffinity;
    }

    public override string ToString()
    {
        //var name = this.GetType().Name;
        //var index = name.IndexOf("Affinity");
        //name = name.Insert(index, " ");

        // "{basename}: {benderName}, Air Affinity: {aerialIntegrity}"
        return $"{base.ToString()}Air Affinity: {this.AirAffinity}";
    }
}

