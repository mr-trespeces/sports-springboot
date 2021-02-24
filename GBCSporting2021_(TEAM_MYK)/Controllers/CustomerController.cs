using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;

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
            var customer = context.Customers;
            return View("List", customer);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Edit";
            return View("Edit", new Customer());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
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
            string action = (customer.CustomerId == 4) ? "Edit" : "Edit";

            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    context.Customers.Add(customer);
                }
                else
                {
                    context.Customers.Update(customer);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = action;
                return RedirectToAction("Index", "Home");
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
