using System;
using Microsoft.AspNetCore.Mvc;
using Vision.Interfaces;

namespace Vision.Controllers {
	public class ClothesController : Controller {
		
		private readonly IAllClothes _allClothes;
		private readonly ICategory _allCategories;

		public ClothesController(IAllClothes iAllClothes, ICategory iCategory) {
			_allClothes = iAllClothes;
			_allCategories = iCategory;
		}

		public ViewResult List() {
			var clothes = _allClothes.Goods;
			return View(clothes);
		}
	}
}
