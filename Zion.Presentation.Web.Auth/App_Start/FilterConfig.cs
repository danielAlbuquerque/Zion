using System.Web;
using System.Web.Mvc;

namespace Zion_Presentation_Web_Auth {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}