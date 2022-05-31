using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vision.Models {
	public class Category {

		[NotMapped]
		public static Category _default { get; set; }

		[Key]
		public Guid id { get; set; }

		public string name { get; set; }
		public string sizeTable { get; set; }
		public List<Product> clothes { get; set; }
	}
}
