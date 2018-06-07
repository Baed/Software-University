using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._01_AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        public static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = GetProductsAndPrices();

            List<Customer> customers = ExecuteOrders(menu);

            PrintTotalBill(menu, customers);
        }

        private static void PrintTotalBill(Dictionary<string, decimal> menu, List<Customer> customers)
        {
            customers = customers
                .OrderBy(x => x.Name)
                .ToList();

            decimal totalBill = 0M;

            foreach (Customer client in customers)
            {
                Console.WriteLine(client.Name);

                foreach (KeyValuePair<string, int> line in client.Order)
                {
                    Console.WriteLine($"-- {line.Key} - {line.Value}");
                }

                decimal bill = client.Bill(menu);

                Console.WriteLine($"Bill: {bill:F2}");

                totalBill += bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        private static List<Customer> ExecuteOrders(Dictionary<string, decimal> menu)
        {
            List<Customer> customers = new List<Customer>();
            string input;
            while ((input = Console.ReadLine()) != "end of clients")
            {
                string[] order = input.Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);           

                if (menu.ContainsKey(order[1]))
                {
                    if (customers.Any(c => c.Name.Equals(order[0])))
                    {
                        Customer person = customers.FirstOrDefault(x => x.Name.Equals(order[0]));

                        if (person.Order.ContainsKey(order[1]))
                        {
                            person.Order[order[1]] += int.Parse(order[2]);
                        }
                        else
                        {
                            person.Order[order[1]] = int.Parse(order[2]);
                        }
                    }
                    else
                    {
                        customers.Add(new Customer() { Name = order[0], Order = new Dictionary<string, int>() { { order[1], int.Parse(order[2]) } } });
                    }
                }
            }
            return customers;
        }

        private static Dictionary<string, decimal> GetProductsAndPrices()
        {
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();


            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] newProduct = Console.ReadLine().Split('-');

                menu[newProduct[0]] = decimal.Parse(newProduct[1]);
            }

            return menu;
        }
    }

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> Order { get; set; }

        public decimal Bill(Dictionary<string, decimal> menu)
        {
            decimal bill = 0M;

            foreach (var item in this.Order)
            {
                if (menu.ContainsKey(item.Key))
                {
                    bill += menu[item.Key] * item.Value;
                }
            }

            return bill;
        }
    }
}
