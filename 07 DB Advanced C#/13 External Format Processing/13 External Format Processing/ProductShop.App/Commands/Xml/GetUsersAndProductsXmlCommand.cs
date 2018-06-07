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
    public class GetUsersAndProductsXmlCommand
    {
        public static string Execute()
        {
            using (var context = new ProductsShopContext())
            {
                var users = context
                    .Users
                    .Where(u => u.SoldProducts.Count > 0)
                    .OrderByDescending(u => u.SoldProducts.Count)
                    .ThenBy(u => u.LastName)
                    .Include(u => u.SoldProducts)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        age = u.Age,
                        soldProducts = u.SoldProducts
                            .Select(p => new
                            {
                                name = p.Name,
                                price = p.Price
                            })
                    });

                var xDocument = new XDocument();

                xDocument.Add(new XElement("users", new XAttribute("count", users.Count())));

                foreach (var user in users)
                {
                    var productsXEls = new List<XElement>();

                    foreach (var soldProduct in user.soldProducts)
                    {
                        productsXEls.Add(new XElement("product", new XAttribute("name", soldProduct.name), new XAttribute("price", soldProduct.price)));
                    }

                    var userAttributes = new List<XAttribute>();

                    if (user.firstName != null)
                    {
                        userAttributes = new List<XAttribute>
                        {
                            new XAttribute("first-name",user.firstName),
                            new XAttribute("last-name", user.lastName)
                        };
                    }

                    if (user.age != null)
                    {
                        var age = int.Parse(user.age.ToString());
                        userAttributes.Add(new XAttribute("age", age));
                    }

                    xDocument.Root.Add(new XElement("user", userAttributes, new XElement("sold-products", new XAttribute("count", user.soldProducts.Count()), productsXEls)));
                }

                var writer = new StreamWriter("../../../Files/usersProducts.xml");

                using (writer)
                {
                    xDocument.Save(writer);
                }
            }
            return "XML Command was successfully executed!";
        }
    }
}
