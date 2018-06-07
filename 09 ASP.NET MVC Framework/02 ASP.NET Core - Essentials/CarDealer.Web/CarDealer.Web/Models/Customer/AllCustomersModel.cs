using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Services.Enums;
using CarDealer.Services.Models;
using CarDealer.Services.Models.Customers;

namespace CarDealer.Web.Models.Customer
{
    public class AllCustomersModel
    {
        public IEnumerable<CustomerModel> Customers { get; set; }

        public OrderDirection OrdedDirection { get; set; }
    }
}
