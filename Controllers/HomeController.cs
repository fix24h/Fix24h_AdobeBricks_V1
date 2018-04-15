using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using CsQuery;

namespace Fix24h_AdobeBricks_V1.Controllers
{
    public class HomeController : Controller
    {
        private AdobeBricksDBContext db = new AdobeBricksDBContext();
     
        public ActionResult Index()
        {
            ViewBag.Product = new ProductDao().getProduct();
		    ViewBag.ProductCategory = new ProjectMenuDao().getProjectMenuDao();
            ViewBag.ProjectProduct = new ProjectProductDao().getProjectProductDao();
            ViewBag.Projects = new ProjectDao().getProjectDao();
            ViewBag.Sliders = new SlideDAO().SlideShow();
            ViewBag.News = new PostNewsDAO().ListByGroup(4);
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MainMenu()
        {
            var model = new MenuDAO().ListByGroupId();
            return PartialView(model);
        }

        public ActionResult BusinessAreas()
        {
            
            return View();
        }
        public ActionResult BusinessAreasDetail()
        {

            return View();
        }
        public ActionResult BusinessAreasDetail1()
        {

            return View();
        }
        public ActionResult BusinessAreasDetail2()
        {

            return View();
        }
        public ActionResult BusinessAreasDetail3()
        {

            return View();
        }
        public ActionResult ttt()
        {
            //var dom = CQ.CreateFromUrl("http://tuoitre.vn/tin/phap-luat/20140921/nguyen-chu-tich-agribank-bi-bat/648532.html");
            //CQ divs = dom.Select("div.fck");
            //string html = divs.RenderSelection();
            //return Content(html);
            return View();
        }
    }
}