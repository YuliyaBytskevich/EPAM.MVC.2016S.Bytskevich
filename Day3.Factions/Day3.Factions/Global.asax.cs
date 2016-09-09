using System.Web.Mvc;
using System.Web.Routing;
using Day3.Factions;

namespace Day3.HW.Fractions
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
