using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Vision.Models;

namespace Vision.Controllers
{
    public class BrandController: Controller
    {
        private readonly DbContext _context;
        
        public BrandController(DbContext context)
        {
            _context = context;
        }
        public ViewResult List()
        {
            //var clothes = _allClothes.Goods;
            var brands = _context.Brands;
            return View(brands);
        }
        [HttpGet]
        [Route("/Brand/Index/{id:guid}")]
        public IActionResult Index(Guid id)
        {
            Brand brand = _context.Brands.Include(brand => brand.clothesID).FirstOrDefault(brand => brand.id == id);
            return View(brand);
        }
    }
}
