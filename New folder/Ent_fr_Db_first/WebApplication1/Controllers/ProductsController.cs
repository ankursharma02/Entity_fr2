using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        NorthWindDbEntities db = new NorthWindDbEntities();
        public ActionResult Index(int id)
        {
            List<tblProduct> products= db.tblProducts.Where(x => x.Category_Categoryid == id).ToList();
            return View(products);
        }
        public ActionResult Details(int id)
        {
            return View(db.tblProducts.Single(x=>x.productid==id));
        }
    }
}