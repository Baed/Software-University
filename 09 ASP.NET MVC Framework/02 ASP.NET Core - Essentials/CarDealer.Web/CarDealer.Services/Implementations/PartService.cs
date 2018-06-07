using CarDealer.Data;
using CarDealer.Data.Models;
using CarDealer.Services.Contracts;
using CarDealer.Services.Models.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Services.Implementations
{
    public class PartService : IPartService
    {
        private readonly CarDealerDbContext db;

        public PartService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public PartDetailsModel ById(int id)
        {
            var partsDetail = this.db
                .Parts
                .Where(p => p.Id == id)
                .Select(p => new PartDetailsModel
                {
                    Name = p.Name,
                    Price = p.Price,
                    Quantity =p.Quantity
                })
                .FirstOrDefault();

            return partsDetail;
        }

        public void Create(string name, decimal price, int quantity, int supplierId)
        {
            var part = new Part
            {
                Name = name,
                Price = price,
                Quantity = quantity > 0 ? quantity : 1,
                SupplierID = supplierId
            };

            this.db.Add(part);

            this.db.SaveChanges();
        }

        public void ExecuteDelete(int id)
        {
            var part = this.db.Parts.Find(id);

            if (part == null)
            {
                return;
            }

            this.db.Parts.Remove(part);

            this.db.SaveChanges();
        }

        public void ExecuteEdit(int id, decimal price, int quantity)
        {
            var part = this.db.Parts.Find(id);

            if (part == null)
            {
                return;
            }

            part.Price = price;
            part.Quantity = quantity;

            this.db.SaveChanges();
        }

        public IEnumerable<PartListingModel> AllListings(int page = 1, int pageSize = 10)
        {
            var result = this.db
                .Parts
                .OrderByDescending(p => p.Id)
                .Skip((page - 1) * pageSize) // 1 - 0 // 2 - 25
                .Take(pageSize)
                .Select(p => new PartListingModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    SupplierName = p.Supplier.Name
                })
                .ToList();

            return result;
        }

        public int Total() => this.db.Parts.Count();

        public IEnumerable<PartBasicModel> GetAll()
        {
            var result = this.db
                .Parts
                .OrderBy(p => p.Id)
                .Select(p => new PartBasicModel
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .ToList();

            return result;
        }
    }
}
