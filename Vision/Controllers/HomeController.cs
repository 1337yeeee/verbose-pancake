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

		private readonly IBrand _brandManager;
		private readonly ICategory _categoryManager;
		private readonly IArticle _articleManager;
		private readonly IAuthor _authorManager;
		private readonly IProduct _productManager;

		public HomeController(ILogger<HomeController> logger, IBrand brandManager,
			ICategory categoryManager, IArticle articleManager, IAuthor authorManager,
			IProduct productManager)
		{
			_logger = logger;
			_brandManager = brandManager;
			_categoryManager = categoryManager;
			_articleManager = articleManager;
			_authorManager = authorManager;
			_productManager = productManager;
		}
		//=========================IActionResult HttpGet
		[HttpGet]
		public IActionResult NotFound() {
			return View();
		}
		[HttpGet]
		public IActionResult ActArticle()
		{
			var db = new DbContext();
			var article = db.Articles.ToList();
			var model = new ViewModel { Articles = article };
			return View(model);
		}
		[HttpGet]
		public IActionResult ActAuthor() {
			var db = new DbContext();
			var author = db.Authors.ToList();
			var model = new ViewModel { Authors = author };
			return View(model);
		}
		[HttpGet]
		public IActionResult ActBrand() {
			var db = new DbContext();
			var brand = db.Brands.ToList();
			var model = new ViewModel { Brands = brand };
			return View(model);
		}
		[HttpGet]
		public IActionResult ActCategory() {
			var db = new DbContext();
			var category = db.Categories.ToList();
			var model = new ViewModel { Categories = category };
			return View(model);
		}
		[HttpGet]
		public IActionResult ActProduct() {
			var db = new DbContext();
			var product = db.Products.ToList();
			var model = new ViewModel { Products = product };
			return View(model);
		}
		//=========================/IActionResult HttpGet

		public IActionResult Privacy()
		{
			return View();
		}

		//=========================IActionResult HttpPost
		// статья
		[HttpPost]
		public IActionResult ActArticle(string name, string header, Guid authorID, string text, string img,
										List<Guid> productList) {
			_articleManager.createArticle(name, header, authorID, DateTime.Now, text, new List<string> { img}, productList);

			return RedirectToAction("ActArticle");
		}
		// автор
		[HttpPost]
		public IActionResult ActAuthor(string name) {
			var db = new DbContext();
			if (!db.Authors.Any(x => x.name == name)) {
				_authorManager.createAuthor(name);
				return RedirectToAction("ActAuthor");
			} else return RedirectToAction("NotFound");
		}
		// бренд
		[HttpPost]
		public IActionResult ActBrand(string name, string disc) {
			_brandManager.createBrand(name, disc);

			return RedirectToAction("ActBrand");
		}
		// категория
		[HttpPost]
		public IActionResult ActCategory(string name, string sizeTable) {
			_categoryManager.createCategory(name, sizeTable);

			return RedirectToAction("ActCategory");
		}
		// товар
		[HttpPost]
		public IActionResult ActProduct(string name, double price, string link,
							string img, string categoryName, string brandName) {
			var db = new DbContext();
			var category = db.Categories.FirstOrDefault(x => x.name == categoryName);
			var brand = db.Brands.FirstOrDefault(x => x.name == brandName);

			_productManager.createProduct(name, price, link, img, category.id, brand.id);

			return RedirectToAction("ActProduct");
		}
		//=========================/IActionResult HttpPost

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
