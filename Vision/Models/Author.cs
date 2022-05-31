using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vision.Models {
	public class Author {

		[NotMapped]
		public static Author _default { get; set; }

		[Key]
		public Guid id { get; set; }

		public string name { get; set; }
		public List<Article> articles { get; set; }
		public double rating { get; set; }

		public Author() {
		}
	}
}
