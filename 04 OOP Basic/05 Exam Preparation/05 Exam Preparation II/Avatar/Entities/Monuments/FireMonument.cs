public class FireMonument : Monument
{
    public FireMonument(string name, int fireAffinity) 
        : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    private int FireAffinity  { get; }

    public override double GetMonumentBonus()
    {
        return this.FireAffinity;
    }

    public override string ToString()
    {
        //var name = this.GetType().Name;
        //var index = name.IndexOf("Affinity");
        //name = name.Insert(index, " ");

        // "{basename}: {benderName}, Fire Affinity: {aerialIntegrity}"
        return $"{base.ToString()}Fire Affinity: {this.FireAffinity}";
    }
}

