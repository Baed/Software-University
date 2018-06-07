using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Data;
using CarDealer.Data.Models;
using CarDealer.Services.Contracts;
using CarDealer.Services.Enums;
using CarDealer.Services.Models;
using CarDealer.Services.Models.Cars;
using CarDealer.Services.Models.Customers;
using CarDealer.Services.Models.Sales;

namespace CarDealer.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CustomerModel> OrderedCustumers(OrderDirection order)
        {
            var customerQuery = this.db.Customers.AsQueryable();

            switch (order)
            {
                case OrderDirection.Ascending:
                    customerQuery = customerQuery
                        .OrderBy(c => c.BirthTime)
                        .ThenBy(c => c.Name);
                    break;

                case OrderDirection.Descending:
                    customerQuery = customerQuery
                        .OrderByDescending(c => c.BirthTime)
                        .ThenBy(c => c.Name);
                    break;

                default: throw new InvalidOperationException($"Invalid order direction: {order}.");
            }

            return customerQuery
                .Select(c => new CustomerModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    BirthTime = c.BirthTime,
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToList();
        }

        public CustomerTotalSalesModel TotalSalesById(int id)
        {
            var result = this.db
                .Customers
                .Where(c => c.Id == id)
                .Select(c => new CustomerTotalSalesModel()
                {
                    Name = c.Name,
                    IsYoungDriver = c.IsYoungDriver,
                    BougthCars = c.Sales.Select(s => new SaleModel()
                    {
                        Price = s.Car.Parts.Sum(p => p.Part.Price),
                        Discount = s.Discount
                    })
                })
                .FirstOrDefault();

            return result;
        }


        public void Create(string name, DateTime birthday, bool isYoungDriver)
        {
            var customer = new Customer
            {
                Name = name,
                BirthTime = birthday,
                IsYoungDriver = isYoungDriver
            };

            this.db.Add(customer);

            this.db.SaveChanges();
        }

        public CustomerModel GetId(int id)
        {
            var customerById = this.db
                .Customers
                .Where(c => c.Id == id)
                .Select(c => new CustomerModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    BirthTime = c.BirthTime,
                    IsYoungDriver = c.IsYoungDriver
                })
                .FirstOrDefault();

            return customerById;
        }

        public void Edit(int id, string name, DateTime birthday, bool isYoungDriver)
        {
            var existingCustomer = this.db.Customers.Find(id);

            if (existingCustomer == null)
            {
                return;
            }

            existingCustomer.Name = name;
            existingCustomer.BirthTime = birthday;
            existingCustomer.IsYoungDriver = isYoungDriver;

            this.db.SaveChanges();
        }

        public bool Exists(int id)
        {
            return this.db.Customers.Any(c => c.Id == id);
        }
    }
}
