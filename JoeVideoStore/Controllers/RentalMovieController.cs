using JoeVideoStore.Contexts;
using JoeVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoeVideoStore.Controllers
{
    public class RentalMovieController : Controller
    {

        DataBaseContext db = new DataBaseContext();


        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.db = db;
            var rentals = db.RentalMovies.ToList();
 
            return View(rentals);
        }


     
        public ActionResult Create(int? movieId)
        {
            if (movieId != null)
            {              
                ViewBag.movieid   = movieId;
                // Mix query styles..
                ViewBag.customers = (from customer in db.Customers
                                     orderby (customer.LastName) ascending
                                     select customer)
                                     .Select(c => new SelectListItem {
                                        Text = c.FirstName + " " + c.LastName,
                                        Value = c.Id.ToString()
                                     }).ToList();                                              

                return View();
            }          

            return RedirectToAction("Index");
        }

        
        [HttpPost]
        public ActionResult Create(string movieid, string customerid)
        {
            if (ModelState.IsValid)
            {
                // "Id" is generated as primary key and "Rentend" when movie returns from customer.
                RentalMovie movie = new RentalMovie()
                {
                    MovieId = Int32.Parse(movieid),
                    CustomerId = Int32.Parse(customerid),
                    RentStart = DateTime.Now,
                    RentEnd = DateTime.Now
                };

                db.RentalMovies.Add(movie);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
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
