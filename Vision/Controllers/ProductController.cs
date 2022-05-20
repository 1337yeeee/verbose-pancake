using System;
using Microsoft.AspNetCore.Mvc;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Controllers {
	public class ProductController : Controller {
		
		//private readonly IAllClothes _allClothes;
		//private readonly ICategory _allCategories;
		private readonly DbContext _context;

		public ProductController(DbContext context) {
			//_allClothes = iAllClothes;
			//_allCategories = iCategory;
			DbSead.Create(context);
			_context = context;
		}

		public ViewResult List() {
			//var clothes = _allClothes.Goods;
			var products = _context.Products;
			return View(products);
		}
	}
}
