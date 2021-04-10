using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.listOfCust = techs;
            ViewBag.Action = "Select";
            return View();
        }
        [HttpGet]
        public IActionResult Registrations(int? id)
        {
            if (id == 0)
            {
                TempData["message"] = "*Please select Customer";
                return RedirectToAction("Get");
            }
            else
            {
                List<Registration> registrations = context.Registrations
                    .Include(r => r.Product)
                    .Include(r => r.Customer)
                    .Where(r => r.Customer.CustomerId == id)
                    .OrderBy(c => c.RegistrationId).ToList();

                ViewData["ProudctId"] = new SelectList(context.Products, "ProductId", "Name");

                ViewBag.Customer = context.Customers.Find(id);

                return View("Registrations", registrations);
            }
        }


    }
}
