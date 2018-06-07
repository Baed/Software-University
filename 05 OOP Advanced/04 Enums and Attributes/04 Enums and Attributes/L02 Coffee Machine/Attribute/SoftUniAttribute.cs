using System;

public class SoftUniAttribute : Attribute
{
    private string name;

    public SoftUniAttribute(string name)
    {
        this.name = name;
    }

    public string Name { get; }
}