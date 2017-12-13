using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

       // POST: Calc
       [HttpPost]
       public ActionResult Index(Models.Calculator calc)
        {
            if (ModelState.IsValid)
            {
                calc.Result = calc.getAnswer();
                return RedirectToAction("Answer", calc);
            }
            // Show the form again (for correction if errors)
            return View(calc);
        }

        public ActionResult Answer(Models.Calculator calc)
        {
            return View(calc);
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}
