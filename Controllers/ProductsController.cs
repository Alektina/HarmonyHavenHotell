using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarmonyHaven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HarmonyHaven.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationContext Context;
        public ProductsController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index()
        {
            List<Product> AllProducts = Context.Products.Include(t => t.Tags).Include(p => p.Categories).ToList();
            // Fetch categories, tags
            List<Category> allCategories = Context.Categories.ToList(); // Assuming your categories are stored in a DbSet<Category>
            List<Tag> allTags = Context.Tags.ToList();


            ViewBag.Categories = allCategories;
            ViewBag.Tags = allTags;

            return View(AllProducts);

        }
        public IActionResult Details(int id)
        {
            Product CurrentProduct = new Product();
            CurrentProduct = Context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(CurrentProduct);
        }
        public IActionResult ProductsByCategory(int categoryId)
        {
            var productsInCategory = Context.Products.Where(p => p.Categories.Any(c => c.Id == categoryId)).ToList();
            List<Category> allCategories = Context.Categories.ToList();
            List<Tag> allTags = Context.Tags.ToList();


            ViewBag.Categories = allCategories;
            ViewBag.Tags = allTags;
            return View(productsInCategory);
        }

        public IActionResult ProductsByTag(int tagId)
        {
            var productsWithTag = Context.Products.Where(p => p.Tags.Any(t => t.Id == tagId)).ToList();
            List<Category> allCategories = Context.Categories.ToList(); // Assuming your categories are stored in a DbSet<Category>
            List<Tag> allTags = Context.Tags.ToList();


            ViewBag.Categories = allCategories;
            ViewBag.Tags = allTags;

            return View(productsWithTag);
        }


    }
}