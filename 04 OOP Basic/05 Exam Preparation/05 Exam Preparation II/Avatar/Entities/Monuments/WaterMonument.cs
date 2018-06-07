public class WaterMonument : Monument
{
    public WaterMonument(string name, int waterAffinity)
        : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    private int WaterAffinity  { get; }

    public override double GetMonumentBonus()
    {
        return this.WaterAffinity;
    }

    public override string ToString()
    {
        //var name = this.GetType().Name;
        //var index = name.IndexOf("Affinity");
        //name = name.Insert(index, " ");

        // "{basename}: {benderName}, Water Affinity: {aerialIntegrity}"
        return $"{base.ToString()}Water Affinity: {this.WaterAffinity}";
    }
}

