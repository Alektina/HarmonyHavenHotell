using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HarmonyHaven.Models;
using Microsoft.AspNetCore.Mvc;

namespace HarmonyHaven.Controllers
{
    public class CheckoutsController : Controller
    {
        private readonly ApplicationContext Context;
        public CheckoutsController(ApplicationContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(string Fullname, string Email,
            int PhoneNumber, string Country, string City,
            string Address, int ZipCode, string CardHoldersName, int CardNumber,
            string CardExpiryDate, int CVC)
        {
            Checkout NewCheckout = new Checkout();
            if (NewCheckout == null)
            {
                NewCheckout.Fullname = Fullname;
                NewCheckout.Email = Email;
                NewCheckout.PhoneNumber = PhoneNumber;
                NewCheckout.Country = Country;
                NewCheckout.City = City;
                NewCheckout.Address = Address;
                NewCheckout.ZipCode = ZipCode;
                NewCheckout.CardHoldersName = CardHoldersName;
                NewCheckout.CardNumber = CardNumber;
                NewCheckout.CardExpiryDate = CardExpiryDate;
                NewCheckout.CVC = CVC;
                Context.Update(NewCheckout);
                Context.Checkouts.Add(NewCheckout);
                Context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public string MyCheckout()
        {
            return "Checkout with your shopping cart products.";
        }

    }
}
