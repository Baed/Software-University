using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Data;
using CarDealer.Services.Contracts;
using CarDealer.Services.Models;
using CarDealer.Services.Models.Suppliers;

namespace CarDealer.Services.Implementations
{
    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<SupplierListingModel> GetAll(bool isImporter)
        {
            var result = this.db
                .Suppliers
                .OrderByDescending(s => s.Id)
                .Where(s => s.IsImporter == isImporter)
                .Select(s => new SupplierListingModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    TotalParts = s.Parts.Count,
                })
                .ToList();

            return result;
        }

        public IEnumerable<SupplierModel> GetAll()
        {
            var result = this.db
                .Suppliers
                .OrderBy(s => s.Name)
                .Select(s => new SupplierModel
                {
                    Id = s.Id,
                    Name = s.Name
                })
                .ToList();

            return result;
        }
    }
}
