using JoeVideoStore.Contexts;
using JoeVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JoeVideoStore.Controllers
{
    public class RentalCustomerController : Controller
    {

        DataBaseContext db = new DataBaseContext();

        [HttpGet]
        public ActionResult Index()
        {
            var customers = db.Customers.ToList();

            return View(customers);
        }

        [HttpGet]
        public ActionResult SortByName()
        {
            var customers = from customer in db.Customers
                            orderby (customer.LastName) ascending
                            select customer;

            return View(customers);
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(RentalCustomer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var customer = db.Customers.Find(id);

            if (customer == null) return HttpNotFound();


            return View(customer);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Address, Email")] RentalCustomer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }



        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var customer = db.Customers.Find(id);

            if (customer == null) return HttpNotFound();


            return View(customer);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteValid(int id)
        {
            var customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: RentalCustomer/Details/5
        public ActionResult Details(int id)
        {
            var customer = db.Customers.Find(id);

            ViewBag.movieTitles = (from mv in db.Movies
                                   join rm in db.RentalMovies
                                   on mv.Id equals rm.MovieId
                                   where rm.CustomerId == id
                                   select mv).ToList();

            return View(customer);
        }


        protected override void Dispose(bool disposing)
        {
            if (db != null)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
