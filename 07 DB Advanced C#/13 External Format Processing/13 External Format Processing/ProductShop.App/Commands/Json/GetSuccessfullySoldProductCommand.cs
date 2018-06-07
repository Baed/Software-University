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
    public class GetSuccessfullySoldProductCommand
    {
        public static string Execute()
        {
            using (var context = new ProductsShopContext())
            {
                var users = context
                    .Users
                    .Where(u => u.SoldProducts.Any(p => p.BuyerId != null))
                    .OrderBy(u => u.LastName)
                    .ThenBy(u => u.FirstName)
                    .Select(u => new
                    {
                       firstName = u.FirstName,
                       lastName = u.LastName,
                        soldProducts = u.BougthProducts
                            .Select(p => new
                            {
                               name = p.Name,
                               price = p.Price,
                                buyerFirstName = p.Buyer.FirstName,
                                buyerLastName = p.Buyer.LastName
                            })
                    })
                    .ToList();

                var jsonString = JsonConvert.SerializeObject(users, Formatting.Indented, new JsonSerializerSettings(){ DefaultValueHandling= DefaultValueHandling.Ignore });

                File.WriteAllText("../../../Files/soldProducts.json", jsonString);

                return "Json Command was successfully executed!";
            }
        }
    }
}
