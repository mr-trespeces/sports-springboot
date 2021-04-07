using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class HomeController : Controller
    {
        private SportingContext context { get; set; }

        public HomeController(SportingContext ctx)
        {
            context = ctx;
        }
        [Route("about")]
        public IActionResult About() {
            return View();
        }
       
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
