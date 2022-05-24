using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
			IProduct productManager,IUser userManager, DbContext context)
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
			List<User> users= _context.Users.ToList();
			
			ViewModel viewModel = new ViewModel() { Authors = authors, Articles = articles, Brands= brands, Categories= categories, Products= products, Users = users };
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
			Article newArticle = new Article() { id = Guid.NewGuid(), name = name, header = header, text = text, date = DateTime.Now, img = new List<Image>(), productList = new List<Product>(), author = author, authorID = author.id};
			if (newArticle == null) {
				return RedirectToAction("Index");
			}
			var file = Request.Form.Files.FirstOrDefault(f => f.Name == "ArticleImage");
			if(file != null)
            {
				Image image = new Image() { id = Guid.NewGuid()};
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
			Product newProduct = new Product() { id =Guid.NewGuid(), name= name, price= price,  link= link, rating= rating, categoryID =category.id,category= category, brand= brand, brandID=brand.id };
			if (newProduct == null)
			{
				return RedirectToAction("Index");
			}
			var file = Request.Form.Files.FirstOrDefault(f => f.Name == "ProductImage");
			if (file != null)
			{
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
        [HttpGet]
		public IActionResult ActRegistration()
        {
			ViewModel viewmodel = new ViewModel();
			viewmodel.Users = _context.Users.ToList();
			return View(viewmodel);
        }
		[HttpPost]
		public IActionResult ActRegistration(string Login, string Password, string Name, string Sexgender, string Phone, int Age, Guid Id)
		{
			User user = new User() { Id = Guid.NewGuid(), Name= Name,Sexgender= Sexgender,Age=Age, Phone = Phone, Login=Login, Password= Password  };
			_context.Users.Add(user);
			_context.SaveChanges();
			return RedirectToAction("ActRegistration");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
