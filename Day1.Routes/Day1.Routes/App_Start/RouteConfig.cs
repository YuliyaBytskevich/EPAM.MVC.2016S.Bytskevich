using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace Day1.Routes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // route with static and custom namespace (2)
            routes.MapRoute(
                name: "DefaultExternal",
                url: "External/{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new[] { "ExternalControllersLibrary" }
            );

            // route with regex, compound route constraint
            routes.MapRoute(
               name: "WithCompoundRouteConstraint",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               constraints: new { controller = @"^H\S*" ,
                                  id = new CompoundRouteConstraint(new IRouteConstraint[]
                                  {
                                      new IntRouteConstraint(), 
                                      new RangeRouteConstraint(1, 1000)  
                                  })}, 
               namespaces: new[] { "Day1.Routes.Controllers" }
            );

            // route with regex, compound route constraint and custom namespace (1) 
            routes.MapRoute(
               name: "WithCompoundRouteConstraintAndCustomNamespace",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               constraints: new { controller = @"^H\S*",
                                  id = new CompoundRouteConstraint(new IRouteConstraint[]
                                  {
                                      new IntRouteConstraint(),
                                      new RangeRouteConstraint(1001, 2000)
                                  })},
               namespaces: new[] { "ExternalControllersLibrary" }
            );

            // route with optional and static parameters, constraints
            routes.MapRoute(
                name: "Optional",
                url: "Home/Sum/{a}/{b}",
                defaults: new { controller = "Home", action = "Sum", a = UrlParameter.Optional, b = UrlParameter.Optional },
                constraints: new { a = new DecimalRouteConstraint(),
                                   b = new DecimalRouteConstraint() },
                namespaces: new[] { "Day1.Routes.Controllers" }
            );

            // route with static
            routes.MapRoute(
                name: "Static",
                url: "Greetings/{action}",
                defaults: new { controller = "Greetings", action = "Greet" }
            );

            // default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new[] { "Day1.Routes.Controllers" }
            );
        }
    }

    public static class RouteCollectionExtensions
    {
        public static Route MapRouteWithName(this RouteCollection routes,
        string name, string url, object defaults, object constraints)
        {
            Route route = routes.MapRoute(name, url, defaults, constraints);
            route.DataTokens = new RouteValueDictionary();
            route.DataTokens.Add("RouteName", name);

            return route;
        }
    }
}
