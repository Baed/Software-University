using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop.App.Commands
{
    public class ImportProductsFromXmlCommand
    {
        public static string Execute()
        {
            string xmlPath = "../../../Files/products.xml";

            string exlString = File.ReadAllText(xmlPath);

            var elements = XDocument.Parse(exlString)
                .Root
                .Elements();

            var products = new List<Product>();

            foreach (var xElement in elements)
            {
                var product = new Product
                {
                    Name = xElement.Element("name").Value,

                    Price = decimal.Parse(xElement.Element("price").Value)
                };

                products.Add(product);
            }

            using (var context = new ProductsShopContext())
            {
                var random = new Random();

                var userIds = context.Users.Select(u => u.Id).ToList();

                var index = random.Next(0, userIds.Count);

                var sellerId = userIds[index];

                int? buyerId = sellerId;

                while (buyerId == sellerId)
                {
                    var buyerIndex = random.Next(0, userIds.Count);

                    buyerId = userIds[buyerIndex];
                }

                foreach (var product in products)
                {
                    index = random.Next(0, userIds.Count);

                    sellerId = userIds[index];

                    product.SellerId = sellerId;

                    if (buyerId - sellerId < 5 && buyerId - sellerId > 0)
                    {
                        buyerId = null;
                    }

                    product.BuyerId = buyerId;

                }

                context.Products.AddRange(products);

                var categoryIds = context.Categories.Select(c => c.Id).ToList();

                foreach (var product in products)
                {
                    index = random.Next(0, categoryIds.Count);

                    product.CategoryProductses.Add(new CategoryProduct
                    {
                        CategoryId = categoryIds[index],
                        ProductId = product.Id
                    });
                }

                context.SaveChanges();

                return $"{products.Count} users were imported from file: {xmlPath}";
            }
        }
    }
}
