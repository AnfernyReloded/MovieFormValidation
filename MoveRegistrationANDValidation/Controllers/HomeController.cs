using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoveRegistrationANDValidation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoveRegistrationANDValidation.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View(new Movie());
        }

        public IActionResult DisplayMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return View("MovieForm", movie);
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
