using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vision.Data.Repository;
using Vision.Models;
using Vision.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Vision.Controllers {
	public class SearchController : Controller {

		private readonly ILogger<HomeController> _logger;
		private readonly DbContext _context;

		private readonly ISearchRepository _searchManager;

		private static string _SearchModel;
		private static List<Article> _anwerArt;
		private static List<Product> _anwerPro;
		private static List<Author> _anwerAut;
		private static List<Brand> _anwerBra;

		public SearchController(ILogger<HomeController> logger, DbContext context, ISearchRepository searchManager) {
			_logger = logger;
			_context = context;
			_searchManager = searchManager;
		}

		[HttpGet]
		public IActionResult Index(ViewModel model = null) {
			List<Author> authors = _context.Authors.ToList();
			List<Article> articles = _context.Articles.ToList();
			List<Brand> brands = _context.Brands.ToList();
			List<Category> categories = _context.Categories.ToList();
			List<Product> products = _context.Products.ToList();
			List<User> users = _context.Users.ToList();

			ViewModel viewModel = new ViewModel() {ModelOfSearch = _SearchModel,
				Authors = (_SearchModel== "Author")?_anwerAut:authors,
				Articles = (_SearchModel == "Article") ? _anwerArt : articles,
				Brands = (_SearchModel == "Brand") ? _anwerBra : brands,
				Products = (_SearchModel == "Product") ? _anwerPro : products,
				Categories = categories, Users = users };

			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Index(string SearchModel, string name = null,
			string authorName = null, string words = null, double ratingStart = 0,
			double ratingEnd = 5, double priceStart = 0, double priceEnd = 9999999999,
			string categoryName = null, string brandName = null) {

			_SearchModel = SearchModel;

			if(SearchModel == "Article") {
				_anwerArt = _searchManager.FilterArticle(name, authorName, words);
			} else if(SearchModel == "Product") {
				_anwerPro = _searchManager.FilterProduct(name, priceStart, priceEnd,
								categoryName, brandName, ratingStart, ratingEnd);
			} else if(SearchModel == "Brand") {
				_anwerBra = _searchManager.FilterBrand((name!=null)?name:brandName, words);
			} else if(SearchModel == "Author") {
				_anwerAut = _searchManager.FilterAuthor((name!=null)?name:authorName, ratingStart, ratingEnd);
			}

			return RedirectToAction("Index");
		}

	}
}
