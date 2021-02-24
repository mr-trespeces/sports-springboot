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
            if (id == null)
            {
            }
            Product prod = context.Products.Find(id);
            if (prod == null)
            {
            }
            return View("Delete");
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductId == 0)
                {
                    context.Products.Update(product);
                }
                else
                {
                    context.Products.Update(product);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Product");
            }
            else
            {
                ViewBag.Action = (product.ProductId == 0) ? "Add" : "Edit";
                return View(product);
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
