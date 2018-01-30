using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    Dictionary<string, Nation> nations;
    private List<string> wars;

    public NationsBuilder() //Create ctor
    {
        this.nations = new Dictionary<string, Nation>()
        {
            { "Air", new Nation() },
            { "Earth", new Nation() },
            { "Fire", new Nation() },
            { "Water", new Nation() },
        };
        this.wars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        //  Benders Commands
        //  Prime Bender Commands
        //  Parameters – type(string), name(string), power(int), secondaryParameter(floating - point number).

        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secondParam = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddBender(new AirBender(name, power, secondParam));
                break;
            case "Fire":
                this.nations[type].AddBender(new FireBender(name, power, secondParam));
                break;
            case "Water":
                this.nations[type].AddBender(new WaterBender(name, power, secondParam));
                break;
            case "Earth":
                this.nations[type].AddBender(new EarthBender(name, power, secondParam));
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        // Monuments Command:
        //  Prime: Parameters – type(string), name(string), affinity(int).
        //  Creates a Monument of the given type, with the given parameters.
        //  The type will either be “Air”, “Water”, “Fire” or “Earth”.

        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddMonument(new AirMonument(name, affinity));
                break;
            case "Fire":
                this.nations[type].AddMonument(new FireMonument(name, affinity));
                break;
            case "Water":
                this.nations[type].AddMonument(new WaterMonument(name, affinity));
                break;
            case "Earth":
                this.nations[type].AddMonument(new EarthMonument(name, affinity));
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        return $"{nationsType} Nation" + Environment.NewLine + this.nations[nationsType].ToString(); //get override ToString() metod in class Nation and him inheritance classes
    }

    public void IssueWar(string nationsType)
    {
        this.wars.Add(nationsType);
        var winner = nations.Max(n => n.Value.GetTotalPoints());

        foreach (var nation in nations)
        {
            if (nation.Value.GetTotalPoints() != winner)
            {
                nation.Value.KillYourself();
            }
        }
    }
    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < this.wars.Count; i++)
        {
            sb.AppendLine($"War {i + 1} issued by {this.wars[i]}");
        }
        return sb.ToString().Trim();
    }
}

