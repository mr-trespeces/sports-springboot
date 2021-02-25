using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class IncidentController : Controller
    {
        private SportingContext context { get; set; }

        public IncidentController(SportingContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult List()
        {
            var inci = context.Incidents
               .Include(c => c.Customer)
               .Include(c => c.Product);
            return View("List", inci);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Customers = context.Customers;
            ViewBag.Products = context.Products;

            return View("Edit", new Incident());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Customers = context.Customers;
            ViewBag.Products = context.Products;
            var inci = context.Incidents
               .Include(c => c.Product);

            return View(inci);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "Incident");
            }
            Incident incident = context.Incidents.Find(id);
            if (incident == null)
            {
                return RedirectToAction("List", "Incident");
            }
            return View("Delete");
        }
        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if (incident.IncidentId == 0)
                {
                    context.Incidents.Update(incident);
                }
                else
                {
                    context.Incidents.Update(incident);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Incident");
            }
            else
            {
                ViewBag.Action = (incident.IncidentId == 0) ? "Add" : "Edit";
                return View(incident);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            Incident incident = context.Incidents.Find(id);
            context.Incidents.Remove(incident);
            context.SaveChanges();
            return RedirectToAction("List", "Incident");
        }
    }
}
