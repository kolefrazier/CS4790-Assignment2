using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Greeting"] = "Kole's Game Library\nAssignment 1";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
