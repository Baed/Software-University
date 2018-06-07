using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop.App.Commands
{
    public class ImportUsersFromJsonCommand
    {
        public static string Execute()
        {
            string jsonPath = "../../../Files/users.json";

            var users = JsonSupport.ImportJson<User>(jsonPath);

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);

                context.SaveChanges();
            }

            return $"{users.Length} users were imported from file: {jsonPath}";
        }
    }
}
