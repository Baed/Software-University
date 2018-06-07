using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace E03_Shopping_Spree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = AddCollections<Person>();

            List<Product> products = AddCollections<Product>();

            BuyProducts(persons, products);

            Priter(persons);
        }

        private static void Priter(List<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }

        private static void BuyProducts(List<Person> personsList, List<Product> productsList)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Person person = personsList.FirstOrDefault(p => p.Name == cmdArgs[0]);
                Product product = productsList.FirstOrDefault(p => p.Name == cmdArgs[1]);

                person.BuyProduct(product);
            }
        }

        private static List<T> AddCollections<T>()
        {
            List<T> collectionData = new List<T>();

            var cmdArgs = Console.ReadLine().Split(new [] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < cmdArgs.Length; i++)
            {
                var separator = cmdArgs[i].IndexOf('=');
                var name = cmdArgs[i].Substring(0, separator).Trim();
                var money = decimal.Parse(cmdArgs[i].Substring(separator + 1).Trim());

                try
                {
                    collectionData[i] = (T)Activator.CreateInstance(typeof(T), name, money);
                }
                catch (TargetInvocationException tie)
                {
                    Console.WriteLine(tie.InnerException.Message);
                    Environment.Exit(Environment.ExitCode);
                }
            }

            return collectionData;
        }
    }
}

