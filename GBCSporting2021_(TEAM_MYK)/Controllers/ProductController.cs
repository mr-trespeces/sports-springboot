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

        public RedirectToActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("List");
        }

        [HttpGet]
        [Route("products")]
        public IActionResult List()
        {
            var product = context.Products;
            return View("List", product);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
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
            var product = context.Products
                .FirstOrDefault(c => c.ProductId == id);
            ViewBag.Product = product;
            if (id == null)
            {
                return View("List", "Product");
            }
            Product prod = context.Products.Find(id);
            if (prod == null)
            {
                return View("List", "Product");
            }
            return View("Delete");
        }
        [HttpPost]
        public RedirectToActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                TempData["message"] = $"Product {product.Name} was successfully edited.";
                if (product.ProductId == 0)
                {
                    context.Products.Update(product);
                }
                else
                {
                    context.Products.Update(product);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Product", product);
            }
            else
            {
                TempData["message"] = $"Product {product.Name} was successfully added.";
                ViewBag.Action = (product.ProductId == 0) ? "Add" : "Edit";
                return RedirectToAction("List", "Product", product);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {  
            Product product = context.Products.Find(id);
            TempData["message"] = $"Product {product.Name} was successfully deleted.";
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List" , "product");
        }
    }
}
