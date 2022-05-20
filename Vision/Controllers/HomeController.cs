using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly ITest _manager;

		public HomeController(ILogger<HomeController> logger, ITest manager)
		{
			_logger = logger;
			_manager = manager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			var db = new DbContext();
			var product = db.Tests.ToList();
			var model = new ViewModel { Tests = product };
			return View(model);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string name, double price) {
			_manager.createTest(name, price);

			return RedirectToAction("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
