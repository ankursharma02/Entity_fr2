using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Curd3.Models;
namespace MVC_Curd3.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (DbModels dbmodel1 = new DbModels())
            {
                return View(dbmodel1.Customers.ToList());
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels dbmodel = new DbModels())
            {
                return View(dbmodel.Customers.Where(x=>x.ID==id).FirstOrDefault());
            }
                
            
       }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer  customer
            )
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels dbmodedl = new DbModels())
                {
                    dbmodedl.Customers.Add(customer);
                    dbmodedl.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbmodel = new DbModels())
            {
                return View(dbmodel.Customers.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels dbmodel = new DbModels())
                {
                    dbmodel.Entry(customer).State = EntityState.Modified;
                    dbmodel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels dbmodel = new DbModels())
            {
                return View(dbmodel.Customers.Where(x => x.ID == id).FirstOrDefault());
            }
                
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels dbmodedl = new DbModels())
                {
                    Customer customer = dbmodedl.Customers.Where(x => x.ID == id).FirstOrDefault();
                    dbmodedl.Customers.Remove(customer);
                    dbmodedl.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
