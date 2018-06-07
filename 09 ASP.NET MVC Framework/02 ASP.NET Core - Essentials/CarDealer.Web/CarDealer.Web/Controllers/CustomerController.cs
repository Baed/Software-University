using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Services;
using CarDealer.Services.Contracts;
using CarDealer.Services.Enums;
using CarDealer.Web.Infrastructure.Extensions;
using CarDealer.Web.Models.Customer;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Web.Controllers
{
    [Route("customers")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService customers;

        public CustomerController(ICustomerService customers)
        {
            this.customers = customers;
        }

        [Route("all/{order}")]
        public IActionResult All(string order)
        {
            var orderDirection = order.ToLower() == "descending" ? OrderDirection.Descending : OrderDirection.Ascending;

            var customersResult = this.customers.OrderedCustumers(orderDirection);

            var model = new AllCustomersModel
            {
                Customers = customersResult,
                OrdedDirection = orderDirection
            };

            return View(model);
        }

        [Route("{id}")]
        public IActionResult TotalSales(int id)
        {
            var model = this.customers.TotalSalesById(id);

            return this.ViewOrNotFound(model);
        }

        [Route(nameof(Create))]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(CustomerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.customers.Create(
                model.Name,
                model.BirthDay,
                model.IsYoungDriver
                );

            return RedirectToAction(nameof(All), new { order = OrderDirection.Ascending });
        }

        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id)
        {
            var customerbyId = this.customers.GetId(id);

            if (customerbyId == null)
            {
                return this.NotFound(customerbyId);
            }

            var model = new CustomerFormModel
            {
                Name = customerbyId.Name,
                BirthDay = customerbyId.BirthTime,
                IsYoungDriver = customerbyId.IsYoungDriver
            };

            return View(model);
        }

        [HttpPost]
        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id, CustomerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool isCustomerExist = this.customers.Exists(id);

            if (!isCustomerExist)
            {
                return NotFound();
            }

            this.customers.Edit(
                 id,
                 model.Name,
                 model.BirthDay,
                 model.IsYoungDriver
                 );

            return RedirectToAction(nameof(All), new { order = OrderDirection.Ascending });
        }
    }
}
