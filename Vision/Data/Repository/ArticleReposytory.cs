using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Data.Repository {
	public class ArticleReposytory : IArticle {

		private readonly DbContext _context;

		public ArticleReposytory(DbContext context) {
			_context = context;
		}

		public async Task<IList<Article>> allArticles() => await _context.Articles.ToListAsync();

		public async Task createArticle(string name, string header, Guid authorID, DateTime date, string text, string path, string productName) {
			var product = _context.Products.FirstOrDefault(x => x.name == productName);
			var img = _context.Images.FirstOrDefault(x => x.path == path);
			var article = new Article {
				name = name,
				header = header,
				authorID = authorID,
				date = date,
				text = text,
				img = new List<Image> { img },
				productList = new List<Product> { product}
			};
			_context.Articles.Add(article);

			await _context.SaveChangesAsync();
		}

		public async Task delete(Guid id) {
			var article = _context.Articles.FirstOrDefault(x => x.id == id);
			_context.Articles.Remove(article);

			await _context.SaveChangesAsync();
		}
	}
}
