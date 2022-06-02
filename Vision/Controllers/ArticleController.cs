using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            var articles = _context.Articles.ToList();
            Article article = _context.Articles.Include(article => article.img).FirstOrDefault(article => article.id == id);
            Image img = article.img[0] ?? null;
            if(img != null)
            {
                string imageBase64Data =
                Convert.ToBase64String(img.ImageData);
                string imageDataURL =
                string.Format("data:image/jpg;base64,{0}",
                imageBase64Data);
                ViewBag.ImageTitle = img.ImageTitle;
                ViewBag.ImageDataUrl = imageDataURL;
            }
            List<Assessment> assessments = _context.Assessments.Where(a => a.id == id).ToList();
            if(assessments.Count != 0)
            {
                article.AverageAssessment = assessments.Average(a => a.Rating);
            }
            
            return View(new ViewModel { Article = article, Articles = articles, id = id});
        }
        [HttpPost]
        public IActionResult Assess(int rating, string articleId)
        {
            if (String.IsNullOrEmpty(articleId))
            {
                return NotFound();
            }
            Guid guid = Guid.Parse(articleId);
            Article article = _context.Articles.FirstOrDefault(a => a.id == guid);
            _context.Assessments.Add(new Assessment() { id = Guid.NewGuid(), Rating = rating, ArticleId = article.id});
            _context.SaveChanges();
            return Redirect($"/Article/Index/{articleId}");
        }
    }
}
