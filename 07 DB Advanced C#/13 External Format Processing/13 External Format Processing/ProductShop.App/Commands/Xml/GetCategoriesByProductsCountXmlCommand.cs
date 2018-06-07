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
    public class GetCategoriesByProductsCountXmlCommand
    {
        public static string Execute()
        {
            using (var context = new ProductsShopContext())
            {
                var categories = context
                    .Categories
                    .Include(c => c.CategoryProductses)
                    .ThenInclude(cp => cp.Product)
                    .Select(c => new
                    {
                        name = c.Name,
                        productsCount = c.CategoryProductses.Count,
                        averagePrice = c.CategoryProductses.Average(cp => cp.Product.Price),
                        totalRevenue = c.CategoryProductses.Sum(cp => cp.Product.Price)
                    })
                    .OrderBy(c => c.productsCount);

                var xDocument = new XDocument();

                xDocument.Add(new XElement("categories"));

                foreach (var category in categories)
                {
                    xDocument.Root.Add(new XElement("category",
                        new XAttribute("products-count", category.productsCount),
                        new XElement("average-price", category.averagePrice),
                        new XElement("total-revenue", category.totalRevenue)));
                }

                var writer = new StreamWriter("../../../Files/categories.xml");

                using (writer)
                {
                    xDocument.Save(writer);
                }
            }

            return "XML Command was successfully executed!";
        }
    }
}
