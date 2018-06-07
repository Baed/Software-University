using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AreasDemo.Models;
using AreasDemo.Data;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace AreasDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public HomeController(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var user = this.db
                .Users
                .ProjectTo<UserViewModel>()
                .ToList();

          //  var applicationUser = new ApplicationUser
          //  {
          //      Email = "ivan@ivan.ivan",
          //      UserName = "ivan",
          //      Id = "1"
          //  };
          //
          //  var mappedObject = this.mapper
          //                              .Map<UserViewModel>(applicationUser);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
