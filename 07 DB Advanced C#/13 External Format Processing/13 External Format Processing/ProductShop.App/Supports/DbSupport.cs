using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductShop.Data;

namespace ProductShop.App.Supports
{
    public class DbSupport
    {
        public static void DbInitializer()
        {
            using (var db = new ProductsShopContext())
            {
                db.Database.EnsureDeleted();

                db.Database.EnsureCreated();

                Console.WriteLine("Database was successfully created!");
            }
        }
    }
}
