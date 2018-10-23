using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        NorthWindDbEntities db = new NorthWindDbEntities();
        public ActionResult Index()
        {
            return View(db.tblCategories.ToList());
        }
    }
}