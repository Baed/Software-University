public abstract class Bender
{
    public string Name { get; private set; }

    public int Power { get; private set; }

    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public abstract double GetTotalPower();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Bender");
        name = name.Insert(index, " ");

        //	"Air Bender: {benderName}, Power: {power}, "... "Aerial Integrity: {aerialIntegrity}"
        return $"###{name}: {this.Name}, Power: {this.Power}, ";
    }
}

