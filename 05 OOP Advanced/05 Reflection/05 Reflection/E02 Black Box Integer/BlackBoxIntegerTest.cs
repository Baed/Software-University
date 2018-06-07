namespace E02_Black_Box_Integer
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTest
    {
        public static void Main(string[] args)
        {
            Type blackBoxType = typeof(BlackBoxInt);
            BlackBoxInt blackBoxActivator = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);
            // get default ctor

            // ConstructorInfo blackBoxCtor = blackBoxType
            //     .GetConstructor(
            //     BindingFlags.Instance
            //     | BindingFlags.NonPublic
            //     , Type.DefaultBinder
            //     , new Type[] {}
            //     , null);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split('_');

                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                blackBoxType
                    .GetMethod(
                            methodName,
                            BindingFlags.Instance |
                            BindingFlags.NonPublic)
                    .Invoke(blackBoxActivator, new object[] { value });

                string innerStateValue = blackBoxType
                    .GetFields(
                            BindingFlags.Instance |
                            BindingFlags.NonPublic)
                    .First()
                    .GetValue(blackBoxActivator)
                    .ToString();

                Console.WriteLine(innerStateValue);
            }
        }
    }
}