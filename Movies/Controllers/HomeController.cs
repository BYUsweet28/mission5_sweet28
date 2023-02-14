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
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieContext movie)
        {
            _logger = logger;
            _movieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult NewMovie(MovieResponse mr)
        {
            _movieContext.Add(mr);
            _movieContext.SaveChanges();

            return View("Confirmation", mr);
        }

        public IActionResult MyPodcast()
        {
            return View("MyPodcast");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
