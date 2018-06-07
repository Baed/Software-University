using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Data;
using CarDealer.Services.Contracts;
using CarDealer.Services.Models.Cars;
using CarDealer.Services.Models.Sales;

namespace CarDealer.Services.Implementations
{
    public class SaleService : ISaleService
    {
        private readonly CarDealerDbContext db;

        public SaleService(CarDealerDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<SaleListModel> GetAll()
        {
            var result = this.db
                .Sales
                .Select(s => new SaleListModel()
                {
                    Id = s.Id,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.Parts.Sum(p => p.Part.Price),
                    IsYoungDriver = s.Customer.IsYoungDriver,
                    Discount = s.Discount

                })
                .ToList();

            return result;
        }

        public SaleDetailModel GetDetail(int id)
        {
            var result = this.db
                .Sales
                .OrderByDescending(s => s.Id)
                .Where(s => s.Id == id)
                .Select(s => new SaleDetailModel
                {
                    Id = s.Id,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.Parts.Sum(p => p.Part.Price),
                    IsYoungDriver = s.Customer.IsYoungDriver,
                    Discount = s.Discount,
                    Car = new CarModel()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    } 
                })
                .FirstOrDefault();

            return result;
        }
    }
}
