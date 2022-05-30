using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Vision.Models;

namespace Vision.Controllers {
	public class AdminController : Controller {

		private readonly ILogger<AdminController> _logger;
		private readonly DbContext _context;

		public AdminController(ILogger<AdminController> logger, DbContext context) {
			_logger = logger;
			_context = context;
		}


		[HttpGet]
		public IActionResult Index() {
			List<Author> authors = _context.Authors.ToList();
			List<Article> articles = _context.Articles.ToList();
			List<Brand> brands = _context.Brands.ToList();
			List<Category> categories = _context.Categories.ToList();
			List<Product> products = _context.Products.ToList();
			List<User> users = _context.Users.ToList();

			ViewModel viewModel = new ViewModel() { Authors = authors, Articles = articles, Brands = brands, Categories = categories, Products = products, Users = users };
			return View(viewModel);
		}
		[HttpPost]
		public IActionResult ActAuthor(string name, double rating) {
			Author newAuthor = new Author() { id = Guid.NewGuid(), name = name, rating = rating, articles = new List<Article>() };
			if (newAuthor == null) {
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
			var file = Request.Form.Files.FirstOrDefault(f => f.Name == "ArticleImage");
			if (file != null) {
				Image image = new Image() { id = Guid.NewGuid() };
				image.ImageTitle = file.FileName;
				MemoryStream ms = new MemoryStream();
				file.CopyTo(ms);
				image.ImageData = ms.ToArray();
				newArticle.img = new List<Image>() { image };
			}
			_context.Articles.Add(newArticle);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpPost]
		public IActionResult ActBrand(string name, string disc) {
			Brand newBrand = new Brand() { id = Guid.NewGuid(), name = name, disc = disc, clothesID = new List<Product>() };
			if (newBrand == null) {
				return RedirectToAction("Index");
			}
			//	newBrand.brands = new List<Brand>();
			_context.Brands.Add(newBrand);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpPost]
		public IActionResult ActCategory(string name, string sizeTable) {
			Category newCategory = new Category() { id = Guid.NewGuid(), name = name, sizeTable = sizeTable, clothes = new List<Product>() };
			if (newCategory == null) {
				return RedirectToAction("Index");
			}
			//	newBrand.brands = new List<Brand>();
			_context.Categories.Add(newCategory);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpPost]
		public IActionResult ActProduct(string name, double price, string link, double rating, string categoryName, string brandName) {
			Category category = _context.Categories.FirstOrDefault(x => x.name == categoryName);
			Brand brand = _context.Brands.FirstOrDefault(x => x.name == brandName);
			Product newProduct = new Product() { id = Guid.NewGuid(), name = name, price = price, link = link, rating = rating, categoryID = category.id, category = category, brand = brand, brandID = brand.id };
			if (newProduct == null) {
				return RedirectToAction("Index");
			}
			var file = Request.Form.Files.FirstOrDefault(f => f.Name == "ProductImage");
			if (file != null) {
				Image image = new Image() { id = Guid.NewGuid() };
				image.ImageTitle = file.FileName;
				MemoryStream ms = new MemoryStream();
				file.CopyTo(ms);
				image.ImageData = ms.ToArray();
				newProduct.img = image;
			}
			_context.Products.Add(newProduct);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult DeleteAuthor(Guid id) {
			var author = _context.Authors.Include(a => a.articles).FirstOrDefault(x => x.id == id);
			var ID = new Guid();
			foreach (var article in author.articles) {
				article.author = new Author { name = "Default", rating = 0, id = ID };
				article.authorID = ID;
			}
			_context.Authors.Remove(author);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult DeleteArticle(Guid id) {
			var article = _context.Articles.Include(a => a.author).FirstOrDefault(x => x.id == id);
			_context.Articles.Remove(article);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult DeleteBrand(Guid id) {
			var brand = _context.Brands.FirstOrDefault(x => x.id == id);
			_context.Brands.Remove(brand);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		
		[HttpPost]
		public IActionResult DeleteCategory(Guid id) {
			var category = _context.Categories.FirstOrDefault(x => x.id == id);
			_context.Categories.Remove(category);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		
		[HttpPost]
		public IActionResult DeleteProduct(Guid id) {
			var product = _context.Products.FirstOrDefault(x => x.id == id);
			_context.Products.Remove(product);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		[Route("Admin/Article/{id:guid}")]
		public IActionResult Article(Guid id) {
			var article = _context.Articles.FirstOrDefault(x => x.id == id);

			return View(article);
		}

		[HttpPost]
		public IActionResult UpdateArticle(string name, string header, string text, string id) {
			Guid guid = Guid.Parse(id);
			
			return Redirect($"/Admin/Article/{id}");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
