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

        const string SessionName = "";
        const string SessionId = "";
        private SportingContext context { get; set; }

        public TechIncidentController(SportingContext ctx)
        {
            context = ctx;
        }

        public IActionResult Get()
        {
            if (HttpContext.Session.GetString(SessionName) != null)
            {
                return View("List");
            }
            else
            {
                var techs = context.Technicians.OrderBy(t => t.TechnicianId).ToList();
                ViewBag.listOfTech = techs;
                ViewBag.Action = "Select";
                return View();
            }
        }
        

        [HttpGet]
        public IActionResult List(int id )
        {
            var techId = context.Incidents
            .Include(c => c.Customer)
            .Include(c => c.Product)
            .Where(t => t.TechnicianId == id).ToList();

            ViewBag.Incident = techId;
            var assignedTech = context.Technicians
                                .FirstOrDefault(t => t.TechnicianId == id);

            if (assignedTech != null)
            {
                HttpContext.Session.SetString(SessionName, assignedTech.Name);
                HttpContext.Session.SetInt32(SessionId, assignedTech.TechnicianId);

                ViewBag.Name = HttpContext.Session.GetString(SessionName.ToString());
                ViewBag.Age = HttpContext.Session.GetInt32(SessionId);
                return View("List");
            }
            else
            {
                ViewBag.Message = "Choose Technician";
                return View("Get");
            }





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
