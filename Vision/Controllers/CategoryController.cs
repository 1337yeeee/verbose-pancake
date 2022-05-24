using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Vision.Models;

namespace Vision.Controllers
{
    public class CategoryController: Controller
    {
        private readonly DbContext _context;
        public CategoryController(DbContext context)
        {
            _context = context;
        }
        public ViewResult List()
        {
            //var clothes = _allClothes.Goods;
            var categories = _context.Categories;
            return View(categories);
        }
        [HttpGet]
        [Route("/Category/Index/{id:guid}")]
        public IActionResult Index(Guid id)
        {
            Category category = _context.Categories.Include(category => category.clothes).FirstOrDefault(brand => brand.id == id);
            return View(category);
        }
    }
}
