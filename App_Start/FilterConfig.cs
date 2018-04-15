using System.Web;
using System.Web.Mvc;

namespace Fix24h_AdobeBricks_V1_V1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
