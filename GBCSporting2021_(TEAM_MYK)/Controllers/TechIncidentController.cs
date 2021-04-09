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
            var temp = TempData["message"];
            var techs = context.Technicians.OrderBy(t => t.TechnicianId).ToList();
            ViewBag.listOfTech = techs;
            ViewBag.Action = "Select";
            return View();
        }

        public IActionResult List(int id)
        {
            if(id == 0)
            {
                TempData["message"] = "*Please select Technician";
                return RedirectToAction("Get");
            }
            else
            {
                TempData.Clear();
                ViewBag.Incident = context.Incidents
                .Include(i => i.Customer)
                .Include(i => i.Product)
                .Where(c => c.TechnicianId == id).ToList();
                return View("List");
            }     
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.tech = context.Technicians.Find(id).Name;
            ViewBag.Action = "Edit";
            var incident = context.Incidents
                .Include(i => i.Customer)
                .Include(i => i.Product)
                .FirstOrDefault(i => i.IncidentId == id);
            return View(incident);
        }

        [HttpPost]
        public RedirectToActionResult Edit(Incident incident)
        {        
            context.Incidents.Update(incident);
            context.SaveChanges();
            return RedirectToAction("List", "TechIncident");  
        }   
    }
}
