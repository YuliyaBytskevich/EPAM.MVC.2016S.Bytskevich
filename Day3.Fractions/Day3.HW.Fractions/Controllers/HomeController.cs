using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3.HW.Fractions.Models;

namespace Day3.HW.Fractions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
            Crew crew = new Crew();
            return View("Person", crew.people[id - 1]);
        }

        [ChildActionOnly]
        public ActionResult Header(string side)
        {
            return PartialView("Header", side);
        }

        public ActionResult ChangeSide()
        {
            return PartialView();
        }
    }
}