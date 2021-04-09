using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class RegistrationController : Controller
    {
        private SportingContext context { get; set; }

        public RegistrationController(SportingContext ctx)
        {
            context = ctx;
        }
        public IActionResult Get()
        {
            var temp = TempData["message"];
            var customer = context.Customers.OrderBy(c => c.CustomerId).ToList();
            ViewBag.listOfCustomer = customer;
            ViewBag.Action = "Select";
            return View();
        }
        [HttpGet]
        public IActionResult Registrations(int id)
        {
            if (id == 0)
            {
                TempData["message"] = "*Please select Customer";
                return RedirectToAction("Get");
            }
            return RedirectToAction("Get");
        }
    }
}
