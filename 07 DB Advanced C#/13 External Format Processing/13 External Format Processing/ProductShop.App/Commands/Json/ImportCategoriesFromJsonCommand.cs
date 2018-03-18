using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop.App.Commands
{
    public class ImportCategoriesFromJsonCommand
    {
        public static string Execute()
        {
            string jsonPath = "../../../Files/categories.json";

            var categories = JsonSupport.ImportJson<Category>(jsonPath);

            using (var context = new ProductsShopContext())
            {
                context.Categories.AddRange(categories);

                context.SaveChanges();
            }

            return $"{categories.Length} categories were imported from file: {jsonPath}";
        }
    }
}
