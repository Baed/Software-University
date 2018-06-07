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
    public class ImportUsersFromXmlCommand
    {
        public static string Execute()
        {
            string xmlPath = "../../../Files/users.xml";

            string exlString = File.ReadAllText(xmlPath);

            var elements = XDocument.Parse(exlString)
                .Root
                .Elements();

            var users = new List<User>();

            foreach (var xElement in elements)
            {
                var firstName = xElement.Attribute("firstName")?.Value;

                var lastName = xElement.Attribute("lastName").Value;

                int? age = null;

                if (xElement.Attribute("age") != null)
                {
                    age = int.Parse(xElement.Attribute("age").Value);
                }

                var user = new User(firstName, lastName, age);

                users.Add(user);
            }

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);

                context.SaveChanges();
            }

            return $"{users.Count} users were imported from file: {xmlPath}";
        }
    }
}

