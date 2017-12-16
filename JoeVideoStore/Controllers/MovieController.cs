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
    public class MovieController : Controller
    {

        MovieContext db = new MovieContext();


        [HttpGet]
        public ActionResult Index()
        {
            var movies = db.Movies.ToList();

            return View(movies);
        }

        [HttpGet]
        public ActionResult SortByTitle()
        {
            var movies = from movie in db.Movies
                         orderby movie.Title ascending
                         select movie;

            return View(movies);
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


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
      
        // From Microsoft article (link shown below)
        // Edit and Delete will be similar
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);            

            var movie = db.Movies.Find(id);

            if (movie == null) return HttpNotFound();

            
            return View(movie);
        }

 
        // https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/examining-the-edit-methods-and-edit-view
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include= "ID,Title,Length,Rating, Genre")] MovieModel movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }



        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var movie = db.Movies.Find(id);

            if (movie == null) return HttpNotFound();


            return View(movie);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteValid(int id)
        {
            var movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
