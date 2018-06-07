using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Web.Infrastructure.Extensions;
using CarDealer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    [Route("sales")]
    public class SalesController : Controller
    {
        private readonly ISaleService sales;

        public SalesController(ISaleService sales)
        {
            this.sales = sales;
        }

        [Route("")]
        public IActionResult All()
        {
            var model = this.sales.GetAll();

            return View(model);
        }

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var model = this.sales.GetDetail(id);

            return this.ViewOrNotFound(model);
        }
    }
}
