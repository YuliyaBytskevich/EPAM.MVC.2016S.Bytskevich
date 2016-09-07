using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1.Routes.Controllers
{
    public class GreetingsController : Controller
    {
        // GET: Greetings
        public ActionResult Greet(string name = "anonym")
        {
            ViewBag.PersonName = name;
            return View();
        }
    }
}