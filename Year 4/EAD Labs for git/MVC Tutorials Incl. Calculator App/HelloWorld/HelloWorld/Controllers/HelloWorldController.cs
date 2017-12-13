using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/?name=value

        public ActionResult Welcome(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}