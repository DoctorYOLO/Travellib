using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Travel_Lib2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Newbook",
                url: "{sub}",
                defaults: new { controller = "AddBook", action = "Index" },
                constraints: new { sub = new NotEqual(new string[] { "Home", "AddBook" }) }
            );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );           
            
        }

        public class NotEqual : IRouteConstraint
        {
            private string[] _match = null;

            public NotEqual(string[] match)
            {
                _match = match;
            }

            public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
            {
                foreach (var controllername in _match)
                {
                    if (String.Compare(values[parameterName].ToString(), controllername, true) == 0)
                        return false;
                }
                return true;
            }
        }
    }
}
