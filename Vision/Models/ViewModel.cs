using System;
using System.Collections.Generic;

namespace Vision.Models {
	public class ViewModel {

		public IEnumerable<Product> Products { get; set; }
		public IEnumerable<Category> Categories { get; set; }
		public IEnumerable<Brand> Brands { get; set; }
		public IEnumerable<Article> Articles { get; set; }
		public IEnumerable<Author> Authors { get; set; }
		public string ModelOfSearch { get; set; }
		public Guid id { get; set; }
		public string ImageDataUrl { get; set; }
		public Article Article { get; set; }

		public IEnumerable<User> Users { get; set; }


		//public ViewModel() {
		//}
	}
}
