using System;
namespace Vision.Models {
	public class SearchModel {

		// all
		public string? name { get; set; }

		// article brand
		public string? words { get; set; }

		// article
		public string? authorName { get; set; }
		public Author? author { get; set; }

		// product
		public double? priceStart { get; set; }
		public double? priceEnd { get; set; }
		public string? categoryName { get; set; }
		public Category? category { get; set; }
		public string? brandName { get; set; }
		public Brand? brand { get; set; }

		// product author
		public double? ratingStart { get; set; }
		public double? ratingEnd { get; set; }

	}
}
