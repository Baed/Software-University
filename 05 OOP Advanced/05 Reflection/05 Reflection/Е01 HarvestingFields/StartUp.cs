namespace Е01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Type harvestingFieldsType = typeof(HarvestingFields);

            FieldInfo[] harverstingField = harvestingFieldsType
                .GetFields(
                            BindingFlags.Public |
                            BindingFlags.NonPublic |
                            BindingFlags.Instance);

            FieldInfo[] getherdFields;

            string requestedAccMod;
            while ((requestedAccMod = Console.ReadLine()) != "HARVEST")
            {
                switch (requestedAccMod)
                {
                    case "private":
                        getherdFields = harverstingField.Where(f => f.IsPrivate).ToArray();
                        break;

                    case "protected":
                        getherdFields = harverstingField.Where(f => f.IsFamily).ToArray();
                        break;

                    case "public":
                        getherdFields = harverstingField.Where(f => f.IsPublic).ToArray();
                        break;

                    case "all":
                        getherdFields = harverstingField;
                        break;

                    default:
                        getherdFields = null;
                        break;
                }

                string[] result = getherdFields
                    .Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                    .ToArray();

                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));
            }
        }
    }
}