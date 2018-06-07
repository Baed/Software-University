using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Services;
using CarDealer.Services.Contracts;
using CarDealer.Web.Infrastructure.CustomFilters;
using CarDealer.Web.Models.Car;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarDealer.Web.Controllers
{
    [Route("cars")]
    public class CarsController : Controller
    {
        private readonly ICarService cars;
        private readonly IPartService parts;

        public CarsController(ICarService cars, IPartService parts)
        {
            this.cars = cars;
            this.parts = parts;
        }

        [Route("{make}", Order = 2)]
        public IActionResult Make(string make)
        {
            var carsByMake = this.cars.ByMake(make);

            var model = new CarsByMakeModel()
            {
                Make = make,
                Cars = carsByMake
            };

            return View(model);
        }

        [Route("parts", Order = 1)]
        public IActionResult Parts()
        {
            var model = this.cars.WithParts();

            return View(model);
        }

        [Route("all")]
        public IActionResult All()
        {
            var allCars = this.cars.AllCarsList();

            var model = new AllCars()
            {
                Cars = allCars
            };

            return View(model);
        }

        [Authorize]
        [Route(nameof(Create))]
        public IActionResult Create()
        {
            var model = new CarFormModel
            {
                AllParts = this.GetPartsSelectItem()
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateModel] // customfilter
        [Route(nameof(Create))]
        public IActionResult Create(CarFormModel carModel)
        {
            if (!ModelState.IsValid)
            {
                carModel.AllParts = this.GetPartsSelectItem();
                return View(carModel);
            }

            this.cars.GetCreate(
                carModel.Make,
                carModel.Model,
                carModel.TravelledDistance,
                carModel.SelectedParts);

            return RedirectToAction(nameof(Parts));
        }

        private IEnumerable<SelectListItem> GetPartsSelectItem()
                        => this.parts
                                 .GetAll()
                                 .Select(p => new SelectListItem
                                 {
                                     Text = p.Name,
                                     Value = p.Id.ToString()
                                 });
    }
}
