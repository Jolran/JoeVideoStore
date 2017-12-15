using JoeVideoStore.Contexts;
using JoeVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoeVideoStore.Controllers
{
    public class MovieController : Controller
    {

        MovieContext db = new MovieContext();


        // GET: Movie
        public ActionResult Index()
        {
            var movies = db.Movies.ToList();

            return View(movies);
        }

        public ActionResult SortByTitle()
        {
            var movies = from movie in db.Movies
                         orderby movie.Title ascending
                         select movie;

            return View(movies);
        }



        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(MovieModel movie)
        {

            if (ModelState.IsValid)
            { 
                db.Movies.Add(movie);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
           
            return View();
            
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
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

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
