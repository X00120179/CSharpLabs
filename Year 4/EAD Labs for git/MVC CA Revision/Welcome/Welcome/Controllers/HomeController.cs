using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Welcome.Controllers
{
    public class HomeController : Controller
    {
        // Display the Welcome view if GET to /Home/Welcome
        [HttpGet]
        public ActionResult Welcome()
        {
            ViewBag.Message = "Date: " + DateTime.Now.ToShortDateString() + " Time: " + DateTime.Now.ToLongTimeString();
            return View(); // i.e. Welcome.cshtml view in Home
        }
    }
}