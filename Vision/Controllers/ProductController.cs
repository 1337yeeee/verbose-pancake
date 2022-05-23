using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
			_context = context;
		}

		public ViewResult List() {
			//var clothes = _allClothes.Goods;
			var products = _context.Products;
			return View(products);
		}
		[HttpGet]
		[Route("Product/Index/{id:guid}")]
		public IActionResult Index(Guid id)
        {
			Product product = _context.Products.Include(p => p.img).FirstOrDefault(p => p.id == id);
			if (product.img != null && product.img.ImageData != null)
			{
				string imageBase64Data =
				Convert.ToBase64String(product.img.ImageData);
				string imageDataURL =
				string.Format("data:image/jpg;base64,{0}",
				imageBase64Data);
				ViewBag.ImageTitle = product.img.ImageTitle;
				ViewBag.ImageDataUrl = imageDataURL;
			}
			return View(product);
        }
	}
}
