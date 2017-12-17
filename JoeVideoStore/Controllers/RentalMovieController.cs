using JoeVideoStore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoeVideoStore.Controllers
{
    public class RentalMovieController : Controller
    {

        RentalMovieContext db = new RentalMovieContext();


        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.rentalContext = db;
            ViewBag.movieContext = new MovieContext();

            var rentals = db.RentalMovies.ToList();
            
            return View(rentals);
        }

        

        // GET: RentalMovie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RentalMovie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RentalMovie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RentalMovie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        

        
    }
}
