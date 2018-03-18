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
    public class GetProductsInRangeCommand
    {
        public static string Execute()
        {
            using (var context = new ProductsShopContext())
            {
                var currentProducts = context
                    .Products
                    .Where(p => p.Price >= 500 && p.Price <= 1000)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                    })
                    .OrderBy(p => p.price)
                    .ToList();

                var jsonString = JsonConvert.SerializeObject(currentProducts, Formatting.Indented);

                File.WriteAllText("../../../Files/productInRange.json", jsonString);

                return "Json Command was successfully executed!";
            }
        }
    }
}
