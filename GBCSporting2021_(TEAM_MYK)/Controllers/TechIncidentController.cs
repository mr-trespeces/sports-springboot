using Microsoft.AspNetCore.Mvc;
using GBCSporting2021__TEAM_MYK_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
            if (HttpContext.Session.GetString("SessionName") != null)
            {
                return RedirectToAction("List");
            }
            else
            {
                var techs = context.Technicians.OrderBy(t => t.TechnicianId).ToList();
                ViewBag.listOfTech = techs;
                ViewBag.Action = "Select";
                return View();
            }
        }

        public IActionResult Switch()
        {
            if (HttpContext.Session.GetString("SessionName") != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Get");
            }
            else
            {
                var techs = context.Technicians.OrderBy(t => t.TechnicianId).ToList();
                ViewBag.listOfTech = techs;
                ViewBag.Action = "Select";
                return View("Get");
            }
        }

        [HttpGet]
        public IActionResult List(int? id )
        {
            if (HttpContext.Session.GetString("SessionName") != null)
            {
                ViewBag.Name = JsonConvert.DeserializeObject<Technician>(HttpContext.Session.GetString("SessionName")).Name;
                int sessID = JsonConvert.DeserializeObject<Technician>(HttpContext.Session.GetString("SessionName")).TechnicianId;

                var techId = context.Incidents
                .Include(c => c.Customer)
                .Include(c => c.Product)
                .Where(t => t.TechnicianId == sessID).ToList();


                ViewBag.Incident = techId;

                return View("List");

            }
            else if (id != null)
            {

                var techId = context.Incidents
                .Include(c => c.Customer)
                .Include(c => c.Product)
                .Where(t => t.TechnicianId == id).ToList();

                ViewBag.Incident = techId;

                var assignedTech = context.Technicians
                                    .FirstOrDefault(t => t.TechnicianId == id);
                Technician tech = assignedTech;
                HttpContext.Session.SetString("SessionName", JsonConvert.SerializeObject(tech));
                ViewBag.Name = JsonConvert.DeserializeObject<Technician>(HttpContext.Session.GetString("SessionName")).Name;
                return View("List");
            }
            else
            {
                ViewBag.Message = "Choose Technician";
                return View("Get");
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
