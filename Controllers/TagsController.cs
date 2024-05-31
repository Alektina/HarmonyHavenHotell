using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarmonyHaven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HarmonyHaven.Controllers
{
    public class TagsController : Controller
    {
        private readonly ApplicationContext Context;

        public TagsController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index()
        {
            List<Tag> AllTags = Context.Tags.Include(p => p.Products).ToList();
            return View(AllTags); ;
        }
        public IActionResult Details(int id)
        {
            Tag CurrentTag = Context.Tags.Include(p => p.Products).Where(x => x.Id == id).FirstOrDefault();
            return View(CurrentTag);

        }
    }
}