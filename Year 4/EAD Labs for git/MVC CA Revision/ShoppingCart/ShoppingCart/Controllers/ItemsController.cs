using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class ItemsController : Controller
    {
        // Static to retain state: todo use Entity Framework

        // Items to add to cart
        private static List<Item> items = new List<Item>()
         {
            new Item {Code = "123", Description = "De Longhi Coffee Maker", Price  = 180 },
            new Item {Code = "456", Description = "Nespresso Pod machine", Price  = 90 },
            new Item {Code = "789", Description = "Coffee Grinder", Price  = 30 },
        };

        // Empty Cart
        private static Cart cart = new Cart();

        // GET: Items
        public ActionResult Index()
        {
            ViewBag.TotalPrice = cart.CalculateTotalPrice();
            return View(items);
        }

        // Add to cart
        public ActionResult Add(String code)
        {
            try
            {
                // Lookup Product
                foreach (var item in items)
                {
                    if(item.Code == code)
                    {
                        // Add to cart
                        cart.AddItem(item);
                        break;
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
