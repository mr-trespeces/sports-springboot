using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Authorization;
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

        //[AcceptVerbs("Get", "Post")]
        //[AllowAnonymous]
        //public async Task<IActionResult> IsEmailInUse(string email)
        //{
        //    var user = await userManager.FindByEmailAsyn(email);
        //
        //    if (user == null)
        //    {
        //        return Json(true);
        //    }
        //}
        public RedirectToActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("List");
        }

        [HttpGet]
        [Route("customers")]
        public IActionResult List()
        { 
            List<Customer> customer = context.Customers
                .OrderBy(c => c.Firstname).ToList();
            return View("List", customer);
        }
        [HttpGet]
        public IActionResult Add()
        {    
            ViewData["CountryId"] = new SelectList(context.Country, "CountryId", "Name");
            ViewBag.Action = "Add";
            return View("Edit", new Customer());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["CountryId"] = new SelectList(context.Country, "CountryId", "Name");
            ViewBag.listOfCountry = context.Country.OrderBy(c => c.CountryId).ToList();    
            ViewBag.Action = "Edit";
            var customer = context.Customers
                .FirstOrDefault(c => c.CustomerId == id);
            return View(customer);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            ViewBag.Customer = context.Customers
                .FirstOrDefault(c => c.CustomerId == id);
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
            ViewData["CountryId"] = new SelectList(context.Country, "CountryId", "Name");
            var selectedIds = Request.Form["CountryId"];
            ViewBag.Countries = context.Country
                .OrderBy(c => c.CountryId).ToList();
            if (ModelState.IsValid)
            {
                if (customer.CustomerId == 0)
                {
                    TempData["message"] = $"Customer {customer.Firstname} {customer.Lastname} was successfully added.";
                    context.Customers.Add(customer);
                }
                else
                {
                    TempData["message"] = $"Customer {customer.Firstname} {customer.Lastname} was successfully edited.";
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
            TempData["message"] = $"Customer {customer.Firstname} {customer.Lastname} was successfully deleted.";
            return RedirectToAction("List", "customer");
        }
    }
}
