using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class TechnicianController : Controller
    {
        private SportingContext context { get; set; }

        public TechnicianController(SportingContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        [Route("technicians")]
        public IActionResult List()
        {
            var technician = context.Technicians;
            return View("List", technician);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Technician());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var technician = context.Technicians
                .FirstOrDefault(c => c.TechnicianId == id);
            return View(technician);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            ViewBag.Tech = context.Technicians
                .FirstOrDefault(c => c.TechnicianId == id);
            if (id == null)
            {
                return RedirectToAction("List", "Technician");
            }
            Technician tech = context.Technicians.Find(id);
            if (tech == null)
            {
                return RedirectToAction("List", "Technician");
            }
            return View("Delete");
        }
        [HttpPost]
        public IActionResult Edit(Technician tech)
        {
            if (ModelState.IsValid)
            {
                if (tech.TechnicianId == 0)
                {
                    context.Technicians.Update(tech);
                }
                else
                {
                    context.Technicians.Update(tech);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Technician");
            }
            else
            {
                ViewBag.Action = (tech.TechnicianId == 0) ? "Add" : "Edit";
                return View(tech);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            Technician tech = context.Technicians.Find(id);
            context.Technicians.Remove(tech);
            context.SaveChanges();
            return RedirectToAction("List", "Technician");
        }
    }
}

