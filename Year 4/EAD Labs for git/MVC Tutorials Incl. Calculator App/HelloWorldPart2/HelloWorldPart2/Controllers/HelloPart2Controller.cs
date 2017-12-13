using HelloWorldPart2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldPart2.Controllers
{
    public class HelloPart2Controller : Controller
    {
        // GET: HelloPart2
        public ActionResult Index(User user)
        {
            return View(user);
        }

        // GET: HelloPart2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloPart2/Welcome
        public ActionResult Welcome()
        {
            return View();
        }

        // POST: HelloPart2/Welcome
        [HttpPost]
        public ActionResult Welcome(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // No errors added to ModelState
                    // Redirect to Index, passing user
                    return RedirectToAction("Index", user);
                }
                // Show the form again (for correction)
                return View(user);
            }
            // If anythign goes wrong, catch the exception and display the error (in Views/Shared)
             catch(Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "HelloPart2", "welcome"));
            }
        }

        // GET: HelloPart2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloPart2/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloPart2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloPart2/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
