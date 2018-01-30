using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate)]
public class SoftUniNastedAttribute : SoftUniAttribute
{
    public SoftUniNastedAttribute(string name)
        : base(name)
    {
    }
}