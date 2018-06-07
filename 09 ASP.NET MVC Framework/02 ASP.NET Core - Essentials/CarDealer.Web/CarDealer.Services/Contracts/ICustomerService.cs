using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Services.Enums;
using CarDealer.Services.Models;
using CarDealer.Services.Models.Customers;

namespace CarDealer.Services.Contracts
{
    public interface ICustomerService
    {
        IEnumerable<CustomerModel> OrderedCustumers(OrderDirection order);

        CustomerTotalSalesModel TotalSalesById(int id);

        void Create(string name, DateTime birthday, bool isYoungDriver);

        void Edit(int id, string name, DateTime birthday, bool isYoungDriver);

        CustomerModel GetId(int id);

        bool Exists(int id);
    }
}
