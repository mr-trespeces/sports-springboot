﻿using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext context { get; set; }

        public HomeController(ProductContext ctx)
        {
            context = ctx;
            // hello
            // hi
            // hiiiii
        }

        public IActionResult Index()
        {
            

            return View();
        }
    }
}