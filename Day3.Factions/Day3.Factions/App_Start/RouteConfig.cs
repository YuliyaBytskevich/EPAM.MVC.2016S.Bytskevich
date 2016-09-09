using System.Web.Mvc;
using System.Web.Routing;

namespace Day3.Factions
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           routes.MapRoute(
                name: "ConcretePerson",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = 1 }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
