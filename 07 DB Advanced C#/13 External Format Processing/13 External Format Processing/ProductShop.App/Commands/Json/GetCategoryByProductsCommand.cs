using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;

namespace ProductShop.App.Commands
{
    public class GetCategoryByProductsCommand
    {
        public static string Execute()
        {
            using (var context = new ProductsShopContext())
            {
                var categories = context
                    .Categories
                    .OrderBy(c => c.Name)
                    .Include(c => c.CategoryProductses)
                    .ThenInclude(cp => cp.Product)
                    .Select(c => new
                    {
                        name = c.Name,
                        productsCount = c.CategoryProductses.Count,
                        averagePrice = c.CategoryProductses.Average(cp => cp.Product.Price),
                        totalRevenue = c.CategoryProductses.Sum(cp => cp.Product.Price)
                    });

                var jsonString = JsonConvert.SerializeObject(categories, Formatting.Indented);

                File.WriteAllText("../../../Files/ProductByCount.json", jsonString);

                return "Json Command was successfully executed!";
            }
        }
    }
}
