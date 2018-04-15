using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace Fix24h_AdobeBricks_V1.Controllers
{
    public class NewsController : Controller
    {
        private AdobeBricksDBContext db = new AdobeBricksDBContext();
        // GET: News
        public ActionResult News()
        {
            ViewBag.NewsCT = new PostNewsDAO().ListByGroupCT(5);
            ViewBag.NewsTT = new PostNewsDAO().ListByGroupTT(5);
            ViewBag.News2 = new PostNewsDAO().ListByGroup(4);
            ViewBag.News1 = new PostNewsDAO().ListByGroup();
            return View();
        }

        public ActionResult NewsDetail(int id)
        {
            ViewBag.News = new PostNewsDAO().ListByGroup(2);
            ViewBag.News2 = new PostNewsDAO().ListByGroup(4);
            ViewBag.News1 = new PostNewsDAO().ListByGroup();
            var model = new PostNewsDAO().ViewDetail(id);
            return View(model);
        }
    }
}