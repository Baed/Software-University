using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Services;
using CarDealer.Services.Contracts;
using CarDealer.Web.Models.Supplier;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    [Route("suppliers")]
    public class SupplierController : Controller
    {
        private readonly ISupplierService supplier;
        private const string SUPPLIER_VIEW = "Suppliers";

        public SupplierController(ISupplierService supplier)
        {
            this.supplier = supplier;
        }

        [Route("local")]
        public IActionResult Local()
        {
            return View(SUPPLIER_VIEW, this.GetSuppliersModel(false));
        }

        [Route("importers")]
        public IActionResult Importers()
        {
            return View(SUPPLIER_VIEW, this.GetSuppliersModel(true));
        }

        private SuppliersModel GetSuppliersModel(bool importers)
        {
            var type = importers ? "Importer" : "Local";

            var suppliersResult = this.supplier.GetAll(importers);

            var result = new SuppliersModel()
            {
                Type = type,
                Suppliers = suppliersResult
            };

            return result;
        }
    }
}
