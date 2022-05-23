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
		private readonly DbContext _context;

		//private readonly IBrand _brandManager;
		//private readonly ICategory _categoryManager;
		//private readonly IArticle _articleManager;
		//private readonly IAuthor _authorManager;
		//private readonly IProduct _productManager;

		public HomeController(ILogger<HomeController> logger, IBrand brandManager,
			ICategory categoryManager, IArticle articleManager, IAuthor authorManager,
			IProduct productManager, DbContext context)
		{
			_logger = logger;
			//_brandManager = brandManager;
			//_categoryManager = categoryManager;
			//_articleManager = articleManager;
			//_authorManager = authorManager;
			//_productManager = productManager;
			_context = context;
		}
		[HttpGet]
		public IActionResult Index() {
			List<Author> authors = _context.Authors.ToList();
			List<Article> articles = _context.Articles.ToList();
			List<Brand> brands = _context.Brands.ToList();
			List<Category> categories = _context.Categories.ToList();
			List<Product> products = _context.Products.ToList();
			
			ViewModel viewModel = new ViewModel() { Authors = authors, Articles = articles, Brands= brands, Categories= categories, Products= products };
			return View(viewModel);
		}
		[HttpPost]
		public IActionResult ActAuthor(string name, double rating) {
			Author newAuthor = new Author() { id = Guid.NewGuid(), name = name, rating = rating, articles = new List<Article>() };
			if(newAuthor == null) {
				return RedirectToAction("Index");
			}
			newAuthor.articles = new List<Article>();
			_context.Authors.Add(newAuthor);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpPost]
		public IActionResult ActArticle(string name, string header, string authorName, string text) {
			Author author = _context.Authors.FirstOrDefault(x => x.name == authorName);
			Article newArticle = new Article() { id = Guid.NewGuid(), name = name, header = header, text = text, date = DateTime.Now, img = new List<Image>(), productList = new List<Product>(), author = author, authorID = author.id };
			if (newArticle == null) {
				return RedirectToAction("Index");
			}
			_context.Articles.Add(newArticle);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpPost]
		public IActionResult ActBrand(string name, string disc)
        {
			Brand newBrand = new Brand() { id = Guid.NewGuid(), name = name, disc = disc, clothesID = new List<Product>() };
            if (newBrand == null)
            {
				return RedirectToAction("Index");
            }
		//	newBrand.brands = new List<Brand>();
			_context.Brands.Add(newBrand);
			_context.SaveChanges();
			return RedirectToAction("Index");
        }
		[HttpPost]
		public IActionResult ActCategory(string name, string sizeTable)
		{
			Category newCategory = new Category() { id = Guid.NewGuid(), name = name, sizeTable = sizeTable, clothes = new List<Product>() };
			if (newCategory == null)
			{
				return RedirectToAction("Index");
			}
			//	newBrand.brands = new List<Brand>();
			_context.Categories.Add(newCategory);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
        [HttpPost]
		public IActionResult ActProduct(string name, double price, string link, double rating, string categoryName, string brandName)
        {
			Category category = _context.Categories.FirstOrDefault(x => x.name == categoryName);
			Brand brand = _context.Brands.FirstOrDefault(x => x.name == brandName);
			Product newProduct = new Product() { id =Guid.NewGuid(), name= name, price= price,  link= link, rating= rating, img = new Image(), categoryID =category.id,category= category, brand= brand, brandID=brand.id };
			if (newProduct == null)
			{
				return RedirectToAction("Index");
			}
			_context.Products.Add(newProduct);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	

	//=========================IActionResult HttpGet
	//[HttpGet]
	//public IActionResult NotFound() {
	//	return View();
	//}
	//[HttpGet]
	//public IActionResult ActArticle()
	//{
	//	var db = new DbContext();
	//	var article = db.Articles.ToList();
	//	var model = new ViewModel { Articles = article };
	//	return View(model);
	//}
	//[HttpGet]
	//public IActionResult ActAuthor() {
	//	var db = new DbContext();
	//	var author = db.Authors.ToList();
	//	var model = new ViewModel { Authors = author };
	//	return View(model);
	//}
	//[HttpGet]
	//public IActionResult ActBrand() {
	//	var db = new DbContext();
	//	var brand = db.Brands.ToList();
	//	var model = new ViewModel { Brands = brand };
	//	return View(model);
	//}
	//[HttpGet]
	//public IActionResult ActCategory() {
	//	var db = new DbContext();
	//	var category = db.Categories.ToList();
	//	var model = new ViewModel { Categories = category };
	//	return View(model);
	//}
	//[HttpGet]
	//public IActionResult ActProduct() {
	//	var db = new DbContext();
	//	var product = db.Products.ToList();
	//	var model = new ViewModel { Products = product };
	//	return View(model);
	//}
	////=========================/IActionResult HttpGet

	//public IActionResult Privacy()
	//{
	//	return View();
	//}

	//=========================IActionResult HttpPost
	// статья
	//[HttpPost]
	//public IActionResult ActArticle(string name, string header, Guid authorID, string text, string path,
	//								string productName) {
	//	_articleManager.createArticle(name, header, authorID, DateTime.Now, text, path, productName);
	//	return RedirectToAction("ActArticle");
	//}
	//// автор
	//[HttpPost]
	//public IActionResult ActAuthor(string name) {
	//	var db = new DbContext();
	//	if (!db.Authors.Any(x => x.name == name)) {
	//		_authorManager.createAuthor(name);
	//		return RedirectToAction("ActAuthor");
	//	} else return RedirectToAction("NotFound");
	//}
	//// бренд
	//[HttpPost]
	//public IActionResult ActBrand(string name, string disc) {
	//	_brandManager.createBrand(name, disc);

	//	return RedirectToAction("ActBrand");
	//}
	//// категория
	//[HttpPost]
	//public IActionResult ActCategory(string name, string sizeTable) {
	//	_categoryManager.createCategory(name, sizeTable);

	//	return RedirectToAction("ActCategory");
	//}
	//// товар
	//[HttpPost]
	//public IActionResult ActProduct(string name, double price, string link,
	//					string img_, string categoryName, string brandName) {
	//	var db = new DbContext();
	//	var category = db.Categories.FirstOrDefault(x => x.name == categoryName);
	//	var brand = db.Brands.FirstOrDefault(x => x.name == brandName);
	//	var img = new Image { path = img_ };

	//	_productManager.createProduct(name, price, link, img, category.id, brand.id);

	//	return RedirectToAction("ActProduct");
	//}
	//=========================/IActionResult HttpPost

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
