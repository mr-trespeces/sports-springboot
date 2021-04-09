using Microsoft.AspNetCore.Mvc;
using GBCSporting2021__TEAM_MYK_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class TechIncidentController : Controller
    {

        private SportingContext context { get; set; }

        public TechIncidentController(SportingContext ctx)
        {
            context = ctx;
        }

        public IActionResult Get()
        {
            var techs = context.Technicians.OrderBy(t => t.TechnicianId).ToList();
            ViewBag.listOfTech = techs;
            ViewBag.Action = "Select";
            return View();
        }
        

        [HttpGet]
        public IActionResult List(int id )
        {
                ViewBag.Incident = context.Incidents
                .Include(i => i.Customer)
                .Include(i => i.Product)
                .Where(c => c.TechnicianId == id).ToList();              
            return View("List");
        }

      /*   [HttpPost]
       public IActionResult List(Incident inci)
        {
            var techId = context.Incidents
            .Include(c => c.Customer)
            .Include(c => c.Product)
            .Where(t => t.TechnicianId == inci.TechnicianId).ToList();
            ViewBag.List = techId;

            var assignedTech = context.Technicians
                                .FirstOrDefault(t => t.TechnicianId == inci.TechnicianId);

            if (ModelState.IsValid)
            {
                TempData["message"] = $"Product {assignedTech.Name} was successfully edited.";
                return RedirectToAction("List", "TechIncident", inci);
            }
            else
            {
                ViewBag.Action = (inci.TechnicianId == 0) ? "Get" : "List";
                return RedirectToAction("List", "TechIncident", inci);
            }
        } 
    */
    }
}
