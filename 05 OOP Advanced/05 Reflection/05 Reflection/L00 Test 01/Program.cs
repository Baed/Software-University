using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace L00_Test_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type listType = typeof(List<>);

            Console.WriteLine(listType.Name);
            Console.WriteLine(listType.FullName);

            Console.WriteLine(new string('-', 20)); // =======================================

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type[] allTypes = currentAssembly.GetTypes();

            foreach (Type type in allTypes)
            {
                Console.WriteLine(type.Name);
                // output: Program
                // output: SimpleClass

                Type[] interfaces = type.GetInterfaces();

                foreach (Type interfacee in interfaces)
                {
                    Console.WriteLine(interfacee.FullName);
                    // output: System.IComparable`1[[System.Int32, mscorlib, Version = 4.0.0.0, Culture = neutral
                }
            }

            Console.WriteLine(new string('-', 20)); // =======================================

            Type simpleClassType = typeof(SimpleClass);
            SimpleClass scInstance = (SimpleClass)Activator.CreateInstance(simpleClassType);

            // scInstance.SomeProp = "New instance Text"; // get property of SimpleClass
            // Console.WriteLine(scInstance.SomeProp);

            SimpleClass newScInstance = (SimpleClass)Activator.CreateInstance(simpleClassType, "Another Text");
            Console.WriteLine(newScInstance.SomeProp);

            Console.WriteLine(new string('-', 20)); // =======================================

            FieldInfo fieldiInfo = simpleClassType.GetField("simpleInt", BindingFlags.Instance | BindingFlags.NonPublic); // because is private

            Console.WriteLine(fieldiInfo.Name);
            // output: simpleInt
            Console.WriteLine(fieldiInfo.FieldType);
            // output: System.Int32
            Console.WriteLine(fieldiInfo.Attributes);
            // output: Private

            Console.WriteLine(new string('-', 20)); // =======================================

            FieldInfo[] secFieldiInfo = simpleClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static); // because is private

            foreach (var field in secFieldiInfo)
            {
                if (field.IsFamily) // IsPrivate..
                {
                    Console.WriteLine(field.Name);
                    // output: anotherSimpleString
                    Console.WriteLine(field.FieldType);
                    // output: System.Int32
                    Console.WriteLine(field.Attributes);
                    // output: Private
                }
            }

            Console.WriteLine(new string('-', 20)); // =======================================

            Type testType = typeof(SimpleClass);

            SimpleClass testInstance = (SimpleClass)Activator.CreateInstance(testType);

            FieldInfo[] testFieldInfo = testType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

            foreach (FieldInfo field in testFieldInfo)
            {
                if (field.Name == "simpleString")
                {
                    field.SetValue(testInstance, "SetNewValueOfstring");
                }
            }

            //FieldInfo wantedField = testType.GetField("simpleString", BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo wantedField = testFieldInfo.FirstOrDefault(f => f.Name == "simpleString");

            Console.WriteLine(wantedField.GetValue(testInstance));

            Console.WriteLine(new string('-', 20)); // =======================================

            Type newtestType = typeof(SimpleClass);

            Type[] ctorParamsTypes = { typeof(string) };

            ConstructorInfo[] constructorInfo = newtestType.GetConstructors(); // .GetConstructors(new Type[] { });

            // SimpleClass scSecondInstance = (SimpleClass)constructorInfo.Invoke(new Object[] { });
            // Console.WriteLine(scSecondInstance.SomeProp);

            foreach (var ctor in constructorInfo)
            {
                ParameterInfo[] ctorParams = ctor.GetParameters();

                foreach (var param in ctorParams)
                {
                    Console.WriteLine(param.Name);
                    Console.WriteLine(param);
                }
            }

            Console.WriteLine(new string('-', 20)); // =======================================

            //Type classType = typeof(StringBuilder);

            MethodInfo findChunkMetod = typeof(StringBuilder)
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(m => m.Name == "FindChunkForIndex");

            Console.WriteLine(findChunkMetod.ReturnType);

            StringBuilder sb = new StringBuilder();

            sb.Append("Text Text Text Text Text Text");

            StringBuilder returnInfo = (StringBuilder)findChunkMetod.Invoke(sb, new object[] { 5 });

            Console.WriteLine(returnInfo);
        }
    }
}