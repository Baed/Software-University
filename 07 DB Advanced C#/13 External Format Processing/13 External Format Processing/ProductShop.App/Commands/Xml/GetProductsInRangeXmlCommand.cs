using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using ProductShop.Data;

namespace ProductShop.App.Commands.Xml
{
    public class GetProductsInRangeXmlCommand
    {
        public static string Execute()
        {
            using (var context = new ProductsShopContext())
            {
                var products = context
                    .Products
                    .Where(p => p.Price >= 1000 && p.Price <= 2000 && p.Buyer != null)
                    .Include(p => p.Buyer)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        buier = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                    })
                    .OrderBy(p => p.price)
                    .ToList();

                var xDocument = new XDocument();

                xDocument.Add(new XElement("products"));

                foreach (var product in products)
                {
                    xDocument.Root.Add(new XElement("product", new XAttribute("name", product.name),
                        new XAttribute("price", product.price), new XAttribute("buyer", product.buier)));

                    var writer = new StreamWriter("products.xml");

                    using (writer)
                    {
                        xDocument.Save(writer);
                    }
                }
            }

            return "XML Command was successfully executed!";
        }
    }
}
