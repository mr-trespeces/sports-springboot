using System.Collections.Generic;
using System.Linq;
using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class CustomerController : Controller
    {
        private SportingContext context { get; set; }
        public CustomerController(SportingContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult List()
        {
            List<Customer> customer = context.Customers
                .OrderBy(c => c.Firstname).ToList(); ; 
            return View("List", customer);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Countries = context.Country;
            ViewBag.Action = "Add";
            return View("Edit", new Customer());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        { 
            ViewBag.Countries = context.Country;
            ViewBag.Action = "Edit";

            var customer = context.Customers
                .FirstOrDefault(c => c.CustomerId == id);
            return View(customer);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Customer prod = context.Customers.Find(id);
            if (prod == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("Delete");
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerId == 0)
                {
                    context.Customers.Add(customer);
                }
                else
                {
                    context.Customers.Update(customer);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Customer");
            }
            else
            {
                ViewBag.Action = (customer.CustomerId == 0) ? "Add" : "Edit";
                return View(customer);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            Customer customer = context.Customers.Find(id);
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("List", "customer");
        }
    }
}
