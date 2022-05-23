using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Vision.Models;

namespace Vision.Controllers
{
    public class ArticleController : Controller
    {
        private readonly DbContext _context;
        public ArticleController(DbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("Article/Index/{id:guid}")]
        public IActionResult Index(Guid id)
        {
            Article article = _context.Articles.FirstOrDefault(article => article.id == id);
            return View(article);
        }
    }
}
