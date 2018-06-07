public class EarthMonument : Monument
{
    public EarthMonument(string name, int earthAffinity) 
        : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    private int EarthAffinity { get; }

    public override double GetMonumentBonus()
    {
        return this.EarthAffinity;
    }

    public override string ToString()
    {
        //var name = this.GetType().Name;
        //var index = name.IndexOf("Affinity");
        //name = name.Insert(index, " ");

        // "{basename}: {benderName}, Earth Affinity: {aerialIntegrity}"
        return $"{base.ToString()}Earth Affinity: {this.EarthAffinity}";
    }
}

