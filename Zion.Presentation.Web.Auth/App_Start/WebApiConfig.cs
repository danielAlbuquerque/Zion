using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Zion_Presentation_Web_Auth {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}