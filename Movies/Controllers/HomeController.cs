using Movies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext MovieContext { get; set; }

        //Constructor
        public HomeController(MovieContext movie)
        {
            MovieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovie()
        {

            ViewBag.movies = MovieContext.Categories.ToList();

            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult NewMovie(MovieResponse mr)
        {
            if(ModelState.IsValid)
            {
                MovieContext.Add(mr);
                MovieContext.SaveChanges();

                return View("Confirmation", mr);
            }
            else //If invalid
            {
                ViewBag.movies = MovieContext.Categories.ToList();
                return View("MovieForm", mr);
            }
        }

        public IActionResult MyPodcast()
        {
            return View("MyPodcast");
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = MovieContext.Responses.OrderBy(x => x.CategoryID).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.movies = MovieContext.Categories.ToList();

            var movie = MovieContext.Responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse edit)
        {
            if (ModelState.IsValid)
            {
                MovieContext.Update(edit);
                MovieContext.SaveChanges();

                return View("EditConfirmation", edit);
            }
            else //If invalid
            {
                ViewBag.movies = MovieContext.Categories.ToList();
                return View("MovieForm", edit);
            }
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = MovieContext.Responses.Single(x => x.MovieId == movieid);

            return View();
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse delete)
        {
            MovieContext.Responses.Remove(delete);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
