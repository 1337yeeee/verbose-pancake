using System;
using System.Collections.Generic;
using System.Linq;
using Vision.Interfaces;
using Vision.Models;

namespace Vision.Data.Repository {
	public class SearchRepository : ISearchRepository {

		private readonly DbContext _context;

		public SearchRepository(DbContext context) {
			_context = context;
		}

		public List<Article> FilterArticle(string name = null, string authorName = null,
											Author author = null, string words = null) {

			if (name != null) {
				return _context.Articles.Where(x => x.name == name).ToList();
			} else if(authorName != null) {
				return _context.Articles.Where(x => x.author.name == authorName).ToList();
			} else if(author != null) {
				return _context.Articles.Where(x => x.author == author).ToList();
			} else if(words != null) {
				return _context.Articles.Where(x => x.text.Contains(words)).ToList();
			} else {
				return _context.Articles.ToList();
			}
		}

		public List<Author> FilterAuthor(string name = null, double ratingStart = 0,
										double ratingEnd = 5) {

			if (name != null) {
				return _context.Authors.Where(x => x.name == name).ToList();
			} else if(ratingStart != 0 || ratingEnd != 5) {
				if(ratingStart == 0) {
					return _context.Authors.Where(x => x.rating <= ratingEnd).ToList();
				} else if(ratingEnd == 0) {
					return _context.Authors.Where(x => x.rating >= ratingStart).ToList();
				} else {
					return _context.Authors.Where(x => x.rating <= ratingEnd && x.rating >= ratingStart).ToList();
				}
			} else {
				return _context.Authors.ToList();
			}
		}

		public List<Brand> FilterBrand(string name = null, string words = null) {

			if (name != null) {
				return _context.Brands.Where(x => x.name == name).ToList();
			} else if(words != null) {
				return _context.Brands.Where(x => x.disc.Contains(words)).ToList();
			} else {
				return _context.Brands.ToList();
			}
		}

		public List<Product> FilterProduct(string name = null, double priceStart = 0,
			double priceEnd = 9999999999, string categoryName = null, Category category = null,
			string brandName = null, Brand brand = null, double ratingStart = 0, double ratingEnd = 5) {

			var products = _context.Products.ToList();

			if (name == null || priceStart == 0 || priceEnd == 9999999999 ||
				categoryName == null || category == null || brandName == null ||
				brand == null || ratingStart == 0 || ratingEnd == 5) {
				return products;
			} else {
				if (name != null) {
					products = products.Where(x => x.name == name).ToList();
				}
				if (priceStart != 0 || priceEnd != 9999999999) {
					if (priceStart >= 0 && priceEnd >= 0) {
						if (priceStart == 0) {
							products = products.Where(x => x.price <= priceEnd).ToList();
						} else if (priceEnd == 9999999999) { //!!asafafafs
							return _context.Products.Where(x => x.price >= priceStart).ToList();
						} else {
							return _context.Products.Where(x => x.price <= priceEnd && x.price >= priceStart).ToList();
						}
					} else return _context.Products.ToList();
				}
				if (categoryName != null) {
					return _context.Products.Where(x => x.category.name == categoryName).ToList();
				}
				if (category != null) {
					return _context.Products.Where(x => x.category == category).ToList();
				}
				if (brandName != null) {
					return _context.Products.Where(x => x.brand.name == brandName).ToList();
				}
				if (brand != null) {
					return _context.Products.Where(x => x.brand == brand).ToList();
				}
				if (ratingStart != 0 || ratingEnd != 5) {
					if (ratingStart == 0) {
						return _context.Products.Where(x => x.rating <= ratingEnd).ToList();
					} else if (ratingEnd == 0) {
						return _context.Products.Where(x => x.rating >= ratingStart).ToList();
					} else {
						return _context.Products.Where(x => x.rating <= ratingEnd && x.rating >= ratingStart).ToList();
					}
				}
				return products;
			}
		}
	}
}
