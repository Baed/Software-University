namespace E01_Cards
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        private string type;

        public TypeAttribute(string category, string description)
        {
            this.type = "Enumeration";
            this.Category = category;
            this.Description = description;
        }

        public string GetType { get { return this.type; } }

        public string Category { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"Type = {this.type}, Description = {this.Description}";
        }
    }
}