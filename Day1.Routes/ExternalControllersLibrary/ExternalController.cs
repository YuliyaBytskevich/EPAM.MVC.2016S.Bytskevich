using System.Web.Mvc;

namespace ExternalControllersLibrary
{
    public class ExternalController: Controller
    {
        public JsonResult SayHello(string userName = "Anonym")
        {
            var message = "ExternalController: Hello, " + userName + "! ^_^";
            return Json(message, JsonRequestBehavior.AllowGet);
        }
    }
}
