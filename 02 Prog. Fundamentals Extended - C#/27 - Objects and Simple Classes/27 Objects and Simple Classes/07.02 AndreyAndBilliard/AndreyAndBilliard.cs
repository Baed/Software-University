using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02_AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = Reader();

            List<Customer> customers = ExecudeProgram(menu);

            Writer(customers, menu);
        }

        private static void Writer(List<Customer> customers, Dictionary<string, decimal> menu)
        {
            decimal totalBills = 0;

            foreach (var client in customers.OrderBy(c => c.Name).ToList())
            {
                Console.WriteLine($"{client.Name}");

                foreach (var kvp in client.Order)
                {
                    Console.WriteLine($"-- {kvp.Key} - {kvp.Value}");
                }

                decimal bill = client.Bill(menu);

                totalBills += bill;

                Console.WriteLine($"Bill: {bill:f2}");
            }

            Console.WriteLine($"Total bill: {totalBills:f2}");
        }


        private static List<Customer> ExecudeProgram(Dictionary<string, decimal> menu)
        {
            Customer person = new Customer("", new Dictionary<string, int>());

            List<Customer> customers = new List<Customer>();

            string input;
            while ((input = Console.ReadLine()) != "end of clients")
            {
                var tokens = input.Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string client = tokens[0], product = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (menu.ContainsKey(product))
                {
                    if (customers.Any(p => p.Name.Equals(client)))
                    {
                        person = customers.FirstOrDefault(c => c.Name == client);

                        if (!person.Order.ContainsKey(product))
                        {
                            person.Order.Add(product, 0);
                        }

                        person.Order[product] += quantity;
                    }
                    else
                    {
                        person = new Customer(client, new Dictionary<string, int>() { { product, quantity } });

                        customers.Add(person);
                    }
                }
            }

            return customers;
        }

        private static Dictionary<string, decimal> Reader()
        {
            Dictionary<string, decimal> data = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                var tokens = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (!data.ContainsKey(tokens[0]))
                {
                    data.Add(tokens[0], 0);
                }

                data[tokens[0]] = decimal.Parse(tokens[1]);
            }

            return data;
        }
    }

    class Customer
    {
        public Customer(string name, Dictionary<string, int> order)
        {
            this.Name = name;
            this.Order = order;
        }

        public string Name { get; set; }

        public Dictionary<string, int> Order { get; set; }

        public decimal Bill(Dictionary<string, decimal> menu)
        {
            decimal bill = 0;

            foreach (var product in this.Order)
            {
                if (menu.ContainsKey(product.Key))
                {
                    bill += menu[product.Key] * product.Value; // productMenuPrice * productOrderQuantity
                }
            }

            return bill;
        }
    }
}
