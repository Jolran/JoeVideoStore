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

        DataBaseContext db = new DataBaseContext();


        [HttpGet]
        public ActionResult Index()
        {
   
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
