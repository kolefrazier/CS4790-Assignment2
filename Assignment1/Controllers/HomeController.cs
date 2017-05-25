using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			return View(GameLibrary.MyGameLibrary);
		}

		[HttpGet]
		public ViewResult AddGame()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddGame(Game game)
		{
			if (ModelState.IsValid)
			{
				GameLibrary.AddGame(game);
				return RedirectToAction("Index");
			}
			return View(game);
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
