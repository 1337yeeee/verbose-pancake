using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models {
	public class Article {

		[Key]
		public Guid id { get; set; }
		public string name { get; set; }
		public string header { get; set; }
		public Guid authorID { get; set; }
		public Author author { get; set; }
		public DateTime date { get; set; }
		public string text { get; set; }
		public List<Image> img { get; set; }
		public List<Product> productList { get; set; }

		public Article() {
		}
	}
}
