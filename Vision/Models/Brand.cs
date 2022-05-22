using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models {
	public class Brand {

		[Key]
		public Guid id { get; set; }

		public string name { get; set; }
		public string disc { get; set; }
		public List<Product> clothesID { get; set; }

		public Brand() {
		}
	}
}
