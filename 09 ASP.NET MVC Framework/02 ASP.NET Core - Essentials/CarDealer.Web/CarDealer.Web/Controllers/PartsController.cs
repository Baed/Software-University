using CarDealer.Services.Contracts;
using CarDealer.Web.Models.Parts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Web.Controllers
{
    public class PartsController : Controller
    {
        private readonly IPartService parts;
        private readonly ISupplierService suppliers;

        private const int PAGE_SIZE = 25;
        public PartsController(IPartService parts, ISupplierService suppliers)
        {
            this.parts = parts;
            this.suppliers = suppliers;
        }

        public IActionResult All(int page = 1)
        {
            var model = new PartPageListingModel
            {
                Parts = this.parts.AllListings(page, PAGE_SIZE),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(this.parts.Total() / (double)PAGE_SIZE)
            };

            return View(model);
        }

        public IActionResult Create()
        {
            var model = new PartFormModel()
            {
                Suppliers = this.GetSupplierListItems()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(PartFormModel model)
        {
            if (true)
            {
                ModelState.AddModelError(nameof(PartFormModel.SupplierId), "Invalid supplier!");
            }

            if (!ModelState.IsValid)
            {
                model.Suppliers = this.GetSupplierListItems();
                return View(model);
            }

            this.parts.Create(
                model.Name,
                model.Price,
                model.Quantity,
                model.SupplierId
                );

            return RedirectToAction(nameof(All));

        }

        public IActionResult Delete(int id) => View(id);
        
        [HttpDelete]
        public IActionResult Destroy(int id)
        {
            this.parts.ExecuteDelete(id);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Edit(int id)
        {
            var part = this.parts.ById(id);

            if (part == null)
            {
                return NotFound();
            }

            var model = new PartFormModel
            {
                Name = part.Name,
                Price = part.Price,
                Quantity = part.Quantity,
                IsEdit = true
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, PartFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.IsEdit = true;
                return View(model);
            }

            this.parts.ExecuteEdit(
                id,
                model.Price,
                model.Quantity
                );

            return RedirectToAction(nameof(All));
        }

        private IEnumerable<SelectListItem> GetSupplierListItems()
        {
            var info = this.suppliers
                     .GetAll()
                     .Select(s => new SelectListItem() //using Microsoft.AspNetCore.Mvc.Rendering;
                     {
                         Text = s.Name,
                         Value = s.Id.ToString()
                     });

            return info;
        }
    }
}
