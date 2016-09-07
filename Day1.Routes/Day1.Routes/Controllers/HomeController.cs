using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1.Routes.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.RouteInfo = RouteData.DataTokens["RouteName"];
            return View();
        }

        public JsonResult Sum()
        {
            var argA = RouteData.Values.ContainsKey("a")? RouteData.Values["a"] : 0 ;
            var argB = RouteData.Values.ContainsKey("b") ? RouteData.Values["b"] : 0;
            var a = Int32.Parse(argA.ToString());
            var b = Int32.Parse(argB.ToString());
            var result = "a + b = " + (a + b);
            return Json(result, JsonRequestBehavior.AllowGet);
        }


    }
}