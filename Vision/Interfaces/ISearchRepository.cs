using System;
using System.Collections.Generic;
using Vision.Models;

namespace Vision.Interfaces {
	public interface ISearchRepository {

		public List<Article> FilterArticle(string name = null, string authorName = null,
										string words = null);

		public List<Product> FilterProduct(string name = null, double priceStart = 0,
			double priceEnd = 9999999999, string categoryName = null,
			string brandName = null, double ratingStart = 0, double ratingEnd = 5);

		public List<Brand> FilterBrand(string name = null, string words = null);

		public List<Author> FilterAuthor(string name = null, double ratingStart = 0, double ratingEnd = 5);
	}
}
