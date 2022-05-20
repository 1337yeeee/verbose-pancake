using System;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models {
	public class Product {

		[Key]
		public Guid id { get; set; }
		public string name { get; set; }
		public double price { get; set; }
		public string link { get; set; }
		public string img { get; set; }
		public double rating { get; set; }

		public Guid categoryID { get; set; }

		public Guid brandID { get; set; }

		public Product() {
		}
	}
}
