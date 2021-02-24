﻿using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class ProductController : Controller
    {

        private SportingContext context { get; set; }

        public ProductController(SportingContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult List()
        {
            var product = context.Products;
            return View("List", product);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Edit";
            return View("Edit", new Product());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var product = context.Products
                .FirstOrDefault(c => c.ProductId == id);
            return View(product);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Product prod = context.Products.Find(id);
            if (prod == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("Delete");
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            string action = (product.ProductId == 4) ? "Edit" : "Edit";

            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    context.Products.Add(product);
                }
                else
                {
                    context.Products.Update(product);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = action;
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            Product product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List", "Product");
        }
    }
}
