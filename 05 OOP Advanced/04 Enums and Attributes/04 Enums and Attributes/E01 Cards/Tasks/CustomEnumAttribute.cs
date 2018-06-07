namespace E01_Cards.Tasks
{
    using System;

    internal class CustomEnumAttribute
    {
        public CustomEnumAttribute()
        {
        }

        public void PrintAttributes(string input)
        {
            Type type = null;

            if (input == "Rank")
            {
                GetAttributeType(typeof(Rank));
            }
            else
            {
                GetAttributeType(typeof(Suit));
            }
        }

        public static void GetAttributeType(Type type)
        {
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine(attributes[0]);
        }
    }
}