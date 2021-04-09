using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var techs = context.Customers.OrderBy(t => t.CustomerId).ToList();
            ViewBag.listOfTech = techs;
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
            else
            {
                ViewBag.Customer = context.Customers.Find(id);
                Registration Registration = new Registration();
                Registration.customer = context.Customers;
                Registration.products = context.Products;
                ViewBag.Registrations = Registration;    

                return View("Registrations");
            }
        }
    }
}
