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
    public class GetUsersAndProductCommand
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
                })
               .ToArray();

                var jsonString = JsonConvert.SerializeObject(users, Formatting.Indented);

                File.WriteAllText("../../../Files/UsersAndProducts.json", jsonString);

                return "Json Command was successfully executed!";
            }
        }
    }
}
