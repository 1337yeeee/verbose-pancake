using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Data.Repository {
	public class SearchRepository : ISearchRepository {

		private readonly DbContext _context;

		public SearchRepository(DbContext context) {
			_context = context;
		}

		public List<Article> FilterArticle(string name = null, string authorName = null,
										string words = null) {

			var articles = _context.Articles.Include(articles => articles.author).ToList();

			if (name != null) {
				articles = articles.Where(x => x.name == name).ToList();
			} if(authorName != null) {
				articles = articles.Where(x => x.author.name == authorName).ToList();
			} if(words != null) {
				articles = articles.Where(x => x.text.Contains(words) == true).ToList();
			}

			return articles;
		}

		public List<Author> FilterAuthor(string name = null, double ratingStart = 0,
										double ratingEnd = 5) {

			var authors = _context.Authors.ToList();

			if (name != null) {
				authors = authors.Where(x => x.name == name).ToList();
			} else if (ratingStart != 0 || ratingEnd != 5) {
				if (ratingStart == 0) {
					authors = authors.Where(x => x.rating <= ratingEnd).ToList();
				} else if (ratingEnd == 0) {
					authors = authors.Where(x => x.rating >= ratingStart).ToList();
				} else {
					authors = authors.Where(x => x.rating <= ratingEnd && x.rating >= ratingStart).ToList();
				}
			}
			return authors;
		}

		public List<Brand> FilterBrand(string name = null, string words = null) {

			var brands = _context.Brands.ToList();

			if (name != null) {
				brands = brands.Where(x => x.name == name).ToList();
			} if(words != null) {
				brands = brands.Where(x => x.disc.Contains(words)).ToList();
			}
			return brands;
		}

		public List<Product> FilterProduct(string name = null, double priceStart = 0,
			double priceEnd = 9999999999, string categoryName = null, string brandName = null,
			double ratingStart = 0, double ratingEnd = 5) {

			var products = _context.Products.Include(x => x.category).Include(x => x.brand).ToList();

			if (name != null) {
				products = products.Where(x => x.name == name).ToList();
			}
			if (priceStart != 0 || priceEnd != 9999999999) {
				if (priceStart >= 0 && priceEnd >= 0) {
					if (priceStart == 0) {
						products = products.Where(x => x.price <= priceEnd).ToList();
					} else if (priceEnd == 9999999999) { //!!asafafafs
						products = products.Where(x => x.price >= priceStart).ToList();
					} else {
						products = products.Where(x => x.price <= priceEnd && x.price >= priceStart).ToList();
					}
				}
			}
			if (categoryName != null) {
				products = products.Where(x => x.category.name == categoryName).ToList();
			}
			if (brandName != null) {
				products = products.Where(x => x.brand.name == brandName).ToList();
			}
			if (ratingStart != 0 || ratingEnd != 5) {
				if (ratingStart == 0) {
					products = products.Where(x => x.rating <= ratingEnd).ToList();
				} else if (ratingEnd == 0) {
					products = products.Where(x => x.rating >= ratingStart).ToList();
				} else {
					products = products.Where(x => x.rating <= ratingEnd && x.rating >= ratingStart).ToList();
				}
			}
			return products;
		}
	}
}
