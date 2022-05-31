using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vision.Models {
	public class Brand {

		[NotMapped]
		public static Brand _default { get; set; }

		[Key]
		public Guid id { get; set; }

		public string name { get; set; }
		public string disc { get; set; }
		public List<Product> clothesID { get; set; }

		public Brand() {
		}
	}
}
