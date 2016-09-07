using System.Web.Mvc;

namespace ExternalControllersLibrary
{
    public class HomeController: Controller
    {
        public JsonResult Index()
        {
            return Json("Okay, I am Index action from ExternalControllersLibrary namespase", JsonRequestBehavior.AllowGet);
        }
    }
}
