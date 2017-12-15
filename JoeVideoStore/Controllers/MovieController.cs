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
        // From Microsoft documentation Demo 
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);            

            var movie = db.Movies.Find(id);

            if (movie == null) return HttpNotFound();

            
            return View(movie);
        }

        // POST: Movie/Edit/5
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
