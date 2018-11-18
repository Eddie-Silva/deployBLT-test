using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLT.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BLT.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GettingStarted()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Features()
        {
            ViewData["Message"] = "Display Features here.";

            return View();
        }

        public IActionResult CreateFeature()
        {
            ViewData["Message"] = "This is the main event.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
