
public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Batteries = batteries;
    }

    public string Model { get; private set; }

    public string Color { get; private set; }

    public int Batteries { get; private set; }

    public string Start()
    {
        return "Engine start";
    }
    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

