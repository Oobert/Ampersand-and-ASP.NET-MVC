using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "peopleapi",
                url: "api/people/{id}",
                defaults: new { controller = "People", action = "Index", Id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "templateJS",
                url: "templatejs",
                defaults: new { controller = "Template", action = "templatejs" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{*.}",
                defaults: new { controller = "Home", action = "Index"}
            );
        }
    }
}
