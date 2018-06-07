using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Services.Models;
using CarDealer.Services.Models.Suppliers;

namespace CarDealer.Services.Contracts
{
    public interface ISupplierService
    {
        IEnumerable<SupplierListingModel> GetAll(bool isImporter);

        IEnumerable<SupplierModel> GetAll()
;    }
}
