using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fix24h_AdobeBricks_V1.Controllers
{
     public class ProductsController : Controller
    {
        private AdobeBricksDBContext db = new AdobeBricksDBContext();

        // GET: Product
        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Construction()
        {
            return View();
        }

        public ActionResult Library()
        {
            return View();
        }

        public IEnumerable<Product> getProduct()
        {
            return db.Products.Where(x => x.Status == true).ToList();

        }
      

        public bool Delete(int id)
        {
            try
            {
                var product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public ActionResult ProductsDetail(int id)
        {
            ViewBag.ProductDetails = new ProductDetailsDao().getProductDetails(id);
            var categoryID = (from od in db.Products
                            where od.ID == id
                            select new { od.CategoryID }).ToList();
            int t = int.Parse(categoryID[0].CategoryID + "");
            ViewBag.Product = new ProductDao().getProductCata(5,t);

            ViewBag.ProductHot = new ProductDao().getProductHot(8,t);
            return View();
        }
    }
}