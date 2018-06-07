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
    public class ImportCategoriesFromXmlCommand
    {
        public static string Execute()
        {
            string xmlPath = "../../../Files/categories.xml";

            string exlString = File.ReadAllText(xmlPath);

            var elements = XDocument.Parse(exlString)
                .Root
                .Elements();

            var categories = new List<Category>();

            foreach (var xElement in elements)
            {
                var category = new Category()
                {
                    Name = xElement.Element("name").Value
                };

                categories.Add(category);
            }

            using (var context = new ProductsShopContext())
            {
                context.Categories.AddRange(categories);

                context.SaveChanges();
            }

            return $"{categories.Count} users were imported from file: {xmlPath}";
        }
    }
}
