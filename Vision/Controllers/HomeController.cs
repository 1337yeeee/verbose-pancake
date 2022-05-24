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


		public HomeController(ILogger<HomeController> logger, IBrand brandManager,
			ICategory categoryManager, IArticle articleManager, IAuthor authorManager,
			IProduct productManager,IUser userManager, DbContext context)
		{
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
			List<User> users= _context.Users.ToList();
			
			ViewModel viewModel = new ViewModel() { Authors = authors, Articles = articles, Brands= brands, Categories= categories, Products= products, Users = users };
			return View(viewModel);
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
