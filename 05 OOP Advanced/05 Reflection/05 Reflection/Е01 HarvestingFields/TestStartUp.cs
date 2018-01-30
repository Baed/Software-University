namespace Е01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class TestStartUp
    {
        public static void TestMain(string[] args)
        {
            Type harvestingFieldsType = typeof(HarvestingFields);

            FieldInfo[] harverstingField = harvestingFieldsType
                .GetFields(
                            BindingFlags.Public |
                            BindingFlags.NonPublic |
                            BindingFlags.Instance);

            // example for how to write a syntaxis of function without parameters to put in.
            // func = () =>
            Func<FieldInfo[]> func = () => harverstingField.Where(f => f.IsPrivate).ToArray();

            Dictionary<string, Func<FieldInfo[]>> accModFilters = new Dictionary<string, Func<FieldInfo[]>>()
            {
                { "private", () => harverstingField.Where(f => f.IsPrivate).ToArray() },
                { "protected", () => harverstingField.Where(f => f.IsFamily).ToArray() },
                { "public", () => harverstingField.Where(f => f.IsPublic).ToArray() },
                { "all", () => harverstingField },
            };

            string requestedAccMod;
            while ((requestedAccMod = Console.ReadLine()) != "HARVEST")
            {
                accModFilters[requestedAccMod]() // () --> because have a Func
                     .Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                     .ToList()
                     .ForEach(r => Console.WriteLine(r.Replace("family", "protected")));
            }
        }
    }
}