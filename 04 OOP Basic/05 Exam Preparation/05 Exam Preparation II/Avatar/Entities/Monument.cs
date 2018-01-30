public abstract class Monument
{
    public string Name { get; private set; }

    protected Monument(string name)
    {
        this.Name = name;
    }

    public abstract double GetMonumentBonus();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Monument");
        name = name.Insert(index, " ");

        //	"Air Monument: {benderName}, "... "Aerial Integrity: {aerialIntegrity}"
        return $"###{name}: {this.Name}, ";
    }
}
