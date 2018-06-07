using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatsWebApp.Models;
using CatsWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatsWebApp.Controllers
{
    public class CatsController : Controller
    {
        private readonly ICatService catService;

        public CatsController(ICatService catService)
        {
            this.catService = catService;
            this.catService.Cats = new[] { "New Cat" };
        }


        public IActionResult Detail()
        {
            var model = new CatDetailsModel
            {
                Id = 1,
                Name = "Goshko"
            };

            return View(model);
        }


        public IActionResult Create()
        {
            return View();
        }
    }
}
