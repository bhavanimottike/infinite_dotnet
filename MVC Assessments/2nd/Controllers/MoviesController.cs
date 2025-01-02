using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;
using CodeFirst.Repository;
namespace CodeFirst.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository movieRepo;

        public MoviesController()
        {
            movieRepo = new MovieRepository();
        }

        // Display all movies
        public ActionResult Index()
        {
            var movies = movieRepo.GetAll();
            return View(movies);
        }
        public ActionResult Create()
        {
            return View();
        }

        // Create a new movie
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepo.Create(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Edit(int id)
        {
            var movie = movieRepo.GetById(id); 
            if (movie == null)
            {
                return HttpNotFound(); 
            }
            return View(movie); 
        }
        // Edit a movie
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepo.Edit(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

    
        

        // Display movies by year
        public ActionResult MoviesByYear(int year)
        {
            var movies = movieRepo.GetAllMoviesByYear(year);
            return View(movies);
        }
    }
}