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
        [Route("incidents")]
        public IActionResult List(string filter = "")
        {
            if (filter == "openincidents")
            {
                var inci = context.Incidents
                   .Include(c => c.Customer)
                   .Include(c => c.Product)
                   .Where(c => c.DateOpened == c.DateClosed);

                ViewBag.Filter = "openincidents";
                return View("List", inci);
            }
            else if(filter == "unassigned"){
                var inci = context.Incidents
                    .Include(c => c.Customer)
                    .Include(c => c.Product)
                    .Where(c => c.TechnicianId == null);
                ViewBag.Filter = "unassigned";
                return View("List", inci);
            }
            else
            {
                ViewBag.Filter = "all";
                var inci = context.Incidents
                .Include(c => c.Customer)
                .Include(c => c.Product);
                return View("List", inci);
            }

        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewData["CustomerId"] = new SelectList(context.Customers, "CustomerId", "Slug");
            ViewData["ProductId"] = new SelectList(context.Products, "ProductId", "Name");
            ViewData["TechnicianId"] = new SelectList(context.Technicians, "TechnicianId", "Name");         

            ViewBag.Action = "Add";
            return View("Edit", new Incident());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["CustomerId"] = new SelectList(context.Customers, "CustomerId", "Slug");
            ViewData["ProductId"] = new SelectList(context.Products, "ProductId", "Name");
            ViewData["TechnicianId"] = new SelectList(context.Technicians, "TechnicianId", "Name");

            ViewBag.Action = "Edit";   
                   var inci = context.Incidents
                      .FirstOrDefault(c => c.IncidentId == id);

            return View(inci);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            ViewBag.Incident = context.Incidents
                .FirstOrDefault(c => c.IncidentId == id);
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
            ViewData["CustomerId"] = new SelectList(context.Customers, "CustomerId", "Slug");
            ViewData["ProductId"] = new SelectList(context.Products, "ProductId", "Name");
            ViewData["TechnicianId"] = new SelectList(context.Technicians, "TechnicianId", "Name");

            var techId = Request.Form["TechnicianId"];
            var prodId = Request.Form["ProductId"];
            var custId = Request.Form["CustomerId"];

            if (ModelState.IsValid)
            {    
                if (incident.IncidentId == 0)
                {

                    context.Incidents.Add(incident);
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
