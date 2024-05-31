using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarmonyHaven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HarmonyHaven.Controllers
{
    public class CartsController : Controller
    {
        private readonly ApplicationContext Context;

        public CartsController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddToCart(int id)
        {
            Product CurrentProduct = Context.Products.FirstOrDefault(x => x.Id == id);
            CartItem ExistingCartItem = Context.CartItems
                .FirstOrDefault(x => x.CartId == 1 && x.ProductId == CurrentProduct.Id);
            if (ExistingCartItem != null)
            {
                ExistingCartItem.Quantity = ExistingCartItem.Quantity + 1;
                ExistingCartItem.CartItemTotal = ExistingCartItem.CartItemTotal + CurrentProduct.ProductPrice;
                Context.CartItems.Update(ExistingCartItem);
                Cart Cart = Context.Carts.FirstOrDefault(x => x.Id == 1);
                Cart.CartTotal = Cart.CartTotal + CurrentProduct.ProductPrice;
                Context.SaveChanges();
            }
            else
            {
                CartItem CartItem = new CartItem();
                CartItem.ProductId = CurrentProduct.Id;
                CartItem.Quantity = 1;
                CartItem.CartItemTotal = CurrentProduct.ProductPrice;
                Cart Cart = Context.Carts.FirstOrDefault(x => x.Id == 1);
                Cart.CartTotal = Cart.CartTotal + CartItem.CartItemTotal;
                Cart.CartItems = new List<CartItem>();
                Cart.CartItems.Add(CartItem);
                Context.Carts.Update(Cart);
                Context.SaveChanges();
            }

            return RedirectToAction(nameof(Details));

        }
        public IActionResult AddOneItem(int id)
        {
            Cart ThisCart = Context.Carts.FirstOrDefault(x => x.Id == 1);
            Product CurrentProduct = Context.Products.FirstOrDefault(x => x.Id == id);
            CartItem CurrentCartItem = Context.CartItems
                .FirstOrDefault(x => x.CartId == 1 && x.ProductId == id);

            CurrentCartItem.Quantity = CurrentCartItem.Quantity + 1;
            CurrentCartItem.CartItemTotal = CurrentCartItem.CartItemTotal + CurrentProduct.ProductPrice;
            Context.CartItems.Update(CurrentCartItem);
            ThisCart.CartTotal = ThisCart.CartTotal + CurrentProduct.ProductPrice;
            Context.Carts.Update(ThisCart);
            Context.SaveChanges();

            return RedirectToAction(nameof(Details));

        }

        public IActionResult RemoveOneItem(int id)

        {

            Cart ThisCart = Context.Carts.FirstOrDefault(x => x.Id == 1);
            Product CurrentProduct = Context.Products.FirstOrDefault(x => x.Id == id);
            CartItem CurrentCartItem = Context.CartItems
                .FirstOrDefault(x => x.CartId == 1 && x.ProductId == id);


            if (CurrentCartItem != null)
            {
                if (CurrentCartItem.Quantity > 1)

                {
                    CurrentCartItem.Quantity = CurrentCartItem.Quantity - 1;
                    CurrentCartItem.CartItemTotal = CurrentCartItem.CartItemTotal - CurrentProduct.ProductPrice;
                    Context.CartItems.Update(CurrentCartItem);
                    ThisCart.CartTotal = ThisCart.CartTotal - CurrentProduct.ProductPrice;
                    Context.Carts.Update(ThisCart);
                    Context.SaveChanges();
                }

                else if (CurrentCartItem.Quantity <= 1)

                {
                    CurrentCartItem.Quantity = 0;
                    Context.CartItems.Remove(CurrentCartItem);
                    ThisCart.CartTotal = ThisCart.CartTotal - CurrentProduct.ProductPrice;
                    Context.Carts.Update(ThisCart);
                    Context.SaveChanges();
                }
            }

            return RedirectToAction(nameof(Details));
        }
        public IActionResult RemoveAllOfTheseItems(int id)
        {

            Cart ThisCart = Context.Carts.FirstOrDefault(x => x.Id == 1);
            Product CurrentProduct = Context.Products.FirstOrDefault(x => x.Id == id);
            CartItem CurrentCartItem = Context.CartItems
                .FirstOrDefault(x => x.CartId == 1 && x.ProductId == id);
            List<CartItem> AllOfTheseItems = Context.CartItems.ToList();

            foreach (CartItem item in AllOfTheseItems.Where(x => x.ProductId == id))

            {
                ThisCart.CartTotal = ThisCart.CartTotal - (CurrentProduct.ProductPrice * CurrentCartItem.Quantity);
                CurrentCartItem.Quantity = CurrentCartItem.Quantity - 1;
                Context.CartItems.Remove(item);
                Context.Carts.Update(ThisCart);
            }
            Context.SaveChanges();
            return RedirectToAction(nameof(Details));
        }

        public IActionResult EmptyCart(int id)
        {
            List<CartItem> CurrentCartItem = Context.CartItems
                .Where(x => x.Id >= 1).ToList();
            Context.CartItems.RemoveRange(CurrentCartItem);

            Cart ThisCart = Context.Carts.FirstOrDefault(x => x.Id == 1);
            ThisCart.CartTotal = 0;
            Context.Carts.Update(ThisCart);
            Context.SaveChanges();
            return RedirectToAction(nameof(Details));
        }
        public IActionResult Details()
        {
            Cart Cart = Context.Carts
                .Include(ci => ci.CartItems).ThenInclude(p => p.Product).FirstOrDefault(x => x.Id == 1);
            return View(Cart);
        }


        public IActionResult DetailsSek()
        {
            Cart Cart = Context.Carts
                .Include(ci => ci.CartItems).ThenInclude(p => p.Product).FirstOrDefault(x => x.Id == 1);

            foreach (CartItem cartItem in Cart.CartItems)
            {
                cartItem.CartItemTotal /= 10;
            }
            Cart.CartTotal /= 10;


            return View(Cart);
        }

    }
}