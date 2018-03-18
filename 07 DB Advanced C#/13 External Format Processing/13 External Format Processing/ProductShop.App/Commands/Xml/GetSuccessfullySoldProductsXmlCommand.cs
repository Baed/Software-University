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
    public class GetSuccessfullySoldProductsXmlCommand
    {
        public static string Execute()
        {
            using (var context = new ProductsShopContext())
            {
                var users = context
                    .Users
                    .Where(u => u.SoldProducts.Count > 0)
                    .Include(u => u.SoldProducts)
                    .ThenInclude(p => p.Buyer)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        soldProducts = u.SoldProducts
                            .Select(p => new
                            {
                                name = p.Name,
                                price = p.Price,
                            }).ToList()
                    })
                    .OrderBy(u => u.lastName)
                    .ThenBy(u => u.firstName)
                    .ToList();

                var xDocument = new XDocument();

                xDocument.Add(new XElement("users"));

                foreach (var user in users)
                {
                    var products = new List<XElement>();

                    foreach (var soldProduct in user.soldProducts)
                    {
                        products.Add(new XElement("product", new XAttribute("name", soldProduct.name), new XAttribute("price", soldProduct.price)));
                    }

                    if (user.firstName is null)
                    {
                        xDocument.Root.Add(
                            new XElement("user",
                                new XAttribute("lastName", user.lastName)),
                                    new XElement("sold-products", products));
                    }
                    else
                    {
                        xDocument.Root.Add(new XElement("user", new XAttribute("firstName", user.firstName), new XAttribute("lastName", user.lastName)), new XElement("sold-products", products));
                    }
                }

                var writer = new StreamWriter("soldproducts.xml");

                using (writer)
                {
                    xDocument.Save(writer);
                }
            }

            return "XML Command was successfully executed!";
        }
    }
}
