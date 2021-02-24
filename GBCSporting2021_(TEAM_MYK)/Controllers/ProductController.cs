using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GBCSporting2021__TEAM_MYK_.Controllers
{
    public class ProductController : Controller
    {

        private ProductContext context { get; set; }

        public ProductController(ProductContext ctx)
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
        public IActionResult Details(int id)
        {
            var product = context.Products
                .FirstOrDefault(c => c.ProductId == id);
            return View(product);
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
        public IActionResult Delete(int id)
        {
            var product = context.Products
                .FirstOrDefault(c => c.ProductId == id);
            return View("Delete", product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            string action = (product.ProductId == 0) ? "Add" : "Edit";

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
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List", "Product");
        }
    }
}
