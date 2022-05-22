using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models {
	public class Category {

		[Key]
		public Guid id { get; set; }

		public string name { get; set; }
		public string sizeTable { get; set; }
		public List<Product> clothes { get; set; }

		public Category() {
		}
	}
}
