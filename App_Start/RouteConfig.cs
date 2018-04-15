using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fix24h_AdobeBricks_V1_V1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "NewsDetail",
                url: "tin-tuc/{metatitle}-{id}",
                defaults: new { controller = "News", action = "NewsDetail", id = UrlParameter.Optional },
                namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
            );

            routes.MapRoute(
                name: "BusinessAreas",
                url: "Linh-vuc-kinh-doanh",
                defaults: new { controller = "Home", action = "BusinessAreas", id = UrlParameter.Optional },
                namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
            );
            routes.MapRoute(
                name: "BusinessAreasDetail",
                url: "Linh-vuc-kinh-doanh/San-gach-khong-nung-IDC",
                defaults: new { controller = "Home", action = "BusinessAreasDetail", id = UrlParameter.Optional },
                namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
            );

            routes.MapRoute(
               name: "BusinessAreasDetail1",
               url: "Linh-vuc-kinh-doanh/Xay-dung-IDC",
               defaults: new { controller = "Home", action = "BusinessAreasDetail1", id = UrlParameter.Optional },
               namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
           );

            routes.MapRoute(
               name: "BusinessAreasDetail2",
               url: "Linh-vuc-kinh-doanh/Kinh-doanh-vat-lieu-xay-dung-IDC",
               defaults: new { controller = "Home", action = "BusinessAreasDetail2", id = UrlParameter.Optional },
               namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
           );

            routes.MapRoute(
               name: "BusinessAreasDetail3",
               url: "Linh-vuc-kinh-doanh/Van-tai-IDC",
               defaults: new { controller = "Home", action = "BusinessAreasDetail3", id = UrlParameter.Optional },
               namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
           );

            routes.MapRoute(
               name: "Products",
               url: "san-pham/{metatitle}-{id}",
               defaults: new { controller = "Products", action = "ProductsDetail", id = UrlParameter.Optional },
               namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
           );

            routes.MapRoute(
               name: "Library",
               url: "Thu-vien",
               defaults: new { controller = "Products", action = "Library", id = UrlParameter.Optional },
               namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
           );

            routes.MapRoute(
               name: "Construction",
               url: "Cong-trinh",
               defaults: new { controller = "Products", action = "Construction", id = UrlParameter.Optional },
               namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
           );

            routes.MapRoute(
                name: "About",
                url: "Gioi-thieu",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional },
                namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "Lien-he",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional },
                namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
            );

            routes.MapRoute(
                name: "News",
                url: "Tin-tuc",
                defaults: new { controller = "News", action = "News", id = UrlParameter.Optional },
                namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
            );

            //routes.MapRoute(
            //    name: "NewsTT",
            //    url: "Tin-tuc",
            //    defaults: new { controller = "News", action = "News", id = UrlParameter.Optional },
            //    namespaces: new[] { "Fix24h_AdobeBricks_V1.Controllers" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"Fix24h_AdobeBricks_V1.Controllers"}
            );
        }
    }
}
