
namespace E04.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var peopleList = new List<Person>();
            var productList = new List<Product>();

            var allPeople = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            var allProduct = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var pair in allPeople)
                {
                    var personInfo = pair.Split('=');
                    var person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    peopleList.Add(person);
                }

                foreach (var pair in allProduct)
                {
                    var productInfo = pair.Split('=');
                    var product = new Product(productInfo[0], decimal.Parse(productInfo[1]));
                    productList.Add(product);
                }

                string purchase;
                while ((purchase = Console.ReadLine()) != "END")
                {
                    var purchaseInfo = purchase.Split(' ');
                    var buyerName = purchaseInfo[0];
                    var productName = purchaseInfo[1];

                    var buyer = peopleList.FirstOrDefault(b => b.Name == buyerName);

                    var productToBuy = productList.FirstOrDefault(p => p.Name == productName);

                    try
                    {
                        buyer.BuyProduct(productToBuy);
                        Console.WriteLine($"{buyerName} bought {productName}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                foreach (var person in peopleList)
                {
                    var boughtPorducts = person.GetProducts();

                    var result = boughtPorducts.Any()
                        ? string.Join(", ", boughtPorducts
                        .Select(pr => pr.Name)
                        .ToList()) 
                        : "Nothing bought";

                    Console.WriteLine($"{person.Name} - {result}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
