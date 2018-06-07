using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Services.Models.Cars;
using CarDealer.Services.Models.Sales;

namespace CarDealer.Services.Models.Customers
{
    public class CustomerTotalSalesModel
    {
        public string Name { get; set; }

        public bool IsYoungDriver { get; set; }

        public IEnumerable<SaleModel> BougthCars { get; set; }

        public decimal TotalMoneySpent
        {
            get
            {
                return this.BougthCars
                    .Sum(c => c.Price * (1 - (decimal)c.Discount))
                       * (this.IsYoungDriver ? 0.95m : 1);
            }
        }
    }
}
