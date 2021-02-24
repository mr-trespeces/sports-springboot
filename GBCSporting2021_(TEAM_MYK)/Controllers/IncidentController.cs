using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class IncidentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
